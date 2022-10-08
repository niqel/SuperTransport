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
    public class ZonesBusiness: BusinessBase
    {
        public ZonesBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetZones(bool? active)
        {
            var query = Context.Zonas.AsQueryable();
            if (active.HasValue)
                query = query.Where(r => r.Active == active.Value);
            var zones = query.Select(r => new Zone
            {
                Id = r.Id,
                Name = r.Nombre,
                Code = r.Codigo,
                Active = r.Active == true
            }).ToList();
            return new OkObjectResult(zones);
        }

        public ObjectResult AddZone(Zone body)
        {
            var zone = new Zonas();

            zone.Nombre = body.Name;
            zone.Codigo = body.Code;
            zone.Active = true;
            zone.CreatedBy = CurrentUser.Id;
            zone.CreatedAt = DateTime.UtcNow.AddHours(-6);
            zone.UpdatedBy = CurrentUser.Id;
            zone.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.Zonas.Add(zone);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Agregado Correctamente", Detail = "La zona fue agregada correctamente" });
        }

        public ObjectResult DeleteZone(int id)
        {
            var zona = Context.Zonas.Where(z => z.Id == id).FirstOrDefault();
            if (zona == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "La zona especificada no existe" });

            if (zona.Active == false)
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Eliminada anteriormente", Detail = "La zona ya había sido eliminada" });

            var ciudadesAsignadas = Context.Ciudades.Where(c => c.IdZona == id).Count();
            if (ciudadesAsignadas > 0)
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "No se puede eliminar", Detail = "No se puede eliminar la zona " + zona.Nombre + ", ya que tiene ciudades asignadas" });

            zona.Active = false;
            zona.UpdatedBy = CurrentUser.Id;
            zona.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Eliminado correctamente", Detail = "La zona fue eliminada exitosamente" });
        }

        public ObjectResult UpdateZone(int id, Zone body)
        {
            var zone = Context.Zonas.Where(p => p.Id == id).FirstOrDefault();
            if (zone == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "La zona especificada no existe" });

            zone.Id = body.Id.Value;
            zone.Nombre = body.Name;
            zone.Codigo = body.Code;
            zone.UpdatedBy = CurrentUser.Id;
            zone.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "La zona fue actualizada exitosamente" });
        }
    }
}
