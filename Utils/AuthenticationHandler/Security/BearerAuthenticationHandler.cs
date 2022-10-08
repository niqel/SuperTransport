using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;

using System.Text.Json;
using AuthenticationHandler.Settings;

namespace IO.Swagger.Security
{
    /// <summary>
    /// class to handle bearer authentication.
    /// </summary>
    public class BearerAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        /// <summary>
        /// scheme name for authentication handler.
        /// </summary>
        public const string SchemeName = "Bearer";
        private readonly TmsTcEntities context;
        private string failureMessage;

        public BearerAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, TmsTcEntities context) : base(options, logger, encoder, clock)
        {
            this.context = context;
        }

        /// <summary>
        /// verify that require authorization header exists.
        /// </summary>
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Fail("Falta la cabecera de autorización");
            }
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

                if(authHeader.Scheme == Scheme.Name)
                {
                    return ProcessBearerToken(authHeader.Parameter);
                } else
                {
                    return Fail("Esquema de autorización no válido: "+authHeader.Scheme);
                }
            }
            catch
            {
                return Fail("Cabecera de autorización inválida");
            }
        }

        private AuthenticateResult Fail(string failureMessage)
        {
            this.failureMessage = failureMessage;
            return AuthenticateResult.Fail(failureMessage);
        }

        override protected async Task HandleChallengeAsync(AuthenticationProperties properties)
        {
            Context.Response.StatusCode = 401;
            Context.Response.ContentType = "application/json";
            var problemDetails = new ProblemDetails() { Type = "https://httpstatuses.com/401", Title = "Unauthorized", Status = 401, Detail = failureMessage};
            var json = JsonSerializer.Serialize(problemDetails);
            await Context.Response.Body.WriteAsync(Encoding.UTF8.GetBytes(json));
        }

        private AuthenticateResult ProcessBearerToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var validations = createValidations(AuthenticationSettings.SecretKey);
            var user = handler.ValidateToken(token, validations, out var tokenSecure);

            var id = int.Parse(user.Identity.Name);
            var sessionToken = user.Claims.Where(c => c.Type == ClaimTypes.Sid).FirstOrDefault().Value;

            Usuarios usuario = null;
            try
            {
                usuario = context.Usuarios.Where(u => u.Id == id && u.SesionToken == sessionToken).FirstOrDefault();
            }
            catch
            {
                return Fail("No se pudo contactar a la base de datos de sesiones");
            }
            
            if (usuario == null)
                return Fail("La sesión se ha cerrado previamente");
            else
            {
                // Leemos la tolerancia máxima de timeout de la sesión
                var timeOut = AuthenticationSettings.TimeOut;
                var now = DateTime.UtcNow.AddHours(-6);


                if (usuario.SesionFechaHora.Value.AddMinutes(timeOut) > now)
                {
                    usuario.SesionFechaHora = now;
                    context.SaveChanges();

                    var ticket = new AuthenticationTicket(user, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }
                else
                {
                    return Fail("Tu sesión fue finalizada por inactividad");
                }
            }
        }

        private TokenValidationParameters createValidations(string secretKey)
        {
            var key = Encoding.ASCII.GetBytes(secretKey);
            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
            return validations;
        }
    }
}
