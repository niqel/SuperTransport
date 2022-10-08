using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IO.Swagger.Models;
using AuthenticationHandler.Business;

namespace IO.Swagger.Business
{
    public class ModulesBusiness: BusinessBase
    {
        public ModulesBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetModules()
        {
            var modules = Context.Modulos.Where(m => m.Active == true).Select(m => new Module {
                Id = m.Id,
                Name = m.Nombre,
                Active = m.Active,
                CreatedBy = m.CreatedBy,
                CreatedAt = m.CreatedAt,
                UpdatedBy = m.UpdatedBy,
                UpdatedAt = m.UpdatedAt
            }).ToList();
            return new OkObjectResult(modules);
        }

        public ObjectResult GetFunctionalities(int module)
        {
            var modules = Context.Funcionalidad.Where(f => f.IdModulo == module && f.Active == true).Select(f => new Functionality
            {
                Id = f.Id,
                Parent = f.FuncionalidadPadre,
                Name = f.Nombre,
                Active = f.Active,
                CreatedBy = f.CreatedBy,
                CreatedAt = f.CreatedAt,
                UpdatedBy = f.UpdatedBy,
                UpdatedAt = f.UpdatedAt
            }).ToList();
            return new OkObjectResult(modules);
        }
    }
}
