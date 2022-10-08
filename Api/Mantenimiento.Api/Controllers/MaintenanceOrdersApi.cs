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
using IO.Swagger.Business;
using AuthenticationHandler.Controllers;
using ListdbTc.DAL.Models;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class LoadPlansApiController : TmsControllerBase
    {
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        public LoadPlansApiController(TmsTcAPI.DAL.Models.TmsTcEntities context, ListdbTcEntities listdbTcContext) : base(context)
        {
            ListdbTcContext = listdbTcContext;
        }

        /// <summary>
        /// Obtiene las ordenes de mantenimiento
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/maintenance-orders")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetMaintenanceOrders")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<MttoOrden>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetMaintenanceOrders([FromQuery]Status? status, [FromQuery]DateTime? startDate)
        {
            return new MaintenanceOrdersBusiness(Context, ListdbTcContext, User).GetMaintenanceOrders(status, startDate);
        }
    }
}
