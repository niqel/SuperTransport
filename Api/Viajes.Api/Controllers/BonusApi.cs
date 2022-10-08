/*
 * Transportes Cuauhtémoc
 *
 * Transportes Cuauhtémoc (ASP.NET Core 3.1)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using Viajes.Api.Business;
using AuthenticationHandler.Controllers;
using CrmTc.DAL.Models;
using InnovaLinks.DAL.Models;
using ListdbTc.DAL.Models;
using TmsTcAPI.DAL.Models;
using Viajes.Api.Business;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class BonusApiController : TmsControllerBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }

        public BonusApiController(TmsTcEntities context, InnovaLinksEntities innovaLinksContext, ListdbTcEntities listdbTcContext, CrmTcEntities crmContext) : base(context)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            ListdbTcContext = listdbTcContext;
        }
        /// <summary>
        /// Calcular bono
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPost]
        [Route("/bonus")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateBonus")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult CreateBonus()
        {
            return new BonusBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).CreateBonus();
        }

        /// <summary>
        /// Obtener las rúbricas y puntuación del bono por viaje de un operador
        /// </summary>
        /// <param name="type"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/bonus")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetBonus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Payment>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetBonus([FromQuery] int? idOperator, [FromQuery] int? idTravel)
        {
            return new BonusBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).GetBonus(idOperator, idTravel);
        }

        /// <summary>
        /// Actualizar bono
        /// </summary>
        /// <param name="type"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPatch]
        [Route("/bonus")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateBonus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Payment>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult UpdateBonus([FromBody] Bonus body)
        {
            return new BonusBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).UpdateBonus(body);
        }
    }
}
