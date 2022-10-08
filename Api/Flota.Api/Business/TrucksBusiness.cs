using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System.Linq;
using InnovaLinks.DAL.Models;
using Microsoft.Extensions.Localization;
using Flota.Api.Localize;
using System.Collections.Generic;
using CrmTc.DAL.Models;
using System.Globalization;
using System;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace IO.Swagger.Business
{
    public class TrucksBusiness: BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        private readonly IStringLocalizer<Resource> localizer;
        public TrucksBusiness(TmsTcEntities context, CrmTcEntities crmContext, InnovaLinksEntities innovaLinksContext, ClaimsPrincipal user, IStringLocalizer<Resource> localizer) : base(context, user)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            this.localizer = localizer;
        }

        public ObjectResult GetTrucks()
        {
            var trucks = Context.Truck.Where(t => t.Active == true).Select(t => new Models.Truck
            {
                Id = t.Id,
                TrackingId = t.TrackingId,
                Name = t.Name,
                Description = t.Description,
                Type = t.TruckType,
                Status = t.TruckStatus,
                Active = t.Active,
                CreatedBy = t.CreatedBy,
                CreatedAt = t.CreatedAt,
                UpdatedBy = t.UpdatedBy,
                UpdatedAt = t.UpdatedAt
            }).ToList();
            return new OkObjectResult(trucks);
        }

        public ObjectResult GetTrucksTrackingInfo()
        {
            var offices = GetOffices().ToList();
            var trucks = InnovaLinksContext.NivelesCombustibleActuales.Select(t => new TrackingInfo
            {
                Id = t.UnitId,
                Position = new Position() { Name = t.Address, Coordinates = new Coordinates() { Latitude = t.Latitude, Longitude = t.Longitude }, UpdatedAt = t.DateLocation }
            }).ToList();

            foreach(var trackingInfo in trucks)
            {
                var currentOffice = GetCurrentOffice(trackingInfo, offices);

                if (currentOffice == null)
                {
                    if(trackingInfo.Position.Name == null || trackingInfo.Position.Name == "")
                        trackingInfo.Position.Name = "En tránsito";
                    else
                        trackingInfo.Position.Name = "Dirigiendose a "+trackingInfo.Position.Name;
                }
                else
                {
                    trackingInfo.Position.Name = currentOffice.Name;
                }
            }
            return new OkObjectResult(trucks);
        }

        public ObjectResult GetSatelliteView()
        {
            var satelliteView = new SatelliteView() { Offices = GetOffices().ToList(), Trucks = new List<TrackingInfo>() };
            var trucks = Context.Truck.Where(t => t.Active == true).ToList();
            var niveles = InnovaLinksContext.NivelesCombustibleActuales.ToList();

            var nivelesCombustibleActuales = (from nca in niveles
                     join t in trucks on nca.UnitId equals t.TrackingId
                     select nca).ToList();

            foreach (var tractor in nivelesCombustibleActuales)
            {
                var trackingInfo = new TrackingInfo()
                {
                    Id = tractor.UnitId,
                    Position = new Position()
                    {
                        Name = tractor.Address,
                        UpdatedAt = tractor.DateLocation,
                        Coordinates = new Coordinates() { Latitude = tractor.Latitude, Longitude = tractor.Longitude }
                    }
                };

                var currentOffice = GetCurrentOffice(trackingInfo, satelliteView.Offices);

                if(currentOffice == null)
                    satelliteView.Trucks.Add(trackingInfo);
                else
                    currentOffice.Trucks.Add(trackingInfo);
            }

            return new OkObjectResult(satelliteView);
        }

        private Office GetCurrentOffice(TrackingInfo trackingInfo, List<Office> offices)
        {
            foreach (var office in offices)
            {
                if (office.Coordinates.DistanceTo(trackingInfo.Position.Coordinates, UnitOfLength.Kilometers) < 3)
                {
                    return office;
                }
            }
            return null;
        }

        public IQueryable<Office> GetOffices()
        {
            var oficinas_id = CrmContext.DistanciasRegresos.Select(dr => dr.Oficinasid).Distinct();
            var oficinas = CrmContext.Origenes.Where(o => oficinas_id.Contains(o.Id)).Select(o => new Office() { 
                Name = o.Nombre,
                Coordinates = new Coordinates() { Latitude = double.Parse(o.Latitud, CultureInfo.InvariantCulture), Longitude = double.Parse(o.Longitud, CultureInfo.InvariantCulture) },
                Trucks = new List<TrackingInfo>()
            });
            return oficinas;
        }

        public ObjectResult GetTruckTypes()
        {
            var truckTypes = Context.TruckType.Where(tt => tt.Active == true).Select(tt => new Models.TruckType
            {
                Id = tt.Id,
                Name = tt.Name,
                Description = tt.Description,
                Active = tt.Active,
                CreatedBy = tt.CreatedBy,
                CreatedAt = tt.CreatedAt,
                UpdatedBy = tt.UpdatedBy,
                UpdatedAt = tt.UpdatedAt
            }).ToList();
            return new OkObjectResult(truckTypes);
        }

        public ObjectResult GetTruckStatus()
        {
            var truckStatus = Context.TruckStatus.Where(ts => ts.Active == true).Select(ts => new Models.TruckStatus
            {
                Id = ts.Id,
                Name = ts.Name,
                Description = ts.Description,
                Active = ts.Active,
                CreatedBy = ts.CreatedBy,
                CreatedAt = ts.CreatedAt,
                UpdatedBy = ts.UpdatedBy,
                UpdatedAt = ts.UpdatedAt
            }).ToList();
            return new OkObjectResult(truckStatus);
        }

        public ObjectResult UpdateTruckStatus(int? id, int? status)
        {
            var truck = Context.Truck.Where(p => p.Id == id.Value).FirstOrDefault();
            if (truck == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = localizer[Messages.NotFound].Value, Detail = localizer[Messages.TruckNotFound] });

            truck.TruckStatus = status.Value;
            truck.UpdatedBy = CurrentUser.Id;
            
            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = localizer[Messages.UpdatedSuccessfully], Detail = localizer[Messages.TruckUpdatedSuccessfully] });
        }

        public ObjectResult GetTrucksAvailability(int? id)
        {
            var truck = Context.Truck.Where(to => to.Id == id.Value).FirstOrDefault();

            if (truck == null)
            {
                var not_found = new ProblemDetails
                {
                    Title = "Tractor no encontrado",
                    Detail = "El tractor especificado no existe"
                };
                return new NotFoundObjectResult(not_found);
            }

            var availabilityQuery = Context.CalendarTruck.Where(ta => ta.Truckid == truck.Id);
            var availability = availabilityQuery.OrderBy(ta => ta.Date).Select(ta => new Availability
            {
                Date = ta.Date,
                Available = ta.Available,
                AvailabilityReason = ta.CTruckUnavailableReasonTypeid
            }).ToList();

            if (availability.Count == 0)
            {
                availability.Add(new Availability
                {
                    Date = truck.CreatedAt.Date,
                    Available = truck.Active,
                    AvailabilityReason = null,
                    Location = null
                });
            }

            return new OkObjectResult(availability);

        }

        public ObjectResult GetTrucksAvailabilityReasons()
        {
            var availabilityReasons = Context.CTruckUnavailableReasonType.Where(ar => ar.Active == true)
                .Select(ar => new Models.AvailabilityReason
                {
                    Id = ar.Id,
                    Name = ar.Name,
                    Description = ar.Description,
                    Active = ar.Active,
                    CreatedBy = ar.CreatedBy,
                    CreatedAt = ar.CreatedAt.UtcDateTime,
                    UpdatedBy = ar.UpdatedBy,
                    UpdatedAt = ar.UpdatedAt.UtcDateTime
                }).ToList();
            return new OkObjectResult(availabilityReasons);
        }

        public ObjectResult UpdateTrucksAvailability(Availability body, int? id)
        {
            var truck = Context.Truck.Where(tr => tr.Id == id.Value).FirstOrDefault();

            if (truck == null)
            {
                var not_found = new ProblemDetails
                {
                    Title = "Tractor no encontrado",
                    Detail = "El tractor especificado no existe"
                };
                return new NotFoundObjectResult(not_found);
            }

            var availability = Context.CalendarTruck.Where(ta => ta.Truckid == truck.Id && ta.Date == body.Date.Value).FirstOrDefault();
            if (availability == null)
            {
                availability = new CalendarTruck
                {
                    Truckid = truck.Id,
                    Date = body.Date.Value,
                    Available = body.Available.Value,
                    CTruckUnavailableReasonTypeid = (int)body.AvailabilityReason,
                    CreatedBy = CurrentUser.Id
                };
                Context.CalendarTruck.Add(availability);
            }
            else
            {
                availability.Available = body.Available.Value;
                availability.CTruckUnavailableReasonTypeid = (int)body.AvailabilityReason;
            }
            Context.SaveChanges();

            var success = new ProblemDetails
            {
                Title = "Disponibiliad actualizada",
                Detail = "La disponibilidad del tractor especificado se ha actualizado exitosamente"
            };
            return new OkObjectResult(success);
        }

        public ObjectResult GetTruckByIdOperator(int? idOperator)
        {
            var operatorProfile = (from o in this.Context.Operator
                                 join t in Context.Truck on o.Truckid equals t.Id
                                 join tt in Context.TruckType on t.TruckType equals tt.Id
                                 where o.Id == idOperator
                                 select new OperatorProfile()
                                 {
                                     IdOperator = o.Id,
                                     Truck = new Models.OperatorTruck()
                                     {
                                         Id = o.Truckid,
                                         Description = t.Name,
                                         Model = t.Description,
                                         TruckType = new OperatorTruckType()
                                         {
                                             Id = t.TruckType,
                                             Description = tt.Description
                                         },
                                     }
                                 }).FirstOrDefault();

            var towings = this.Context.Towing.Where(x => x.Truckid == operatorProfile.Truck.Id).ToList();
            operatorProfile.Truck.Towings = new List<Models.Towing>();
            foreach (var towing in towings)
            {
                operatorProfile.Truck.Towings.Add(new Models.Towing { Id = towing.Id, Description = towing.Description, Name = towing.Name });
            }

            return new ObjectResult(operatorProfile);
        }

        public void SincronizarTractores()
        {
            string procedimiento = "SP_Sincronizar_Tractores";
            var con = (SqlConnection)Context.Database.GetDbConnection();

            using (SqlConnection cn = new SqlConnection(con.ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(procedimiento, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
            }
        }

        public void SetTrucksStatusByDay()
        {
            string procedimiento = "SP_ObtenerEstatusTractores";
            var con = (SqlConnection)Context.Database.GetDbConnection();

            using (SqlConnection cn = new SqlConnection(con.ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(procedimiento, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
            }
        }
    }
}
