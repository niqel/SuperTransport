using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System.Linq;
using System.Collections.Generic;
using CrmTc.DAL.Models;
using System.Globalization;

namespace IO.Swagger.Business
{
    public class LocationsBusiness: BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        public LocationsBusiness(TmsTcEntities context, CrmTcEntities crmContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
        }

        public ObjectResult GetLocations(LocationType type)
        {
            var locations = GeLocations(CrmContext, type);
            return new OkObjectResult(locations);
        }

        public static List<Location> GeLocations(CrmTcEntities crmContext, LocationType type)
        {
            var locationsQuery = crmContext.Origenes.Where(o => o.Active == true);
            if (type == LocationType.Office)
            {
                locationsQuery = from OP in crmContext.OficinasOperativas
                                          join OF in crmContext.Oficinas on OP.Oficinasid equals OF.Id
                                          select new CrmTc.DAL.Models.Origenes() { 
                                            Id = OP.Id,
                                            Nombre = OF.Nombre,
                                            Descripcion = OF.Descripcion,
                                            Active = OP.Active,
                                            Latitud = OP.Latitud,
                                            Longitud = OP.Longitud,
                                            CreatedAt = OP.CreatedAt,
                                            CreatedBy = OP.CreatedBy
                                          };


                var locations = locationsQuery.Select(l => new Location()
                {
                    Id = l.Id,
                    Name = l.Nombre,
                    Description = l.Descripcion,
                    Alias = GetAliasCliente(l.Id, crmContext.OficinasOperativas.ToList(), crmContext.Clientes.ToList()),
                    Active = l.Active,
                    City = l.Ciudadesid,
                    Coordinates = GetCoordinates(l.Latitud, l.Longitud),
                    CreatedBy = l.CreatedBy,
                    CreatedAt = l.CreatedAt,
                    UpdatedBy = l.CreatedBy,
                    UpdatedAt = l.CreatedAt
                });

                return locations.ToList();


            }

            locationsQuery = locationsQuery.OrderBy(o => o.Id);
            return GetIQLocation(locationsQuery).ToList();
        }

        public static IQueryable<Location> GetIQLocation(IQueryable<CrmTc.DAL.Models.Origenes> locationsQuery)
        {
            var locations = locationsQuery.Select(l => new Location()
            {
                Id = l.Id,
                Name = l.Nombre,
                Description = l.Descripcion,
                Active = l.Active,
                City = l.Ciudadesid,
                Coordinates = GetCoordinates(l.Latitud, l.Longitud),
                CreatedBy = l.CreatedBy,
                CreatedAt = l.CreatedAt,
                UpdatedBy = l.CreatedBy,
                UpdatedAt = l.CreatedAt
            });

            return locations;
        }

        private static Coordinates GetCoordinates(string latitud, string longitud)
        {
            return new Coordinates() { Latitude = double.Parse(latitud, CultureInfo.InvariantCulture), Longitude = double.Parse(longitud, CultureInfo.InvariantCulture) };
        }

        private static string GetAliasCliente(int idOficinaOperariva, List<OficinasOperativas> oficinasOperativas, List<CrmTc.DAL.Models.Clientes> clientes)
        {
            var aliasCleinte = (from op in oficinasOperativas
                                join cl in clientes
                                 on op.Clientesid equals cl.Id
                                where op.Id == idOficinaOperariva
                                select cl.Alias).FirstOrDefault();

            return aliasCleinte;

        }
    }
}
