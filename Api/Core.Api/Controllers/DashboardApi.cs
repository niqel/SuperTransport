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
using Core.Api.Business;
using ListdbTc.DAL.Models;
using AuthenticationHandler.Controllers;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DashboardApiController : TmsControllerBase
    {
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        public DashboardApiController(TmsTcAPI.DAL.Models.TmsTcEntities context, ListdbTcEntities listdbTcContext) : base(context)
        {
            ListdbTcContext = listdbTcContext;
        }

        /// <summary>
        /// Obtiene las series de datos para la gráfica Forecast vs Real
        /// </summary>
        /// <param name="startDate">La primera fecha a consultar</param>
        /// <param name="endDate">La última fecha a consultar</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/dashboard/forecast-vs-real")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetForecastVsReal")]
        [SwaggerResponse(statusCode: 200, type: typeof(ForecastVsReal), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetForecastVsReal([FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate)
        {
            return new DashboardBusiness(Context, ListdbTcContext, User).GetForecastVsReal(startDate, endDate);
        }

        /// <summary>
        /// Obtiene las series de datos para la gráfica Cantidad de Flota Cargada vs Vacía
        /// </summary>
        /// <param name="startDate">La primera fecha a consultar</param>
        /// <param name="endDate">La última fecha a consultar</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/dashboard/fleet-loaded-vs-empty")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetLoadedVsEmpty")]
        [SwaggerResponse(statusCode: 200, type: typeof(FleetLoadedVsEmpty), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetLoadedVsEmpty([FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate)
        {
            return new DashboardBusiness(Context, ListdbTcContext, User).GetLoadedVsEmpty(startDate, endDate);
        }

        /// <summary>
        /// Obtiene las series de datos para la gráfica Viajes Realizados vs Cancelados
        /// </summary>
        /// <param name="startDate">La primera fecha a consultar</param>
        /// <param name="endDate">La última fecha a consultar</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/dashboard/trips-made-vs-cancelled")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTripsMadeVsCancelled")]
        [SwaggerResponse(statusCode: 200, type: typeof(TripsMadeVsCancelled), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetTripsMadeVsCancelled([FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TripsMadeVsCancelled));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ProblemDetails));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ProblemDetails));
            string exampleJson = null;
            exampleJson = "{\n  \"trips_made\" : [ {\n    \"date\" : \"2000-01-23\",\n    \"value\" : 0.8008281904610115\n  }, {\n    \"date\" : \"2000-01-23\",\n    \"value\" : 0.8008281904610115\n  } ],\n  \"trips_cancelled\" : [ null, null ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<TripsMadeVsCancelled>(exampleJson)
                        : default(TripsMadeVsCancelled);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Obtiene las series de datos para la gráfica Uso de Equipo Actual
        /// </summary>
        /// <param name="startDate">La primera fecha a consultar</param>
        /// <param name="endDate">La última fecha a consultar</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/dashboard/trucks-usage")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTrucksUsage")]
        [SwaggerResponse(statusCode: 200, type: typeof(TrucksUsage), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetTrucksUsage([FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TrucksUsage));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ProblemDetails));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ProblemDetails));
            string exampleJson = null;
            exampleJson = "{\n  \"trucks_usage\" : [ {\n    \"date\" : \"2000-01-23\",\n    \"value\" : 0.8008281904610115\n  }, {\n    \"date\" : \"2000-01-23\",\n    \"value\" : 0.8008281904610115\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<TrucksUsage>(exampleJson)
                        : default(TrucksUsage);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
