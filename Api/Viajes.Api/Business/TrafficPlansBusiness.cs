using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System.Linq;
using CrmTc.DAL.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using FileProcessing;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using Truck = TmsTcAPI.DAL.Models.Truck;
using InnovaLinks.DAL.Models;
using Viajes.Api.Business;
using Microsoft.Data.SqlClient;

namespace IO.Swagger.Business
{
    public class TrafficPlansBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
       
        public TrafficPlansBusiness(TmsTcEntities context, InnovaLinksEntities innovaLinksContext, CrmTcEntities crmContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            User = user;
        }

        public ObjectResult AddTrafficPlans(Models.TrafficPlan body)
        {
            var trip = new TmsTcAPI.DAL.Models.Trips()
            {
                MarketType = body.MarketType.Id.Value,
                Customer = body.Customer.Id.Value,
                Origin = body.Origin.Id.Value,
                Destination = body.Destination.Id.Value,
                CreatedAt = body.StartDate.Value,
                Truck = body.Truck.Id.Value,
                Reason = body.Reason,

                Active = true,
                CreatedBy = CurrentUser.Id,
                UpdatedBy = CurrentUser.Id
            };

            DeterminaOperador(trip, body);
            DeterminaRegreso(trip, body);
            Context.Trips.Add(trip);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Agregado Correctamente", Detail = "El plan de tráfico fue agregado correctamente" });
        }

        private void DeterminaOperador(TmsTcAPI.DAL.Models.Trips trips, Models.TrafficPlan body)
        {
            /*
            if (body.TruckOperator == null)
            {
                trafficPlan.TruckOperator = Context.TruckOperatorTruck.Where(tot => tot.Truck == body.Truck.Id.Value).OrderBy(tot => tot.TruckOperatorPriority).Select(tot => tot.TruckOperator).FirstOrDefault();
            }
            else
            {
                trafficPlan.TruckOperator = body.TruckOperator.Id.Value;
            }
            */
        }

        private void DeterminaRegreso(TmsTcAPI.DAL.Models.Trips trips, Models.TrafficPlan body)
        {
            var calcularRegreso = new Viajes.Api.Business.CalculateReturnBusiness(Context, CrmContext, User);

            if (body.ReturnTo == null)
            {
                var tractor = Context.Truck.Where(t => t.Id == body.Truck.Id).FirstOrDefault();
                var regresoOptimo = calcularRegreso.ObtenerRegreso(body.Origin, body.Destination, tractor, false);
                if (regresoOptimo != null)
                {
                    trips.ReturnTo = regresoOptimo.ReturnTo;
                    if (body.EndDate != null)
                    {
                        // trafficPlan.EndDate = regresoOptimo.Arrival;
                    }
                }
            }

            if (body.EndDate == null)
            {
                var targetToDestination = Cost(trips.Origin, trips.Destination);
                var destinationToReturn = Cost(trips.ReturnTo, trips.Destination);
                // trafficPlan.EndDate = trafficPlan.CreatedAt.AddMinutes(targetToDestination).AddMinutes(destinationToReturn).Date;
            }
        }

        private float Cost(int origin, int destination)
        {
            var costo = CrmContext.DistanciasRegresos.Where(dr => dr.Oficinasid == origin && dr.Destinosid == destination).Select(dr => dr.Tiempo).FirstOrDefault();
            if (costo == null)
                return 0;
            else
                return costo.Value;
        }

