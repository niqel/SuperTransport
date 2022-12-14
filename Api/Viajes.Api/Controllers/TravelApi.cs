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
    public class TravelApiController : TmsControllerBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }

        public TravelApiController(TmsTcEntities context, InnovaLinksEntities innovaLinksContext, ListdbTcEntities listdbTcContext, CrmTcEntities crmContext) : base(context)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            ListdbTcContext = listdbTcContext;
        }

        /// <summary>
        /// Consulta de viajes completados del operador
        /// </summary>
        /// <param name="type"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/travel/completed")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTravelsCompleted")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Payment>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetTravelsCompleted([FromQuery][Required()] int? idOperator)
        {
            return new TravelBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).GetTravelsCompleted(idOperator);
        }

     
        /// <summary>
        /// Consulta viaje actual o ultimo del operador
        /// </summary>
        /// <param name="idOperator">Id del operador</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/travel/current/{idOperator}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTravelsCurrent")]
        [SwaggerResponse(statusCode: 200, type: typeof(TravelCurrent), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ProblemDetails), description: "Not Found")]
        public virtual IActionResult GetTravelsCurrent([FromRoute][Required] int? idOperator)
        {
            return new TravelBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).GetTravelsCurrent(idOperator);
        }



    }
}
