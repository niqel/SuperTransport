using TmsTcAPI.DAL.Models;
using CrmTcAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using Core.Api.BLL.Business;
using System.Collections.Generic;
using AuthenticationHandler.Business;
using IO.Swagger.Models;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace IO.Swagger.Business
{
    public class SystemParametersBusiness : BusinessBase
    {
        public SystemParametersBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetSystemParameters()
        {
            var respuesta = new AdminSistemaBusiness(Context).ObtenerParametrosSistema();
            if (respuesta.Data is List<ParametroSistemaCustom>)
            {
                var parametrosSistema = respuesta.Data as List<ParametroSistemaCustom>;
                return new OkObjectResult(parametrosSistema);
            }

            else
                throw new Exception(respuesta.Mensaje);
        }

        public ObjectResult GetSystemParameterHistory(string modulo, string nombre)
        {
            if (modulo.Contains('.'))
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Modulo Incorrecto", Detail = "El modulo no puede contener el carácter punto (.)" });
            if (nombre.Contains('.'))
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Nombre Incorrecto", Detail = "El nombre no puede contener el carácter punto (.)" });

            string parametro = modulo + "." + nombre;
            var respuesta = new AdminSistemaBusiness(Context).ObtenerParametroSistemaHistory(parametro);
            if (respuesta.Data is List<ParametroSistemaHistoryCustom>)
            {
                var historialParametroSistema = respuesta.Data as List<ParametroSistemaHistoryCustom>;

                List<HistoryRecord> history = new List<HistoryRecord>();

                foreach (var historico in historialParametroSistema)
                {
                    if (historico.actual != historico.nuevo || historico.nuevo == "Se cambió la contraseña")
                    {
                        var historyRecord = new HistoryRecord();
                        historyRecord.Previous.Add("Valor", historico.actual);
                        historyRecord.Current.Add("Valor", historico.nuevo);
                        historyRecord.Date = historico.fechaMovimiento;
                        historyRecord.User = historico.usuario;
                        history.Add(historyRecord);
                    }
                }

                return new OkObjectResult(history);
            }
            else
                throw new Exception(respuesta.Mensaje);
        }

        public ObjectResult UpdateSystemParameter(ParametroSistemaCustom parametro)
        {
            if (parametro.modulo.Contains('.'))
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Modulo Incorrecto", Detail = "El modulo no puede contener el carácter punto (.)" });
            if (parametro.nombre.Contains('.'))
                return new BadRequestObjectResult(new ProblemDetails() { Status = 400, Title = "Nombre Incorrecto", Detail = "El nombre no puede contener el carácter punto (.)" });
            var respuesta = new AdminSistemaBusiness(Context).ActualizaParametroSistema(CurrentUser.Id, parametro.modulo+"."+parametro.nombre, parametro.valor, parametro.orden, parametro.longitud, parametro.password);
            if(respuesta.Mensaje == string.Empty)
                return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El parametro del sistema fue actualizado correctamente" });
            else
                throw new Exception(respuesta.Mensaje);
        }
    }
}