        public ObjectResult DeleteTrafficPlans(int? id)
        {
            var trip = Context.Trips.Where(tp => tp.Id == id).FirstOrDefault();
            if (trip == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El plan de tráfico especificado no existe" });

            Context.Trips.Remove(trip);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Eliminado Correctamente", Detail = "El plan de tráfico fue eliminado correctamente" });
        }

        public static NamedEntity GetTruckOperator(TmsTcAPI.DAL.Models.Operator truckOperator)
        {
            string Name = truckOperator.Employee == null?String.Empty: truckOperator.Employee.GivenName + " " + truckOperator.Employee.PaternalSurname + " " + truckOperator.Employee.MaternalSurname;
            string Description = truckOperator.Employee == null?String.Empty: truckOperator.Employee.GivenName + " " + truckOperator.Employee.PaternalSurname + " " + truckOperator.Employee.MaternalSurname;
           
            return new NamedEntity()
            {
                Id = truckOperator.Id,
                Name = Name,
                Description = Description,
                Active = truckOperator.Active,
                CreatedBy = truckOperator.CreatedBy,
                CreatedAt = truckOperator.CreatedAt,
                UpdatedBy = truckOperator.UpdatedBy,
                UpdatedAt = truckOperator.UpdatedAt
            };
        }

        public ObjectResult GetTrafficPlans()
        { 
            // Obtiene la lista de operadores existentes
            var operatorsDictionary = (from tpo in Context.RTripsOperator
                                       join o in Context.Operator on tpo.Operatorid equals o.Id
                                       join e in Context.Employee on o.Employeeid equals e.Id
                                       select new NamedEntity
                                       {
                                           Id = o.Id,
                                           Name = e.GivenName + " " + e.PaternalSurname + " " + e.MaternalSurname,
                                           Description = e.GivenName + " " + e.PaternalSurname + " " + e.MaternalSurname,
                                           Active = true,
                                           CreatedBy = e.CreatedBy,
                                           CreatedAt = e.CreatedAt,
                                           UpdatedBy = e.UpdatedBy,
                                           UpdatedAt = e.UpdatedAt
                                       }).Distinct().ToList();

            var trips = (
            from tp in Context.Trips
                // from tp in tripsQuery
            join tpo in Context.RTripsOperator on tp.Id equals tpo.Tripsid
            join tpd in Context.TruckPlanDetails on tp.Truck equals tpd.Truckid into trucks
            from tr in trucks.DefaultIfEmpty()
            select new Models.TrafficPlan
            {
                Id = tp.Id,

                MarketType = GetMarketType(tp.MarketTypeNavigation),
                Customer = GetCustomer(CrmContext, tp.Customer),
                Origin = GetOrigenOficinaOperativa(CrmContext, tp.Origin),//GetOrigin(CrmContext, tp.Origin),
                Destination = GetDestination(CrmContext, tp.Destination),
                ReturnTo = GetReturnToOficinaOperativa(CrmContext, tp.ReturnTo), //GetReturnTo(CrmContext, tp.ReturnTo),
                StartDate = tp.CreatedAt,
                EndDate = tr.ArrivalTime,
                Truck = GetTruck(tp.TruckNavigation),
                TruckOperator = GetTruckOperator(tpo.Operator),
                Reason = tp.Reason,
                Active = tp.Active,
                SetManually = tp.SetManually,
                CreatedBy = tp.CreatedBy,
                CreatedAt = tp.CreatedAt,
                UpdatedBy = tp.CreatedBy,
                UpdatedAt = tp.CreatedAt
            }).ToList();
            return new OkObjectResult(trips);
        }

        public ObjectResult UpdateTrafficPlans(Models.TrafficPlan body, int? id)
        {

            /* TODO:
               1.Si actualiza el comentario. update al comentario.
               2.Si actualiza la fecha de regreso: Modificar truck_plan_details: arrival_time
               3.Si actualiza el regreso (la oficina)
                   3.1 Actualizar traffic_plan: return_to
                   3.2 Actualizra truck_plan_details: office_assigned, arrival_time, market_type
                       a. office_assigned: el id de la nueva oficina operativa.
                       b. arrival_time: debe hacer el recálculo para saber cuando regresa a la nueva oficina seleccionada.
                       c. market_type: debería ser preguntado al usuario.*/

            try
            {
                var trip = Context.Trips.Where(tp => tp.Id == id).FirstOrDefault();
                if (trip == null)
                    return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El plan de tráfico especificado no existe" });

                trip.CreatedAt = body.StartDate.Value;
                trip.Reason = body.Reason;
                var returnTo = (int)(from op in CrmContext.OficinasOperativas
                                      join o in CrmContext.Oficinas on op.Oficinasid equals o.Id
                                      where op.Id == body.ReturnTo.Id
                                      select op.Id).SingleOrDefault();

                if (returnTo > 0 && returnTo != trip.ReturnTo)
                {
                    trip.ReturnTo = returnTo;
                    trip.SetManually = true;
                }


                trip.UpdatedBy = CurrentUser.Id;
                trip.UpdatedAt = DateTime.UtcNow.AddHours(-6);

                DeterminaOperador(trip, body);
                DeterminaRegreso(trip, body);

                Context.SaveChanges();

                if (body.EndDate != null)
                    SetReturnTo(body, trip.ReturnTo);

                return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El plan de tráfico fue actualizado correctamente" });
            }
            catch (Exception ex)
            {
                string mensajeCorto = String.Empty;
                if (ex.Message.Contains("Nullable"))
                {
                    mensajeCorto = "No se permite editar: Este viaje no cuenta con un regreso";
                }
                return new OkObjectResult(new ProblemDetails() { Status = 400, Title = mensajeCorto, Detail = ex.Message });
            }
        }

        private void SetReturnTo(Models.TrafficPlan body, int office)
        {
            // Busca en truck_plan_details y si cuenta con un registro, lo elimina
            var truckDetailsUpdate = Context.TruckPlanDetails.Where(tr => tr.Truckid == body.Truck.Id.Value).FirstOrDefault();


            //Si se cambio la fecha de regreso se activa la bandera en traffic plan
            if (truckDetailsUpdate?.ArrivalTime != body.EndDate)
            {
                //El tipo de macado que esta haciendo en ese momento, lo de hoy al pasado.
                var trafficPlan = Context.Trips.Where(tp => tp.Id == body.Id).FirstOrDefault();
                trafficPlan.SetManually = true;
            }

            if (truckDetailsUpdate != null)
                Context.TruckPlanDetails.Remove(truckDetailsUpdate);


            // Agrega un nuevo registro a truck_plan_details
            truckDetailsUpdate = new TruckPlanDetails
            {
                Truckid = (int)body.Truck.Id.Value,
                MarketType = 1,//Todo este valor debe venir de frontend
                ArrivalTime = body.EndDate.Value,
                OfficeAssigned = office
            };
            Context.TruckPlanDetails.Add(truckDetailsUpdate);
            Context.SaveChanges();
        }

        public ObjectResult UploadTrafficPlans(IFormFile file)
        {
            var dataSet = new IFormFileReader(file).GetDataSet();

            var customers = CrmContext.Clientes.Where(c => c.Active == true).Select(c => GetCustomer(c)).ToList();
            var locations = LocationsBusiness.GetIQLocation(CrmContext.Origenes.Where(o => o.Active == true)).ToList();
            var marketTypes = Context.MarketType.Where(mt => mt.Active == true).Select(mt => GetMarketType(mt)).ToList();
            var trucks = Context.Truck.Where(c => c.Active == true).Select(t => GetTruck(t)).ToList();

            List<Models.TrafficPlan> trafficPlans = new List<Models.TrafficPlan>();
            var headerRows = 2;

            foreach (DataTable sheet in dataSet.Tables)
            {
                foreach (DataRow row in sheet.Rows)
                {
                    var marketType = marketTypes.FirstOrDefault(x => x.Name == (string)row["mercado"]);
                    if (marketType == null)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Tipo de Mercado Inválido", Detail = row["mercado"] + " no es un tipo de mercado válido en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    var customer = customers.FirstOrDefault(x => x.Name == (string)row["cliente"]);
                    if (customer == null)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Cliente Inválido", Detail = row["cliente"] + " no es un cliente válido en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    var origin = locations.FirstOrDefault(x => x.Name == (string)row["oficina Origen"]);
                    if (origin == null)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Oficina Origen Inválida", Detail = row["oficina Origen"] + " no es una Oficina Origen válida en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    var destination = locations.FirstOrDefault(x => x.Name == (string)row["oficina Destino"]);
                    if (destination == null)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Oficina Destino Inválida", Detail = row["oficina Destino"] + " no es una Oficina Destino válida en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    DateTime? startDate = null;
                    if (row["fecha De Inicio"] != DBNull.Value)
                        startDate = (DateTime)row["fecha De Inicio"];

                    var truck = trucks.FirstOrDefault(x => x.Name == (string)row["tractor"]);
                    if (truck == null)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Tractor Inválido", Detail = row["tractor"] + " no es un tráctor válido en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    var returnTo = locations.FirstOrDefault(x => x.Name == (string)row["oficina Regreso"]);
                    if (returnTo == null)
                        return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Oficina Regreso Inválida", Detail = row["oficina Regreso"] + " no es una Oficina Regreso válida en " + sheet.TableName + ":" + (sheet.Rows.IndexOf(row) + headerRows) });

                    string reason = null;
                    if (row["comentarios"] != DBNull.Value)
                        reason = row["comentarios"].ToString();

                    var trafficPlan = new Models.TrafficPlan()
                    {
                        MarketType = marketType,
                        Customer = customer,
                        Origin = origin,
                        Destination = destination,
                        StartDate = startDate,
                        Truck = truck,
                        ReturnTo = returnTo,
                        Reason = reason,
                        Active = true
                    };
                    trafficPlans.Add(trafficPlan);
                }
            }

            return new OkObjectResult(trafficPlans);
        }

        private static NamedEntity GetTruck(TmsTcAPI.DAL.Models.Truck truck)
        {
            return new NamedEntity()
            {
                Id = truck.Id,
                Name = truck.Name,
                Description = truck.Description,
                Active = truck.Active,
                CreatedBy = truck.CreatedBy,
                CreatedAt = truck.CreatedAt,
                UpdatedBy = truck.CreatedBy,
                UpdatedAt = truck.CreatedAt,
            };
        }

        private static Location GetOrigin(CrmTcEntities crmContext, int id)
        {
            //var locationsQuery = (from op in crmContext.OficinasOperativas
            //                      join o in crmContext.Oficinas.Where(o => o.IdOficinaZam == id) on op.Oficinasid equals o.Id
            //                      select new Location
            //                      {
            //                          Id = o.Id,
            //                          Name = o.Nombre,
            //                          Description = o.Descripcion,
            //                          City = o.Id,
            //                          Active = true,
            //                          Coordinates = new Coordinates()
            //                          {
            //                              Latitude = double.Parse(op.Latitud),
            //                              Longitude = double.Parse(op.Longitud)
            //                          },
            //                          CreatedAt = o.CreatedAt,
            //                          UpdatedAt = o.UpdatedAt,
            //                          CreatedBy = o.CreatedBy,
            //                          UpdatedBy = o.UpdatedBy
            //                      }).FirstOrDefault();

            var locationsQuery = (from ofi in crmContext.Oficinas
                                  join ori in crmContext.Origenes
                                  on ofi.IdOficinaZam equals ori.Ciudadesid
                                  where
                                  ofi.Nombre == ori.Nombre
                                  && ofi.Active == true
                                  select new Location
                                  {
                                      Id = ofi.Id,
                                      Name = ofi.Nombre,
                                      Description = ofi.Descripcion,
                                      City = ofi.IdOficinaZam,
                                      Active = true,
                                      Coordinates = new Coordinates()
                                      {
                                          Latitude = double.Parse(ori.Latitud),
                                          Longitude = double.Parse(ori.Longitud)
                                      },
                                      CreatedAt = ofi.CreatedAt,
                                      UpdatedAt = ofi.UpdatedAt,
                                      CreatedBy = ofi.CreatedBy,
                                      UpdatedBy = ofi.UpdatedBy
                                  }).FirstOrDefault();


            if (locationsQuery == null)
                return new Location();
            else
                return locationsQuery;
        }


        private static Location GetOrigenOficinaOperativa(CrmTcEntities crmContext, int id)
        {

            var locationsQuery = (from ofio in crmContext.OficinasOperativas
                                  join ofi in crmContext.Oficinas
                                   on ofio.Oficinasid equals ofi.Id
                                  where ofio.Id == id
                                  select new Location
                                  {
                                      Id = ofio.Id,
                                      Name = ofi.Nombre,
                                      Description = ofi.Descripcion,
                                      City = ofi.IdOficinaZam,
                                      Active = true,
                                      Coordinates = new Coordinates()
                                      {
                                          Latitude = double.Parse(ofio.Latitud),
                                          Longitude = double.Parse(ofio.Longitud)
                                      },
                                      CreatedAt = ofi.CreatedAt,
                                      UpdatedAt = ofi.UpdatedAt,
                                      CreatedBy = ofi.CreatedBy,
                                      UpdatedBy = ofi.UpdatedBy
                                  }).FirstOrDefault();

            if (locationsQuery == null)
                return new Location();
            else
                return locationsQuery;

        }



        private static Location GetDestination(CrmTcEntities crmContext, int id)
        {
            var locationsQuery = (from o in crmContext.Destinos.Where(o => o.Ciudadesid == id)
                                  join c in crmContext.Ciudades on o.Ciudadesid equals c.Id
                                  select new Location
                                  {
                                      Id = o.Id,
                                      Name = c.Nombre,
                                      Description = c.Descripcion,
                                      City = c.Id,
                                      Active = true,
                                      Coordinates = new Coordinates()
                                      {
                                          Latitude = double.Parse(o.Latitud),
                                          Longitude = double.Parse(o.Longitud)
                                      },
                                      CreatedAt = c.CreatedAt,
                                      UpdatedAt = c.UpdatedAt,
                                      CreatedBy = c.CreatedBy,
                                      UpdatedBy = c.UpdatedBy
                                  }).FirstOrDefault();
            if (locationsQuery == null)
                return new Location();
            else
                return locationsQuery;
        }

        private static Location GetReturnTo(CrmTcEntities crmContext, int id)
        {
            var locationsQuery = (from op in crmContext.OficinasOperativas
                                  join o in crmContext.Oficinas.Where(o => o.IdOficinaZam == id) on op.Oficinasid equals o.Id
                                  select new Location
                                  {
                                      Id = op.Id,
                                      Name = o.Nombre,
                                      Description = o.Descripcion,
                                      City = o.IdOficinaZam,
                                      Active = true,
                                      Coordinates = new Coordinates()
                                      {
                                          Latitude = double.Parse(op.Latitud),
                                          Longitude = double.Parse(op.Longitud)
                                      },
                                      CreatedAt = o.CreatedAt,
                                      UpdatedAt = o.UpdatedAt,
                                      CreatedBy = o.CreatedBy,
                                      UpdatedBy = o.UpdatedBy
                                  }).FirstOrDefault();
            if (locationsQuery == null)
                return new Location();
            else
                return locationsQuery;

        }


        private static Location GetReturnToOficinaOperativa(CrmTcEntities crmContext, int id)
        {
            var locationsQuery = (from ofio in crmContext.OficinasOperativas
                                  join ofi in crmContext.Oficinas
                                   on ofio.Oficinasid equals ofi.Id
                                  where ofio.Id == id
                                  select new Location
                                  {
                                      Id = ofio.Id,
                                      Name = ofi.Nombre,
                                      Description = ofi.Descripcion,
                                      City = ofi.IdOficinaZam,
                                      Active = true,
                                      Coordinates = new Coordinates()
                                      {
                                          Latitude = double.Parse(ofio.Latitud),
                                          Longitude = double.Parse(ofio.Longitud)
                                      },
                                      CreatedAt = ofi.CreatedAt,
                                      UpdatedAt = ofi.UpdatedAt,
                                      CreatedBy = ofi.CreatedBy,
                                      UpdatedBy = ofi.UpdatedBy
                                  }).FirstOrDefault();


            if (locationsQuery == null)
                return new Location()
                {
                    Id = -1,
                    Name = "-1",
                    Description = "-1",
                    City = -1,
                    Active = false,
                    Coordinates = new Coordinates()
                    {
                        Latitude = -1,
                        Longitude = -1
                    },
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = -1,
                    UpdatedBy = -1
                };
            else
                return locationsQuery;

        }

        private static NamedEntity GetCustomer(CrmTcEntities crmContext, int id)
        {
            var customersQuery = crmContext.Clientes.Where(o => o.Id == id);

            var customer = customersQuery.Select(c => GetCustomer(c)).FirstOrDefault();

            return customer;
        }

        private static NamedEntity GetCustomer(CrmTc.DAL.Models.Clientes cliente)
        {
            return new NamedEntity()
            {
                Id = cliente.Id,
                Name = cliente.NombreComercial,
                Description = cliente.NombreComercial,
                Active = cliente.Active,
                CreatedBy = cliente.CreatedBy,
                CreatedAt = cliente.CreatedAt,
                UpdatedBy = cliente.CreatedBy,
                UpdatedAt = cliente.CreatedAt
            };
        }

        private static NamedEntity GetMarketType(MarketType market_type)
        {
            return new NamedEntity()
            {
                Id = market_type.Id,
                Name = market_type.Name,
                Description = market_type.Description,
                Active = market_type.Active,
                CreatedBy = market_type.CreatedBy,
                CreatedAt = market_type.CreatedAt,
                UpdatedBy = market_type.CreatedBy,
                UpdatedAt = market_type.CreatedAt,
            };
        }
        public void UpdateStatusOperationTraffic()
        {
            var spResult = new List<Truck>();
            string storeProcedureName = "sp_zamTravelSync";

            var conn = (SqlConnection)Context.Database.GetDbConnection();
            using (SqlConnection sqlConn = new SqlConnection(conn.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand(storeProcedureName, sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = sqlCmd.ExecuteReader();

                while (dataReader.HasRows && dataReader.Read())
                {
                    spResult.Add(new Truck { Name = dataReader["truckId"].ToString() });
                }
            }

            CalculateReturnBusiness calcularRegreso = new CalculateReturnBusiness(Context, CrmContext, User);

            var tmsTrucks = (from truck in Context.Truck.ToList()
                             join tr in spResult on truck.Name equals tr.Name
                             join nc in InnovaLinksContext.NivelesCombustibleActuales.ToList() on truck.TrackingId equals nc.UnitId
                             select new Models.Truck
                             {
                                 Id = truck.Id,
                                 Name = truck.Name,
                                 Type = truck.TruckType,
                                 Position = new Position { Coordinates = new Coordinates { Latitude = nc.Latitude, Longitude = nc.Longitude } }
                             }).ToList();

            var trips = Context.Trips;
            foreach (var truck in tmsTrucks)
            {
                var trip = trips.Where(tp => tp.Truck == truck.Id).FirstOrDefault();

                if (trip != null)
                {
                    var returnToInfo = calcularRegreso.ObtenerRegreso(new Location { Coordinates = truck.Position.Coordinates }, new Location { Id = trip.Destination }, new Truck { Name = truck.Name, TruckType = truck.Type }, false);
                    trip.ReturnTo = returnToInfo.ReturnTo;

                    // Busca en truck_plan_details y si cuenta con un registro, lo elimina
                    var truckDetailsUpdate = Context.TruckPlanDetails.Where(tr => tr.Truckid == truck.Id).FirstOrDefault();
                    if (truckDetailsUpdate != null)
                        Context.TruckPlanDetails.Remove(truckDetailsUpdate);

                    // Agrega un nuevo registro a truck_plan_details
                    truckDetailsUpdate = new TruckPlanDetails
                    {
                        Truckid = (int)truck.Id,
                        MarketType = returnToInfo.MarketType,
                        ArrivalTime = returnToInfo.Arrival,
                        OfficeAssigned = returnToInfo.ReturnTo
                    };
                    Context.TruckPlanDetails.Add(truckDetailsUpdate);
                }
                Context.SaveChanges();
            }
        }
    }
}
