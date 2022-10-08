using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace IO.Swagger.Business
{
    public class CitiesBusiness: BusinessBase
    {
        public CitiesBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetCities(bool? active)
        {
            var query = Context.Ciudades.AsQueryable();
            if (active.HasValue)
                query = query.Where(c => c.Active == active.Value);
            var zones = query.Select(c => new City
            {
                Id = c.Id,
                Name = c.Nombre,
                Description = c.Descripcion,
                Latitude = c.Latitud,
                Longitude = c.Longitud,
                Zone = c.IdZona,
                Active = c.Active == true
            }).ToList();
            return new OkObjectResult(zones);
        }

        public IActionResult UpdateCityZone(int id, int? zone)
        {
            var city = Context.Ciudades.Where(p => p.Id == id).FirstOrDefault();
            if (city == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "La ciudad especificada no existe" });

            city.IdZona = zone;
            city.UpdatedBy = CurrentUser.Id;
            city.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "La zona de la ciudad fue actualizada exitosamente" });
        }
    }
}
