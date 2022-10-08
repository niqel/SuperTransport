using TmsTcAPI.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using AuthenticationHandler.Business;
using IO.Swagger.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace IO.Swagger.Business
{
    public class GeneralParametersBusiness : BusinessBase
    {
        public GeneralParametersBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetGeneralParameters()
        {
            var general_parameters = Context.GeneralParameters.Where(gp => gp.Active == true).OrderBy(gp => gp.Module).ThenBy(gp => gp.Name).ThenBy(gp => gp.Order).Select(gp => new GeneralParameter
            {
                Id = gp.Id,
                Module = gp.Module,
                Name = gp.Name,
                Description = gp.Description,
                Regex = gp.Regex,
                Order = gp.Order,
                Value = gp.Value,
                Active = gp.Active,
                CreatedBy = gp.CreatedBy,
                CreatedAt = gp.CreatedAt,
                UpdatedBy = gp.UpdatedBy,
                UpdatedAt = gp.UpdatedAt
            }).ToList();
            return new OkObjectResult(general_parameters);
        }

        public ObjectResult UpdateGeneralParameter(int id, GeneralParameter body)
        {
            var generalParameter = Context.GeneralParameters.Where(p => p.Id == id).FirstOrDefault();
            if (generalParameter == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrado", Detail = "El parámetro general especificado no existe" });

            generalParameter.Id = body.Id;
            generalParameter.Module = body.Module;
            generalParameter.Name = body.Name;
            generalParameter.Description = body.Description;
            generalParameter.Regex = body.Regex;
            generalParameter.Order = body.Order;
            generalParameter.Value = body.Value;
            generalParameter.Active = body.Active;
            generalParameter.UpdatedBy = CurrentUser.Id;
            generalParameter.UpdatedAt = DateTime.UtcNow.AddHours(-6);

            var generalParameterHistory = new GeneralParametersHistory()
            {
                Active = generalParameter.Active,
                Module = generalParameter.Module,
                Name = generalParameter.Name,
                Description = generalParameter.Description,
                Regex = generalParameter.Regex,
                Order = generalParameter.Order,
                Value = generalParameter.Value,
                CreatedBy = generalParameter.UpdatedBy
            };

            generalParameter.GeneralParametersHistory.Add(generalParameterHistory);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "El parámetro general fue actualizado correctamente" });
        }

        public ObjectResult GetGeneralParameterHistory(int id)
        {
            var general_parameter_history = Context.GeneralParametersHistory.Where(gp => gp.GeneralParameterId == id).Include(gp => gp.CreatedByNavigation).OrderByDescending(gp => gp.CreatedAt).ToList();
            List<HistoryRecord> history = new List<HistoryRecord>();
            for (var i = 0; i < general_parameter_history.Count - 1; i++)
            {
                var previous = general_parameter_history[i + 1];
                var current = general_parameter_history[i];

                HistoryRecord historyRecord = new HistoryRecord();

                if (previous.Module != current.Module)
                {
                    historyRecord.Previous.Add("Modulo", previous.Module);
                    historyRecord.Current.Add("Modulo", current.Module);
                }

                if (previous.Name != current.Name)
                {
                    historyRecord.Previous.Add("Nombre", previous.Name);
                    historyRecord.Current.Add("Nombre", current.Name);
                }

                if (previous.Description != current.Description)
                {
                    historyRecord.Previous.Add("Descripcion", previous.Description);
                    historyRecord.Current.Add("Descripcion", current.Description);
                }

                if (previous.Regex != current.Regex)
                {
                    historyRecord.Previous.Add("Regex", previous.Regex);
                    historyRecord.Current.Add("Regex", current.Regex);
                }

                if (previous.Order != current.Order)
                {
                    historyRecord.Previous.Add("Orden", previous.Order);
                    historyRecord.Current.Add("Orden", current.Order);
                }

                if (previous.Value != current.Value)
                {
                    historyRecord.Previous.Add("Valor", previous.Value);
                    historyRecord.Current.Add("Valor", current.Value);
                }

                if (current.Active == false)
                {
                    historyRecord.Current.Add("Estatus", "Eliminado");
                }

                historyRecord.Date = current.CreatedAt;
                historyRecord.User = current.CreatedByNavigation.Password;

                if (historyRecord.Previous != historyRecord.Current)
                    history.Add(historyRecord);
            }
            if (general_parameter_history.Count > 0)
            {
                var nuevo = general_parameter_history[general_parameter_history.Count - 1];
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
