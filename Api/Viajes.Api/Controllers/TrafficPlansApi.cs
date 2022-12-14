/*
 * Transportes Cuauhtémoc
 *
 * Transportes Cuauhtémoc (ASP.NET Core 3.1)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using CrmTc.DAL.Models;
using AuthenticationHandler.Controllers;
using IO.Swagger.Business;
using Microsoft.AspNetCore.Http;
using InnovaLinks.DAL.Models;

namespace IO.Swagger.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TrafficPlansApiController : TmsControllerBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }


        public TrafficPlansApiController(TmsTcAPI.DAL.Models.TmsTcEntities context, InnovaLinksEntities innovaLinksContext, CrmTcEntities crmContext) : base(context)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
        }

        /// <summary>
        /// Añade un plan de tráfico
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPost]
        [Route("/traffic-plans")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AddTrafficPlan")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult AddTrafficPlan([FromBody] TrafficPlan body)
        {
            return new TrafficPlansBusiness(Context, InnovaLinksContext, CrmContext, User).AddTrafficPlans(body);
        }

        /// <summary>
        /// Elimina un plan de tráfico
        /// </summary>
        /// <param name="id">El id del plan de tráfico</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("/traffic-plans/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteTrafficPlan")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ProblemDetails), description: "Not Found")]
        public virtual IActionResult DeleteTrafficPlan([FromRoute][Required] int? id)
        {
            return new TrafficPlansBusiness(Context, InnovaLinksContext, CrmContext, User).DeleteTrafficPlans(id);
        }

        /// <summary>
        /// Obtiene los planes de tráfico
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/traffic-plans")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTrafficPlans")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TrafficPlan>), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetTrafficPlans()
        {
            return new TrafficPlansBusiness(Context, InnovaLinksContext, CrmContext, User).GetTrafficPlans();
        }

        /// <summary>
        /// Actualiza un plan de tráfico
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">El id del plan de tráfico</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpPut]
        [Route("/traffic-plans/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateTrafficPlan")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ProblemDetails), description: "Not Found")]
        public virtual IActionResult UpdateTrafficPlan([FromBody] TrafficPlan body, [FromRoute][Required] int? id)
        {
            return new TrafficPlansBusiness(Context, InnovaLinksContext, CrmContext, User).UpdateTrafficPlans(body, id);
        }

        /// <summary>
        /// Sube un archivo de plan de tráfico
        /// </summary>
        /// <param name="file">El archivo a subir</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPut]
        [Route("/traffic-plans/upload")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [AllowAnonymous]
        [SwaggerOperation("UploadTrafficPlans")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TrafficPlan>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult UploadTrafficPlans([Required] IFormFile file)
        {
            return new TrafficPlansBusiness(Context, InnovaLinksContext, CrmContext, User).UploadTrafficPlans(file);
        }

        /// <summary>
        /// Obtiene la informacion de zam por medio de un StoreProcedure.
        /// </summary>
        /// <response code="204">El recurso sido cargado.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPatch]
        [Route("/traffic-plans")]
        //[Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        //[ValidateModelState]
        [SwaggerOperation("UpdateStatusOperationTraffic")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult UpdateStatusOperationTraffic()
        {
            TrafficPlansBusiness trafficPlansBusiness = new TrafficPlansBusiness(Context, InnovaLinksContext, CrmContext, User);
            trafficPlansBusiness.UpdateStatusOperationTraffic();

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ProblemDetails));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ProblemDetails));
        }
    }
}
