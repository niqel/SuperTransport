using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System.Linq;
using System;
using System.Collections.Generic;
using Viajes.Api.Enums;
using Viajes.Api.Enums.Metrics;
using ListdbTc.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Viajes.Api.Common;

namespace IO.Swagger.Business
{
    public class LoadPlansBusiness : BusinessBase
    {
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        public LoadPlansBusiness(TmsTcEntities context, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            ListdbTcContext = listdbTcContext;
        }

        public ObjectResult GetLoadPlans(int? year, int? month)
        {
            var startDate = new DateTime(year.Value, month.Value, 1);
            var endDate = startDate.AddMonths(1);
            var loadPlan = GetLoadPlans(Context, startDate, endDate);
            return new OkObjectResult(loadPlan);
        }

        public static List<Models.LoadPlan> GetLoadPlans(TmsTcEntities context, DateTime startDate, DateTime endDate)
        {
            var loadPlan = context.LoadPlan.Where(lp => lp.Date >= startDate && lp.Date < endDate)
               .OrderBy(lp => lp.MarketType)
               .ThenBy(lp => lp.Customer)
               .ThenBy(lp => lp.Office)
               .ThenBy(lp => lp.Date)
               .Select(lp => new Models.LoadPlan
               {
                   MarketType = lp.MarketType,
                   Customer = lp.Customer,
                   Office = lp.Office,
                   Date = lp.Date,
                   Vins = new VinsPlan { Planned = lp.VinsPlanned, Positioned = lp.VinsPositioned, Loaded = lp.VinsLoaded }
               }).ToList();
            return loadPlan;
        }


        public ObjectResult UpdateLoadPlans(int? year, int? month)
        {
            var startDate = new DateTime(year.Value, month.Value, 1);
            var endDate = startDate.AddMonths(1);

            return UpdateLoadPlans(Context, CurrentUser, UpdateLoadPlans(), startDate, endDate);
        }

        private List<Models.LoadPlan> UpdateLoadPlans()
        {
            return UpdateLoadPlans(Context);
        }

        public static List<Models.LoadPlan> UpdateLoadPlans(TmsTcEntities context)
        {
            List<Models.LoadPlan> planDeCarga = LoadPlanView.GetLoadPlanView(context, 0).Select(vw => new Models.LoadPlan
            {
                Customer = vw.Cliente,
                Office = vw.Oficina,
                MarketType = vw.Mercado,
                Date = vw.Fecha,
                Vins = new VinsPlan
                {
                    Loaded = vw.Cargado,
                    Planned = vw.Demanda,
                    Positioned = vw.Posicionado + vw.Arribo
                }
            }).ToList();
            return planDeCarga;
        }

        public static ObjectResult UpdateLoadPlans(TmsTcEntities context, AuthenticationHandler.Models.CurrentUser currentUser, List<Models.LoadPlan> body, DateTime startDate, DateTime endDate)
        {
            if (currentUser == null)
                currentUser = new AuthenticationHandler.Models.CurrentUser { Id = 0 };
            var currentLoadPlan = context.LoadPlan.Where(lp => lp.Date >= startDate).ToList();
            foreach (Models.LoadPlan loadPlan in body)
            {
                if (loadPlan.Date < startDate || loadPlan.Date > endDate)
                {
                    //return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Fecha Inválida", Detail = "La fecha " + loadPlan.Date + " no corresponde con el plan de carga" });
                }

                var currentEntry = currentLoadPlan.Where(clp => clp.MarketType == loadPlan.MarketType && clp.Customer == loadPlan.Customer && clp.Office == loadPlan.Office && clp.Date == loadPlan.Date).FirstOrDefault();
                if (currentEntry == null)
                {
                    var newEntry = new TmsTcAPI.DAL.Models.LoadPlan
                    {
                        MarketType = loadPlan.MarketType.Value,
                        Customer = loadPlan.Customer.Value,
                        Office = loadPlan.Office.Value,
                        Date = loadPlan.Date.Value,
                        VinsPlanned = loadPlan.Vins.Planned,
                        VinsPositioned = loadPlan.Vins.Positioned,
                        VinsLoaded = loadPlan.Vins.Loaded,
                        CreatedBy = currentUser.Id,
                        UpdatedBy = currentUser.Id
                    };
                    context.LoadPlan.Add(newEntry);
                }
                else
                {
                    currentEntry.VinsPlanned = loadPlan.Vins.Planned;
                    currentEntry.VinsPositioned = loadPlan.Vins.Positioned;
                    currentEntry.VinsLoaded = loadPlan.Vins.Loaded;
                    currentEntry.UpdatedBy = currentUser.Id;
                    currentEntry.UpdatedAt = DateTime.Now;
                }
            }

            context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El plan de carga fue actualizado correctamente" });
        }


