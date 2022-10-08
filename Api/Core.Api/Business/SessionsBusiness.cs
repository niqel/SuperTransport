using AuthenticationHandler.Business;
using AuthenticationHandler.Models;
using AuthenticationHandler.Settings;
using Core.Api.BLL.Business;
using CrmTcAPI.Models;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TmsTcAPI.DAL.Models;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace IO.Swagger.Business
{
    public class SessionsBusiness : BusinessBase
    {
        public SessionsBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }
        

        public ObjectResult Login(string email, string password, string tipoUsuario)
        {
            var respuesta = new AutenticacionBusiness(Context).Login(email, password, tipoUsuario);

            // Tu código para validar que el usuario ingresado es válido
            if (respuesta.Mensaje != String.Empty)
            {
                throw new Exception(respuesta.Mensaje);
            }

            List<param_idusuario> listaUsuarios = (List<param_idusuario>)respuesta.Data;

            if (listaUsuarios.Count == 0)
            {
                var problem = new ProblemDetails
                {
                    Title = "Acceso incorrecto",
                    Detail = "Las credenciales son inválidas, favor de validar la información ingresada"
                };
                BadRequestObjectResult bro = new BadRequestObjectResult(problem);
                bro.StatusCode = 200;
                return bro;
            }

            var user = new UsersBusiness(Context, null).GetUser(listaUsuarios[0]);
            var session = CreateSession(user, listaUsuarios[0].SesionToken);
            if (listaUsuarios[0].ConSesionActiva)
                session.Message = "El usuario ya contaba con una sesión iniciada, la cual será finalizada";
            return new OkObjectResult(session);
        }

        public ObjectResult Logout()
        {
            var respuesta = new AutenticacionBusiness(Context).Logout(CurrentUser.Id);
            if (respuesta.Mensaje != String.Empty)
            {
                throw new Exception(respuesta.Mensaje);
            }

            var problem = new ProblemDetails
            {
                Title = "Acceso terminado",
                Detail = "El acceso a finalizado correctamente"
            };
            return new OkObjectResult(problem);
        }

        private Session CreateSession(User user, string sessionToken)
        {
            var tokenDescriptor = CreateTokenDescriptor(user, sessionToken);
            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(createdToken);

            var session = new Session
            {
                Message = "Acceso correcto",
                Token = token,
                Expires = tokenDescriptor.Expires,
                User = user
            };

            return session;
        }

        private SecurityTokenDescriptor CreateTokenDescriptor(User user, string sessionToken)
        {
            var key = Encoding.ASCII.GetBytes(AuthenticationSettings.SecretKey);

            var currentUser = new CurrentUser() { Id = user.Id.Value, Email = user.Email, Sid = sessionToken, Roles = user.Roles };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(currentUser.ToClaims()),
                // Nuestro token va a durar un día
                Expires = DateTime.UtcNow.AddMinutes(AuthenticationSettings.Expiration),
                // Credenciales para generar el token usando nuestro secretykey y el algoritmo hash 256
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            return tokenDescriptor;
        }

    }
}
