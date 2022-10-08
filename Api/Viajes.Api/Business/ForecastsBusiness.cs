using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using AuthenticationHandler.Business;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Data;
using FileProcessing;
using CrmTc.DAL.Models;
using System.Globalization;
using TravelPlansConfiguration = Viajes.Api.Configuration.TravelPlansConfiguration;

namespace IO.Swagger.Business
{
    public class ForecastsBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        private TravelPlansConfiguration ParametrosConfiguracion { get; set; }

        public ForecastsBusiness(TmsTcEntities context, CrmTcEntities crmContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            ParametrosConfiguracion = new TravelPlansConfiguration().SetTravelPlansConfiguration(Context);
        }

        public ObjectResult GetForecasts(DateTime? startDate, DateTime? endDate, bool? edited)
        {
            var forecasts = GetForecasts(Context, startDate, endDate, edited);
            return new OkObjectResult(forecasts);
        }

        public static List<Models.Forecast> GetForecasts(TmsTcEntities context, DateTime? startDate, DateTime? endDate, bool? edited)
        {
            var forecastsQuery = context.Forecast.AsQueryable();
            if (startDate.HasValue)
                forecastsQuery = forecastsQuery.Where(f => f.Date >= startDate);
            if (endDate.HasValue)
                forecastsQuery = forecastsQuery.Where(f => f.Date <= endDate);
            if ((bool)edited)
                forecastsQuery = forecastsQuery.Where(f => f.TrucksQuantityEdited != null);

            var forecasts = forecastsQuery
                .OrderBy(f => f.Customer)
                .ThenBy(f => f.Origin)
                .ThenBy(f => f.MarketType)
                .ThenBy(f => f.TruckType)
                .ThenBy(f => f.Date)
                .Select(f => new Models.Forecast
                {
                    Customer = f.Customer,
                    Origin = f.Origin,
                    MarketType = f.MarketType,
                    TruckType = f.TruckType,
                    Date = f.Date,
                    TrucksQuantity = f.TrucksQuantity,
                    TrucksQuantityEdited = f.TrucksQuantityEdited

                }).ToList();

            return forecasts;
        }

        public ObjectResult UpdateForecasts(List<Models.Forecast> body, DateTime? startDate, DateTime? endDate)
        {
            var forecastsQuery = Context.Forecast.AsQueryable();
            if (startDate.HasValue)
                forecastsQuery = forecastsQuery.Where(f => f.Date >= startDate);
            if (endDate.HasValue)
                forecastsQuery = forecastsQuery.Where(f => f.Date <= endDate);

            foreach (Models.Forecast forecast in body)
            {
                if (startDate.HasValue)
                    if (forecast.Date < startDate)
                    {
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Fecha Inválida", Detail = "La fecha " + forecast.Date + " es anterior a " + startDate });
                    }

                if (endDate.HasValue)
                    if (forecast.Date > endDate)
                    {
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Fecha Inválida", Detail = "La fecha " + forecast.Date + " es mayor a " + endDate });
                    }

                var currentEntry = forecastsQuery.Where(clp => clp.Customer == forecast.Customer && clp.Origin == forecast.Origin && clp.MarketType == forecast.MarketType && clp.TruckType == forecast.TruckType && clp.Date == forecast.Date).FirstOrDefault();
                if (currentEntry == null)
                {
                    Context.Forecast.Add(new Forecast
                    {
                        Customer = forecast.Customer.Value,
                        Origin = forecast.Origin.Value,
                        MarketType = forecast.MarketType.Value,
                        TruckType = forecast.TruckType.Value,
                        Date = forecast.Date.Value,
                        TrucksQuantity = forecast.TrucksQuantity,
                        TrucksQuantityEdited = forecast.TrucksQuantityEdited,
                        CreatedBy = CurrentUser.Id,
                        UpdatedBy = CurrentUser.Id
                    });
                }
                else
                {
                    currentEntry.TrucksQuantity = forecast.TrucksQuantity;
                    currentEntry.TrucksQuantityEdited = forecast.TrucksQuantityEdited;
                    currentEntry.UpdatedBy = CurrentUser.Id;
                    currentEntry.UpdatedAt = DateTime.Now;
                }
            }

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El forecast fue actualizado correctamente" });
        }

        public ObjectResult UploadForecasts(IFormFile file)
        {
            var dataSet = new IFormFileReader(file).GetDataSet(1);

            var customers = CrmContext.Clientes.Where(c => c.Active == true).ToDictionary(c => c.Id, c => c.NombreComercial);
            var origins = CrmContext.Origenes.Where(c => c.Active == true).ToDictionary(c => c.Id, c => c.Nombre);
            var marketTypes = Context.MarketType.Where(c => c.Active == true).ToDictionary(c => c.Id, c => c.Name);
            var truckTypes = Context.TruckType.Where(c => c.Active == true).ToDictionary(c => c.Id, c => c.Description);
            var operativeOffices = CrmContext.OficinasOperativas.ToList();

            List<Models.Forecast> forecasts = new List<Models.Forecast>();
            var headerRows = 3;
            var notDateColumns = new string[] { "ID para TMS", "Cliente", "Oficina", "Mercado", "Tipo Tractor"};

            foreach (DataTable sheet in dataSet.Tables)
            {
                foreach (DataRow row in sheet.Rows)
                {
                    int? customer = int.Parse(row["ID para TMS"].ToString());
                    if (customer == 0)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Cliente Inválido", Detail = row["cliente"] + " no es un cliente válido en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    int? origin = origins.FirstOrDefault(x => x.Value == (string)row["oficina"]).Key;
                    if (origin == 0)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Oficina Inválida", Detail = row["oficina"] + " no es una oficina válida en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    int? marketType = marketTypes.FirstOrDefault(x => x.Value == (string)row["mercado"]).Key;
                    if (marketType == 0)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Tipo de Mercado Inválido", Detail = row["mercado"] + " no es un tipo de mercado válido en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    int? truckType = truckTypes.FirstOrDefault(x => x.Value == (string)row["tipo Tractor"]).Key;
                    if (truckType == 0)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Tipo de Tractor Inválido", Detail = row["tipo Tractor"] + " no es un tipo de tráctor válido en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    // Valida si la oficina y el cliente que se ingresó corresponde con una oficina (operativa) existente
                    var operative = operativeOffices.FirstOrDefault(o => o.Clientesid == customer && o.Oficinasid == origin);
                    if (operative == null)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Oficina inválida", Detail = row["oficina"] + " no es una oficina válida en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });
                   
                    origin = operative.Id;



                    foreach (DataColumn column in sheet.Columns)
                    {
                        if(!notDateColumns.Contains(column.ColumnName)) {
                            DateTime date = Convert.ToDateTime(column.ColumnName);
                            int? trucksQuantity = null;
                            if (row[column] != DBNull.Value)
                                trucksQuantity = (int)(double)row[column];

                            var forecast = new Models.Forecast()
                            {
                                Customer = customer,
                                Origin = origin,
                                MarketType = marketType,
                                TruckType = truckType,
                                Date = date,
                                TrucksQuantity = trucksQuantity
                            };

                            if(forecast.Date < DateTime.Now.AddDays(ParametrosConfiguracion.ResticcionForecastEdicion).Date)
                                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Rango de fechas inválidas", Detail = "No puede ingresar un registro con una fecha anterior a: " + DateTime.Now.AddDays(ParametrosConfiguracion.ResticcionForecastEdicion).Date + " en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });


                            forecasts.Add(forecast);
                        }                   
                    }
                }
            }

            return new OkObjectResult(forecasts);
        }
    }
}
