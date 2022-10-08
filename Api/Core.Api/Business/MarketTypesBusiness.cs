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
    public class MarketTypesBusiness: BusinessBase
    {
        public MarketTypesBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetMarketTypes(bool? active)
        {
            var query = Context.MarketType.AsQueryable();
            if (active.HasValue)
                query = query.Where(r => r.Active == active.Value);
            var tiposDeMercado = query.Select(r => new Models.MarketType
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description,
                Active = r.Active
            }).ToList();
            return new OkObjectResult(tiposDeMercado);
        }

        public ObjectResult AddMarketType(Models.MarketType body)
        {
            var tipoMercado = new TmsTcAPI.DAL.Models.MarketType();

            tipoMercado.Name = body.Name;
            tipoMercado.Description = body.Description;
            tipoMercado.Active = true;
            tipoMercado.CreatedBy = CurrentUser.Id;
            tipoMercado.CreatedAt = DateTime.UtcNow.AddHours(-6);
            tipoMercado.UpdatedBy = CurrentUser.Id;
            tipoMercado.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.MarketType.Add(tipoMercado);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Agregado Correctamente", Detail = "El tipo de mercado fue agregado correctamente" });
        }

        public ObjectResult DeleteMarketType(int id)
        {
            var tipoMercado = Context.MarketType.Where(p => p.Id == id).FirstOrDefault();
            if (tipoMercado == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El tipo de mercado especificado no existe" });

            if (tipoMercado.Active == false)
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Deshabilitado anteriormente", Detail = "El tipo de mercado ya había sido deshabilitado" });

            tipoMercado.Active = false;
            tipoMercado.UpdatedBy = CurrentUser.Id;
            tipoMercado.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Eliminado correctamente", Detail = "Tipo de mercado eliminado exitosamente" });
            }

        public ObjectResult UpdateMarketType(int id, Models.MarketType body)
        {
            var tipoDeMercado = Context.MarketType.Where(p => p.Id == id).FirstOrDefault();
            if (tipoDeMercado == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El tipo de mercado especificado no existe" });

            tipoDeMercado.Id = body.Id.Value;
            tipoDeMercado.Name = body.Name;
            tipoDeMercado.Description = body.Description;
            tipoDeMercado.UpdatedBy = CurrentUser.Id;
            tipoDeMercado.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.SaveChanges();
            
            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El tipo de mercado fue actualizado correctamente" });
        }
    }
}
