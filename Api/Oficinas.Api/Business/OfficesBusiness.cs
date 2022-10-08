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
    public class OfficesBusiness: BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        public OfficesBusiness(TmsTcEntities context, CrmTcEntities crmContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
        }

        public ObjectResult GetOffices()
        {
            var oficinas_id = CrmContext.DistanciasRegresos.Select(dr => dr.Oficinasid).Distinct();
            var oficinas = CrmContext.Origenes.Where(o => oficinas_id.Contains(o.Id)).Select(o => new Office()
            {
                Id = o.Id,
                Name = o.Nombre,
                Description = o.Descripcion,
                Active = o.Active,
                City = o.Ciudadesid,
                Coordinates = new Coordinates() { Latitude = double.Parse(o.Latitud, CultureInfo.InvariantCulture), Longitude = double.Parse(o.Longitud, CultureInfo.InvariantCulture) },
                CreatedBy = o.CreatedBy,
                CreatedAt = o.CreatedAt,
                UpdatedBy = o.CreatedBy,
                UpdatedAt = o.CreatedAt
            }).ToList();
            return new OkObjectResult(oficinas);
        }
    }
}
