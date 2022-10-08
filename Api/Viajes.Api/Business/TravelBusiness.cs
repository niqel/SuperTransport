using AuthenticationHandler.Business;
using CrmTc.DAL.Models;
using InnovaLinks.DAL.Models;
using IO.Swagger.Models;
using ListdbTc.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using Viajes.Api.Models;

namespace Viajes.Api.Business
{
    public class TravelBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        protected TmsTcEntities TmsContext { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
        public TravelBusiness(TmsTcEntities context, CrmTcEntities crmContext, InnovaLinksEntities innovaLinksContext, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            ListdbTcContext = listdbTcContext;
            TmsContext = context;
        }

        public ObjectResult GetTravelsCompleted(int? idOperator)
        {
            return new ObjectResult(null);
        }

        public ObjectResult GetTravelsCurrent(int? idOperator)
        {
            //var viaje = (from t in Context.Trips
            //             join rto in Context.RTripsOperator on t.Id equals rto.Tripsid
            //             join o in Context.Operator on rto.Operatorid equals o.Id
            //             join ts in Context.TripsStatus on t.TripsStatusid equals ts.Id
            //             join orig in Context.Origenes on t.Origin equals orig.Ciudadesid
            //             join c in Context.Ciudades on orig.Ciudadesid equals c.Id
            //             join d in Context.Destinos on t.Destination equals d.Id
            //             join c2 in Context.Ciudades on d.Ciudadesid equals c2.Id
            //             where o.Id == idOperator.Value && t.Active == true
            //             select new CurrentTrip() 
            //             {
            //                 Destination = t.Destination,
            //                 FechaInicio = t.CreatedAt,
            //                 Id = t.Id,
            //                 Origin = t.Origin,
            //                 NombreOrigen = c.Nombre,
            //                 NombreDestino = c2.Nombre
            //             }).FirstOrDefault();
            //return new ObjectResult(viaje);

            var trip = (
                   from t in Context.Trips
                   join rto in Context.RTripsOperator on t.Id equals rto.Tripsid
                   join ts in Context.TripsStatus on t.TripsStatusid equals ts.Id
                   where rto.Operatorid == idOperator.Value
                   orderby t.CreatedAt descending
                   select new
                   {
                       Id = t.Id,
                       Estatus = ts.Name,
                       idOrigen = t.Origin,
                       idDestino = t.Destination,
                       FechaInicio = t.CreatedAt,
                       RendimientoEsperadoDiesel = t.ExpectedPerformance,
                       RendimientoRealDiesel = t.RealPerformance,
                       Eta = 0.0F
                   }).FirstOrDefault();


            if (trip != null)
            {

                var origen_descripcion = (from org in CrmContext.Origenes
                                          join cio in CrmContext.Ciudades on org.Ciudadesid equals cio.Id
                                          where org.Id == trip.idOrigen
                                          select cio.Descripcion).FirstOrDefault()?.ToString();


                var destino_descripcion = (from des in CrmContext.Destinos
                                           join cid in CrmContext.Ciudades on des.Ciudadesid equals cid.Id
                                           where des.Id == trip.idDestino
                                           select des.Descripcion).FirstOrDefault()?.ToString();

                var ultimoViaje = new TravelCurrentData()
                {
                    IdTrip = trip.Id,
                    Estatus = trip.Estatus,
                    Origen = origen_descripcion,
                    Destino = destino_descripcion,
                    FechaInicio = trip.FechaInicio,
                    RendimientoEsperadoDiesel = trip.RendimientoEsperadoDiesel,
                    RendimientoRealDiesel = trip.RendimientoRealDiesel,
                    Eta = 0.0F
                };

                var response = new TravelCurrent() { Code = 200 ,Message = "Success", Data = ultimoViaje };
                return new ObjectResult(response);
            }
            else
            {

                var response = new TravelCurrent() { Code = 200, Message = "No existe un viaje actual para el operador", Data = null };
                return new ObjectResult(response);
            }

        }



        
    }
}