        private IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        public void UpdateLoadPlanOfPreviousDay()
        {
            DateTime beforeDate = DateTime.Today.AddDays(-1);

            var LoadPlanVinsPlanned = (from Aforecast in Context.Forecast
                                       where Aforecast.Date == beforeDate
                                       group Aforecast by new
                                       {
                                           Aforecast.Origin,
                                           Aforecast.MarketType
                                       } into g
                                       select new
                                       {
                                           Office = g.Key.Origin,
                                           g.Key.MarketType,
                                           VinsPlanned = g.Sum(x => x.TrucksQuantity)
                                       }).ToList();

            //var LoadPLanVinsPositioned = (from AtruckStatusHistory in Context.TruckStatusHistory
            //                     where AtruckStatusHistory.PositionedDate == beforeDate
            //                     group AtruckStatusHistory by new
            //                     {
            //                         AtruckStatusHistory.OfficeAssigned,
            //                         AtruckStatusHistory.MarketType
            //                     } into g
            //                     select new
            //                     {
            //                         Office = g.Key.OfficeAssigned,
            //                         g.Key.MarketType,
            //                         VinsPositioned = g.Count()
            //                     }).ToList();

            //var LoadPLanVinsLoaded = (from ATraficcPlan in Context.Set<TmsTcAPI.DAL.Models.TrafficPlan>()
            //                          where ATraficcPlan.StartDate == beforeDate
            //                          group ATraficcPlan by new
            //                          {
            //                              ATraficcPlan.Origin,
            //                              ATraficcPlan.MarketType
            //                          } into g
            //                          select new
            //                          {
            //                              Office = g.Key.Origin,
            //                              g.Key.MarketType,
            //                              VinsLoaded = g.Count()
            //                          }).ToList();

            var loadPlan = (from ALoadPlan in Context.LoadPlan
                            where ALoadPlan.Date == beforeDate
                            select ALoadPlan);

            foreach (var item in loadPlan)
            {
                var forecast = LoadPlanVinsPlanned.Where(x => x.Office == item.Office && item.MarketType == x.MarketType).FirstOrDefault();
                item.VinsPlanned += forecast.VinsPlanned;
            }
            Context.SaveChanges();
            LogSps logSps = new LogSps()
            {
                FechaHora = DateTime.Now,
                Sp = @"/load-plans/PreviousDay"
            };
            Context.LogSps.Add(logSps);
            Context.SaveChanges();
        }
        public void UpdateLoadPlanTodayAndLater()
        {
            var queryVwPlanCarga = from AvwPlanCarga in Context.VwPlanCarga
                                   where AvwPlanCarga.Fecha >= DateTime.Now
                                   select AvwPlanCarga;

            foreach (var item in queryVwPlanCarga)
            {
                TmsTcAPI.DAL.Models.LoadPlan loadPlan = new TmsTcAPI.DAL.Models.LoadPlan();
                loadPlan.MarketType = item.Mercado;
                //loadPlan.Customer falta customer en la vista materializada
                loadPlan.Office = item.Oficina;
                loadPlan.Date = item.Fecha;
                loadPlan.VinsPlanned = item.Demanda;
                loadPlan.VinsPositioned = item.Posicionado;
                loadPlan.VinsLoaded = item.Arribo;
            }

            LogSps logSps = new LogSps()
            {
                FechaHora = DateTime.Now,
                Sp = @"/load-plans/TodayAndLater"
            };
            Context.LogSps.Add(logSps);
            Context.SaveChanges();
        }
    }
}
