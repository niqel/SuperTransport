using CrmTc.DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TmsTcAPI.BLL.Business;
using Viajes.Api.Extensions;

namespace IO.Swagger.Models
{
    public static class TruckCostExtensions
    {
        public static TravelCost CostTo(this Truck truck, Office office, List<DistanciasRegresos> distanciasRegresos)
        {
            if (truck.Position == null)
                return null;

            if (InGeofence(truck.Position.Coordinates, office.Location.Coordinates, office.Geofence))
                return new TravelCost { Arrival = truck.Position.Timestamp, Cost = 0, Distance = 0 };

            foreach (var regresoPosible in distanciasRegresos.Where(dr => dr.Oficinasid == office.Location.Id))
            {
                if (InGeofence(truck.Position.Coordinates, GetCoordinates(regresoPosible.Destinos.Latitud, regresoPosible.Destinos.Longitud), 1000)) {
                    return new TravelCost
                    {
                        Arrival = truck.Position.Timestamp.Value.AddMinutes(regresoPosible.Tiempo.Value),
                        Distance = Convert.ToDouble(regresoPosible.Kms),
                        Cost = Convert.ToDouble(regresoPosible.Kms)
                    };
                }   
            }

            return null;
        }

        private static bool InGeofence(Coordinates source, Coordinates target, double geofence)
        {
            return source.DistanceTo(target, UnitOfLength.Kilometers) <= geofence;
        }

        private static double GetDistance(Coordinates source, Coordinates target)
        {
            return source.DistanceTo(target, UnitOfLength.Kilometers);
        }

        private static Coordinates GetCoordinates(string latitud, string longitud)
        {
            return new Coordinates() { Latitude = double.Parse(latitud, CultureInfo.InvariantCulture), Longitude = double.Parse(longitud, CultureInfo.InvariantCulture) };
        }
    }
}