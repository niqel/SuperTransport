using AuthenticationHandler.Business;
using CrmTcAPI.Models;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using TmsTcAPI.DAL.Models;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace IO.Swagger.Business
{
    public class UsersBusiness : BusinessBase
    {
        public UsersBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }


        public User GetUser(param_idusuario usuario)
        {
            return new User
            {
                Id = usuario.idUsuario,
                Name = usuario.NombreUsuario,
                GivenName = usuario.Nombre,
                PaternalSurname = usuario.ApellidoPaterno,
                MaternalSurname = usuario.ApellidoMaterno,
                Email = usuario.Correo,
                Image = usuario.Imagen,
                RoleId = usuario.RolId,
                Roles = usuario.Rol.Split(", ").ToList(),
                Active = true,
                CreatedBy = 0,
                CreatedAt = DateTime.Now,
                UpdatedBy = 0,
                UpdatedAt = DateTime.Now,
                IsFirstLogin = usuario.isFirstLogin
            };
        }

        public User GetUser(Usuarios usuario)
        {
            var empleado = (from e in Context.Employee where e.Id == usuario.Id select e).FirstOrDefault();

            var groups = Context.RolesUsuarios.Where(gu => gu.UsuariosId == usuario.Id).Select(gu => (int?)gu.Rolesid).ToList();
            return new User
            {
                Id = usuario.Id,
                // Name = empleado.GivenName
                Email = usuario.Password,
                RoleId = 0,
                Active = usuario.Active,
                CreatedBy = usuario.CreatedBy,
                CreatedAt = usuario.CreatedAt,
                UpdatedBy = usuario.UpdatedBy,
                UpdatedAt = usuario.UpdatedAt
            };
        }

        public Usuarios GetUsuario(User usuario, string password)
        {
            var empleado = (from e in Context.Employee where e.Id == usuario.Id select e).FirstOrDefault();
            return new Usuarios
            {
                //Nombre = empleado.GivenName
                Password = usuario.Email,
                Active = usuario.Active.Value,
                CreatedBy = usuario.CreatedBy.Value,
                UpdatedBy = usuario.UpdatedBy.Value
            };
        }

        public ObjectResult GetUserTypes()
        {
            var userTypes = Context.Roles.OrderBy(tu => tu.Id).Select(
                tu => new UserTypes {Id = tu.Id, Name = tu.Nombre, Active = true}
            ).ToList();
            return new OkObjectResult(userTypes);
        }

        public ObjectResult GetUser(int id)
        {
            var usuario = Context.Usuarios.Where(u => u.Id == id).FirstOrDefault();

            if (usuario == null)
            {
                var problem = new ProblemDetails
                {
                    Title = "Usuario no encontrado",
                    Detail = "El usuario especificado no existe"
                };
                return new NotFoundObjectResult(problem);
            }

            var user = GetUser(usuario);
            return new OkObjectResult(user);
        }

        public ObjectResult DeleteUser(int id)
        {
            var usuario = Context.Usuarios.Where(u => u.Id == id).FirstOrDefault();

            if (usuario == null)
            {
                var problem = new ProblemDetails
                {
                    Title = "Usuario no encontrado",
                    Detail = "El usuario especificado no existe"
                };
                return new NotFoundObjectResult(problem);
            }

            if (usuario.Active == false)
            {
                var problem = new ProblemDetails
                {
                    Title = "Usuario ya desactivado",
                    Detail = "El usuario especificado ya se encuentra deshabilitado"
                };
                return new BadRequestObjectResult(problem);
            }

            usuario.Active = false;
            Context.SaveChanges();

            var user = GetUser(usuario);
            return new OkObjectResult(user);
        }

        public ObjectResult CreateUser(User user, string password)
        {
            var usuario = GetUsuario(user, password);

            var usuarios = Context.Set<Usuarios>();
            usuarios.Add(usuario);

            Context.SaveChanges();

            return new OkObjectResult(GetUser(usuario));
        }

        public ObjectResult GetOperatorProfileById(int? id)
        {

            var operatorProfile = (from usu in Context.Usuarios
                                   join emp in Context.Employee on usu.Employeeid equals emp.Id
                                   join ope in Context.Operator on emp.Id equals ope.Employeeid
                                   join tru in Context.Truck on ope.Truckid equals tru.Id
                                   where usu.Id == id.Value
                                   select new OperatorProfileData()
                                   {
                                       PersonalInformation = new PersonalInformation() {
                                           Email = emp.Email,
                                           GivenName = emp.GivenName,
                                           PicturePath = emp.Picture,
                                           Birthday = emp.Birthday,
                                           EntryDate = emp.EntryDate
                                       },
                                       OperatorInformation = new OperatorInformation()
                                       {
                                           IdOperator = ope.Id,
                                           Rating = ope.Rating,
                                           Truck = tru.Name,
                                           Towing = (from tow in Context.Towing
                                                     where tow.Truckid == tru.Id
                                                     select tow.Name).ToList()
                                       }    
                                   }).FirstOrDefault();


            if (operatorProfile == null)
            {

                var response = new OperatorProfile() {
                    Code = 200,
                    Message = "Datos del pefil operador no encontrados",
                    Data = null
                };

                return new ObjectResult(response);
            } else
            {
                var response = new OperatorProfile()
                {
                    Code = 200,
                    Message = "Success",
                    Data = operatorProfile
                };
                return new ObjectResult(response);
            }
        }

        //public ObjectResult UpdateContraseña(int idUser, string password)
        //{
        //    var usuario = (from u in Context.Usuarios
        //                   where u.Id == idUser
        //                   select u).FirstOrDefault();
        //    usuario.Password = password;
        //    bool result = false;
        //    try
        //    {
        //        Context.SaveChanges();
        //        result = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //    }
        //    return new ObjectResult(result);
        //}

        public ObjectResult UpdateContraseña(int idUser, PasswordIdBody passwordIdBody)
        {
            var usuario = (from u in Context.Usuarios
                           where u.Id == idUser
                           select u).FirstOrDefault();

            if (usuario == null)
            {
                var response = new UserUpdatePassword()
                {
                    Code= 200,
                    Message = "Usuario no encontrado",
                    Data = null
                };
                
                return new OkObjectResult(response);
            }
            else
            {
                usuario.Password = passwordIdBody.Password;
                Context.SaveChanges();

                var response = new UserUpdatePassword() { 
                    Code= 200,
                    Message = "Su password ha sido actualizado", 
                    Data = new UserUpdatePasswordData() { Result = true } 
                };
                
                return new OkObjectResult(response);
            }
        }



    }
}
