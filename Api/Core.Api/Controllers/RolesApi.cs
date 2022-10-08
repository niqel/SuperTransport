/*
 * ITESM-LVCD
 *
 * Documentación de api del TMS de Transportes Cuauhtémoc
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using TmsTcAPI.DAL.Models;
using IO.Swagger.Business;
using IO.Swagger.Models;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class RolesApiController : ControllerBase
    {
        private readonly TmsTcEntities context;

        public RolesApiController(TmsTcEntities context)
        {
            this.context = context;
        }

        /// <summary>
        /// Obtiene los roles
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/roles")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRoles")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Role>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetRoles()
        {
            return new RolesBusiness(context, User).GetRoles();
        }

        /// <summary>
        /// Añade un rol
        /// </summary>
        /// <param name="body">El rol a añadir</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPost]
        [Route("/roles")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AddRole")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult AddRole([FromBody][Required]Role body)
        {
            return new RolesBusiness(context, User).AddRole(body);
        }

        /// <summary>
        /// Actualiza un rol
        /// </summary>
        /// <param name="id">El id del rol</param>
        /// <param name="body">El rol modificado</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpPut]
        [Route("/roles/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateRole")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ProblemDetails), description: "Not Found")]
        public virtual IActionResult UpdateRole([FromRoute][Required]int id, [FromBody][Required]Role body)
        {
            return new RolesBusiness(context, User).UpdateRole(id, body);
        }

        /// <summary>
        /// Elimina un rol
        /// </summary>
        /// <param name="id">El id del rol</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpDelete]
        [Route("/roles/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteRole")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ProblemDetails), description: "Not Found")]
        public virtual IActionResult DeleteRole([FromRoute][Required]int id)
        {
            return new RolesBusiness(context, User).DeleteRole(id);
        }

        /// <summary>
        /// Obtiene el historial de un rol
        /// </summary>
        /// <param name="id">El id del rol</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("/roles/{id}/history")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRoleHistory")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<HistoryRecord>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult GetRoleHistory([FromRoute][Required]int id)
        {
            return new RolesBusiness(context, User).GetRoleHistory(id);
        }
    }
}