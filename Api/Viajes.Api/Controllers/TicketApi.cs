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
    public class TicketApiController : TmsControllerBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }

        public TicketApiController(TmsTcEntities context, InnovaLinksEntities innovaLinksContext, ListdbTcEntities listdbTcContext, CrmTcEntities crmContext) : base(context)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            ListdbTcContext = listdbTcContext;
        }

        /// <summary>
        /// Dar de alta un nuevo ticket
        /// </summary>
        /// <param name="type"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPost]
        [Route("/ticket")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateTicket")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Payment>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult CreateTicket([FromBody] Ticket body)
        {
            return new TicketBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).CreateTicket(body);
        }

        /// <summary>
        /// Obtener catálogo de departamentos
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/ticket/departments")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetDepartments")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Department>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetDepartments()
        {
            return new TicketBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).GetDepartments();
        }

        /// <summary>
        /// Consulta de tickets
        /// </summary>
        /// <param name="type"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/ticket")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTicket")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Payment>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetTicket()
        {
            return new TicketBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).GetTicket();
        }

        /// <summary>
        /// Obtener catálogo de estatus de ticket
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/ticket/status")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTicketStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TicketStatus>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetTicketStatus()
        {
            return new TicketBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).GetTicketStatus();
        }

        /// <summary>
        /// Obtener catálogo de tipos de ticket
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/ticket/types")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTicketTypes")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TicketType>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetTicketTypes()
        {
            return new TicketBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).GetTicketTypes();
        }

        /// <summary>
        /// Actualizar un ticket
        /// </summary>
        /// <param name="type"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPatch]
        [Route("/ticket")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateTicket")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Payment>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult UpdateTicket([FromBody] Ticket body)
        {
            return new TicketBusiness(Context, CrmContext, InnovaLinksContext, ListdbTcContext, User).UpdateTicket(body);
        }
    }
}