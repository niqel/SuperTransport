/*
 * ITESM-LVCD
 *
 * Documentación de api del TMS de Transportes Cuauhtémoc
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using IO.Swagger.Business;
using TmsTcAPI.DAL.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SessionsApiController : ControllerBase
    {
        private readonly TmsTcEntities context;

        public SessionsApiController(TmsTcEntities context)
        {
            this.context = context;
        }


        /// <summary>
        /// Crea una nueva sesión
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        [Route("/sessions")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [AllowAnonymous]
        [ValidateModelState]
        [SwaggerOperation("Login")]
        [SwaggerResponse(statusCode: 200, type: typeof(Session), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(ProblemDetails), description: "Bad Request")]
        public virtual IActionResult Login([FromBody]Login body)
        {
            var re = Request;
            var headers = re.Headers;
            string tipoUsuario = "web";
            if (headers.ContainsKey("application-id"))
            {
                tipoUsuario = headers.Keys.Contains("application-id").ToString();
            }

            return new SessionsBusiness(context, User).Login(body.Email, body.Password, tipoUsuario);
        }

        /// <summary>
        /// Cierra la sesión actual
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpDelete]
        [Route("/sessions")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Logout")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProblemDetails), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(ProblemDetails), description: "Unauthorized")]
        public virtual IActionResult Logout()
        {
            return new SessionsBusiness(context, User).Logout();
        }
    }
}
