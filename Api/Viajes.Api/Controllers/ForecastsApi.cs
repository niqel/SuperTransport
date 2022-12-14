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
using Newtonsoft.Json;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using AuthenticationHandler.Controllers;
using IO.Swagger.Business;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using CrmTc.DAL.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ForecastsApiController : TmsControllerBase
    {
        protected CrmTcEntities CrmContext { get; private set; }

        public ForecastsApiController(TmsTcAPI.DAL.Models.TmsTcEntities context, CrmTcEntities crmContext) : base(context)
        {
            CrmContext = crmContext;
        }
        /// <summary>
        /// Obtiene los forecast
        /// </summary>
        /// <param name="startDate">La primera fecha a consultar</param>
        /// <param name="endDate">La última fecha a consultar</param>
        /// <param name="edited">Filtrar elementos que han sido editados desde la interfaz gráfica</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/forecasts")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetForecasts")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Forecast>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetForecasts([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate, [FromQuery] bool? edited)
        {
            return new ForecastsBusiness(Context, CrmContext, User).GetForecasts(startDate, endDate, edited);
        }

        /// <summary>
        /// Actualiza los forecasts
        /// </summary>
        /// <param name="body"></param>
        /// <param name="startDate">La primera fecha a incluir en el forecast</param>
        /// <param name="endDate">La última fecha a incluir en el forecast</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPut]
        [Route("/forecasts")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateForecasts")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult UpdateForecasts([FromBody]List<Forecast> body, [FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate)
        {
            return new ForecastsBusiness(Context, CrmContext, User).UpdateForecasts(body, startDate, endDate);
        }

        /// <summary>
        /// Sube un archivo de forecasts
        /// </summary>
        /// <param name="file">El archivo a subir</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPut]
        [Route("/forecasts/upload")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [AllowAnonymous]
        [SwaggerOperation("UploadForecasts")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Forecast>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult UploadForecasts([Required]IFormFile file)
        {
            return new ForecastsBusiness(Context, CrmContext, User).UploadForecasts(file);
        }
    }
}
