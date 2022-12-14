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
using AuthenticationHandler.Controllers;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SettlementApiController : TmsControllerBase
    {
        private SettlementBusiness SettlementBusiness;
        public SettlementApiController(TmsTcAPI.DAL.Models.TmsTcEntities context) : base(context)
        {
            SettlementBusiness = new SettlementBusiness(context);
        }

        /// <summary>
        /// Crea las nuevas liquidaciones
        /// </summary>
        /// <param name="numberTrips">Son los numeros de viajes para generar la liquidacion</param>
        /// <response code="204">El recurso sido cargado.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPatch]
        [Route("/Settlement/{numberTrips}/")]
        [AllowAnonymous]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateSettlements")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult CreateSettlements([FromRoute][Required]int? numberTrips)
        {
            this.SettlementBusiness.CreateSettlements(numberTrips);
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
             return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ProblemDetails));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ProblemDetails));
        }
    }
}
