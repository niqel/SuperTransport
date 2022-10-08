using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace IO.Swagger.Business
{
    public class RolesBusiness: BusinessBase
    {
        public RolesBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetRoles()
        {
            var roles = Context.Roles.Where(r => r.Active == true).Select(r => new Role {
                Id = r.Id,
                Name = r.Nombre,
                Description = r.Descripcion,
                IdActiveDirectory = r.IdActiveDirectory,
                Active = r.Active,
                CreatedBy = r.CreatedBy,
                CreatedAt = r.CreatedAt,
                UpdatedBy = r.UpdatedBy,
                UpdatedAt = r.UpdatedAt
            }).ToList();
            return new OkObjectResult(roles);
        }

        public ObjectResult AddRole(Role body)
        {
            var role = new Roles();

            role.Nombre = body.Name;
            role.Descripcion = body.Description;
            role.IdActiveDirectory = body.IdActiveDirectory;
            role.Active = true;
            role.CreatedBy = CurrentUser.Id;
            role.CreatedAt = DateTime.UtcNow.AddHours(-6);
            role.UpdatedBy = CurrentUser.Id;
            role.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            var roleHistory = new RolesHistory()
            {
                Active = role.Active,
                Nombre = role.Nombre,
                Descripcion = role.Descripcion,
                IdActiveDirectory = role.IdActiveDirectory,
                CreatedBy = role.UpdatedBy
            };

            role.RolesHistory.Add(roleHistory);

            Context.Roles.Add(role);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Agregado Correctamente", Detail = "El rol fue agregado correctamente" });
        }

        public ObjectResult DeleteRole(int id)
        {
            var rol = Context.Roles.Where(p => p.Id == id).FirstOrDefault();
            if (rol == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El rol especificado no existe" });

            if (rol.Active == false)
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Eliminado anteriormente", Detail = "El rol especificado ya había sido eliminado" });

            var usuariosAsignados = Context.RolesUsuarios.Where(ur => ur.Rolesid == id).Count();
            if (usuariosAsignados > 0)
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "No se puede eliminar", Detail = "No se puede eliminar el rol "+rol.Nombre+", ya que está asignado a un usuario" });

            rol.Active = false;
            rol.UpdatedBy = CurrentUser.Id;
            rol.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            var roleHistory = new RolesHistory()
            {
                Active = rol.Active,
                Nombre = rol.Nombre,
                Descripcion = rol.Descripcion,
                IdActiveDirectory = rol.IdActiveDirectory,
                CreatedBy = rol.UpdatedBy
            };

            rol.RolesHistory.Add(roleHistory);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Eliminado Correctamente", Detail = "El rol fue eliminado correctamente" });
        }

        public ObjectResult UpdateRole(int id, Role body)
        {
            var role = Context.Roles.Where(p => p.Id == id).FirstOrDefault();
            if (role == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El rol especificado no existe" });

            var usuariosAsignados = Context.RolesUsuarios.Where(ur => ur.Rolesid == id).Count();
            if (usuariosAsignados > 0)
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "No se puede modificar", Detail = "No se puede editar el rol "+role.Nombre+", ya que está asignado a un usuario" });

            role.Id = body.Id.Value;
            role.IdActiveDirectory = body.IdActiveDirectory;
            role.Nombre = body.Name;
            role.Descripcion = body.Description;
            role.UpdatedBy = CurrentUser.Id;
            role.UpdatedAt = DateTime.UtcNow.AddHours(-6);


            var roleHistory = new RolesHistory()
            {
                Active = role.Active,
                Nombre = role.Nombre,
                Descripcion = role.Descripcion,
                IdActiveDirectory = role.IdActiveDirectory,
                CreatedBy = role.UpdatedBy
            };

            role.RolesHistory.Add(roleHistory);

            Context.SaveChanges();
            
            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El rol fue actualizado correctamente" });
        }

        public ObjectResult GetRoleHistory(int id)
        {
            var roles = Context.RolesHistory.Where(r => r.RoleId == id).Include(r => r.CreatedByNavigation). OrderByDescending(r => r.CreatedAt).ToList();
            List <HistoryRecord> history = new List<HistoryRecord>();
            for (var i = 0; i < roles.Count - 1; i++)
            {
                var previous = roles[i+1];
                var current = roles[i];

                HistoryRecord historyRecord = new HistoryRecord();

                if(previous.Nombre != current.Nombre)
                {
                    historyRecord.Previous.Add("Nombre", previous.Nombre);
                    historyRecord.Current.Add("Nombre", current.Nombre);
                }

                if (previous.Descripcion != current.Descripcion)
                {
                    historyRecord.Previous.Add("Descripcion", previous.Descripcion);
                    historyRecord.Current.Add("Descripcion", current.Descripcion);
                }

                if (previous.IdActiveDirectory != current.IdActiveDirectory)
                {
                    historyRecord.Previous.Add("IdActiveDirectory", previous.IdActiveDirectory);
                    historyRecord.Current.Add("IdActiveDirectory", current.IdActiveDirectory);
                }

                if(current.Active == false)
                {
                    historyRecord.Current.Add("Estatus", "Eliminado");
                }

                historyRecord.Date = current.CreatedAt;
                historyRecord.User = current.CreatedByNavigation.Password;

                if(historyRecord.Previous != historyRecord.Current)
                    history.Add(historyRecord);
            }
            if(roles.Count>0)
            {
                var nuevo = roles[roles.Count-1];
                HistoryRecord historyRecord = new HistoryRecord();

                historyRecord.Current.Add("Estatus", "Creado");
                historyRecord.Date = nuevo.CreatedAt;
                historyRecord.User = nuevo.CreatedByNavigation.Password;
                history.Add(historyRecord);
            }


            return new OkObjectResult(history);
        }
    }
}
