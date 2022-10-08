using AuthenticationHandler.Business;
using System;
using System.Linq;
using System.Security.Claims;
using TmsTcAPI.DAL.Models;

public class SettlementBusiness : BusinessBase
{
    public SettlementBusiness(TmsTcEntities context) : base(context)
    {

    }

    public void CreateSettlements(int? numberTrips)
    {
        //paso 1: Se Inicializa variable parametro para identificar el minimo numero de viajes
        int number = (int)numberTrips;

        //Paso 2: Se obtienen todos los status del viaje
        var travelStatus = this.Context.TripsStatus.ToList();
        //Paso 3: Se obtiene el id del status finalizado
        var IdStatusTripCompleted = travelStatus.Where(x => x.Key == "FIN").FirstOrDefault().Id;
        //Paso 4: Se obtiene el id del status proceso de liquidacion
        var IdTravelStatusSettlement = travelStatus.Where(x => x.Key == "PLIQ").FirstOrDefault().Id;

        //Paso 5: Se obtiene el id del estatus de liquidacion nuevo
        var IdStatusSettlementNew = this.Context.LiquidacionStatus.Where(x => x.Key == "NVO").Select(x => x.Id).FirstOrDefault();

        //Paso 6: Se obtiene la corte, fecha actual menos 24 horas
        var cutOffDate = DateTime.Now.AddHours(-24);

        //Paso 7: Se obtienen todos los viajes donde su estatus es finalizado y la ultima actualizacion es =< fecha corte
        var tripsToLiquidate = (from tl in Context.Trips
                                join tpo in Context.RTripsOperator on tl.Id equals tpo.Tripsid
                                where tl.TripsStatusid == IdStatusTripCompleted
                                     && tl.UpdatedAt <= cutOffDate
                                select new
                                {
                                    idTrip = tl.Id,
                                    operatorId = tpo.Operatorid,
                                    idStatus = tl.TripsStatusid,
                                    updateAt = tl.UpdatedAt
                                }).ToList();

        //paso 8: Se agrupan los operadores y se cuentan los numeros de viaje a liquidar solo se traen los que sean igual 
        //        o mayor al parametro number
        var operatorsToLiquidate = (from op in tripsToLiquidate
                                   group op by op.operatorId
                                   into g
                                   where g.Count() >= number
                                   select new { g.Key, Count = g.Count() }).ToList();

        //Paso 9: Se recorren todos los operadores listos para liquidar
        foreach (var operatorToLiquidate in operatorsToLiquidate)
        {
            //Paso 9.1: Se crea una liquidacion
            Liquidacion liquidacion = new Liquidacion()
            {
                LiquidacionStatusid = IdStatusSettlementNew,
                CreatedBy = -1,
                UpdatedBy = -1,
                Active = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            //Paso 9.2: Se guarda la liquidacion y se obtiene el id
            this.Context.Liquidacion.Add(liquidacion);
            int idSettlement = this.Context.SaveChanges();

            //Paso 9.3: Se busca en traffic todos los viajes por el operador IDd
            var trafficplans = (from tp in Context.Trips
                                join tpo in Context.RTripsOperator on tp.Id equals tpo.Tripsid
                                where tpo.Operatorid == operatorToLiquidate.Key
                                select tp).ToList();

            //Paso 9.4: Se recorren los viajes del operador
            foreach (var trip in trafficplans)
            {
                //Paso 9.4.1: Se actualizan los campos del viaje
                trip.TripsStatusid = IdTravelStatusSettlement;
                trip.UpdatedAt = DateTime.Now;
                trip.UpdatedBy = -1;
                trip.CreatedBy = -1;
                trip.CreatedAt = DateTime.Now;
                trip.LiquidacionId = idSettlement;
                this.Context.Trips.Add(trip);
                //Paso 9.4.2: Se guardan los cambios
                this.Context.SaveChanges();
            }
        }
    }
}