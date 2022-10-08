using AuthenticationHandler.Business;
using CrmTc.DAL.Models;
using IO.Swagger.Models;
using ListdbTc.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;
using Survey = TmsTcAPI.DAL.Models.Survey;

namespace Viajes.Api.Business
{
    public class SurveyBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        protected TmsTcEntities TmsContext { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
        public SurveyBusiness(TmsTcEntities context, CrmTcEntities crmContext, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            ListdbTcContext = listdbTcContext;
            TmsContext = context;
        }

        public ObjectResult CreateSurvey(Survey survey)
        {
            return new ObjectResult(null);
        }

        public ObjectResult GetSurvey(int? id)
        {
            return new ObjectResult(null);
        }

        /* Agrega a la BD la respuesta de una encuesta 
         */
        public ObjectResult AnswerSurvey(Answer survey)
        {
            var answer = TmsContext.Answers.Where(a => a.GastoNoPresupuestadoid == survey.NonBudgetedExpenseId.Value).FirstOrDefault();
            if (answer != null)
                TmsContext.Answers.Remove(answer);

            TmsContext.Answers.Add(new Answers
            {
                Answers1 = survey.Answers,
                GastoNoPresupuestadoid = survey.NonBudgetedExpenseId.Value,
                CreatedAt = DateTime.Now,
                CreatedBy = CurrentUser.Id
            });
            TmsContext.SaveChanges();
            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizado Correctamente", Detail = "La encuesta fue contestada correctamente" });
        }

        public ObjectResult GetQualifications()
        {
            throw new NotImplementedException();
        }
    }
}
