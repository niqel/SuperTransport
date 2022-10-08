using TmsTcAPI.DAL.Models;
using CrmTcAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using Core.Api.BLL.Business;
using System.Collections.Generic;
using AuthenticationHandler.Business;
using IO.Swagger.Models;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace IO.Swagger.Business
{
    public class PermissionsBusiness : BusinessBase
    {
        public PermissionsBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult ObtenerPermisos(int role, int? module, int? functionality)
        {
            var respuesta = new AutenticacionBusiness(Context).ObtenerPermisosFuncionalidadesRol(role);
            if (respuesta.Data is List<PermisosRol>)
            {
                var permisosRol = respuesta.Data as List<PermisosRol>;

                if (module != null)
                    permisosRol = permisosRol.Where(p => p.idModulo == module.Value).ToList();

                if (functionality != null)
                    permisosRol = permisosRol.Where(p => p.idFuncionalidad == functionality.Value).ToList();

                return new OkObjectResult(permisosRol);
            }

            else
                throw new Exception(respuesta.Mensaje);
        }


        public ObjectResult ObtenerPermisosUsuario(int id)
        {
            var roles = Context.RolesUsuarios.Where(ur => ur.UsuariosId == id).Select(ur => ur.Rolesid).ToArray();
            var permisos = Context.VwRolesFuncionalidadesPermisos
                .Where(p => roles.Contains(p.IdRol))
                .GroupBy(p => new { p.IdModulo, p.Modulo, p.IdFuncionalidad, p.Funcionalidad, p.FuncionalidadPadre })
                .Select(p => new PermisosUsuario
                    {
                        usuariosId = id,
                        idModulo = p.Key.IdModulo,
                        nombreModulo = p.Key.Modulo,
                        descripcionModulo = p.Key.Modulo,
                        idFuncionalidad = p.Key.IdFuncionalidad,
                        nombreFuncionalidad = p.Key.Funcionalidad,
                        Leer = p.Max(m => m.Leer)>0,
                        Escribir = p.Max(m => m.Escribir) > 0,
                        Ejecutar = p.Max(m => m.Ejecutar) > 0,
                }).ToList();
            return new OkObjectResult(permisos);
        }

        public ObjectResult GetPermissionHistory(int id)
        {
            var respuesta = new AdminSistemaBusiness(Context).ObtenerPermisosHistory(id);
            if (respuesta.Data is List<PermisosHistoryCustom>)
            {
                var historialPermiso = respuesta.Data as List<PermisosHistoryCustom>;

                List<HistoryRecord> history = new List<HistoryRecord>();

                foreach(var historico in historialPermiso)
                {
                    if(historico.actual != historico.nuevo)
                    {
                        var historyRecord = new HistoryRecord();
                        historyRecord.Previous.Add("Permisos", historico.actual);
                        historyRecord.Current.Add("Permisos", historico.nuevo);
                        historyRecord.Date = historico.fechaMovimiento.Value;
                        historyRecord.User = historico.usuario;
                        history.Add(historyRecord);
                    }   
                }

                return new OkObjectResult(history);
            }
            else
                throw new Exception(respuesta.Mensaje);
        }

        public ObjectResult AddPermission(PermisosRol permisoModificado)
        {
            var permiso = new Permisos();

            permiso.IdFuncionalidad = permisoModificado.idFuncionalidad;
            permiso.R = permisoModificado.Leer;
            permiso.W = permisoModificado.Escribir;
            permiso.X = permisoModificado.Ejecutar;
            permiso.Active = true;
            permiso.CreatedBy = CurrentUser.Id;
            permiso.CreatedAt = DateTime.UtcNow.AddHours(-6);
            permiso.UpdatedBy = CurrentUser.Id;
            permiso.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.Permisos.Add(permiso);

            Context.SaveChanges();

            var rolesPermisos = new RolesPermisos() { IdPermiso = permiso.Id, IdRol = permisoModificado.rolesId};

            Context.RolesPermisos.Add(rolesPermisos);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Agregado Correctamente", Detail = "El permiso fue agregado correctamente" });
        }

        public ObjectResult UpdatePermission(PermisosRol permisoModificado)
        {
            if (permisoModificado.idPermiso == null)
                return AddPermission(permisoModificado);
            
            var permiso = Context.Permisos.Where(p => p.Id == permisoModificado.idPermiso).FirstOrDefault();
            if (permiso == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El permiso especificado no existe"});

            var respuesta = new AdminSistemaBusiness(Context).ActualizarPermisos(CurrentUser.Id, permisoModificado.idPermiso.ToString(), permisoModificado.Leer, permisoModificado.Escribir, permisoModificado.Ejecutar);
            if(respuesta.Mensaje == string.Empty)
                return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El permiso fue actualizado correctamente" });
            else
                throw new Exception(respuesta.Mensaje);
        }

        public ObjectResult DeletePermission(int id)
        {
            var permiso = Context.Permisos.Where(p => p.Id == id).FirstOrDefault();
            if (permiso == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El permiso especificado no existe" });

            if(permiso.Active == false)
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Eliminado anteriormente", Detail = "El permiso especificado ya había sido eliminado" });

            permiso.Active = false;
            permiso.UpdatedBy = CurrentUser.Id;
            permiso.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Eliminado Correctamente", Detail = "El permiso fue eliminado correctamente" });
        }
    }
}
