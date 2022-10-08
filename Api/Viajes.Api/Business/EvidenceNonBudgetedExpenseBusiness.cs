using AuthenticationHandler.Business;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using EvidenceNonBudgetedExpense = IO.Swagger.Models.EvidenceNonBudgetedExpense;

namespace Viajes.Api.Business
{
    public class EvidenceNonBudgetedExpenseBusiness : BusinessBase
    {
        protected TmsTcEntities TmsContext { get; private set; }
        public EvidenceNonBudgetedExpenseBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
            TmsContext = context;
        }

        public CreatedId EvidenceNonBudgetedExpense(EvidenceNonBudgetedExpense evidenceNonBudgetedExpense)
        {
            TmsTcAPI.DAL.Models.EvidenceNonBudgetedExpense entityEvidenceNonBudgetedExpense = new TmsTcAPI.DAL.Models.EvidenceNonBudgetedExpense();
            entityEvidenceNonBudgetedExpense.Guid = evidenceNonBudgetedExpense.Guid.Value;
            entityEvidenceNonBudgetedExpense.Active = true;
            entityEvidenceNonBudgetedExpense.NonBudgetedExpenseId = Convert.ToInt32(evidenceNonBudgetedExpense.IdNonBudgetedExpense);
            entityEvidenceNonBudgetedExpense.CreatedBy = -1;// CurrentUser.Id;
            entityEvidenceNonBudgetedExpense.CreatedAt = DateTime.Now;
            entityEvidenceNonBudgetedExpense.UpdatedAt = DateTime.Now;
            entityEvidenceNonBudgetedExpense.UpdatedBy = -1;// CurrentUser.Id;
            entityEvidenceNonBudgetedExpense.UpdatedAt = DateTime.Now;

            this.TmsContext.Add(entityEvidenceNonBudgetedExpense);
            this.TmsContext.SaveChanges();

            CreatedId createdId = new CreatedId();
            createdId.Id = entityEvidenceNonBudgetedExpense.Id;
            return createdId;
        }

        public ObjectResult GetEvidencesByIdBudgetedExpense(int? idNonBudgetedExpense)
        {
            REvidenceNonBudgetedExpense rEvidenceNonBudgetedExpense = new REvidenceNonBudgetedExpense();
            rEvidenceNonBudgetedExpense.Data = new REvidenceNonBudgetedExpenseData();
            rEvidenceNonBudgetedExpense.Data.EvidenceNonBudgetedExpense = new List<EvidenceNonBudgetedExpense>();

            rEvidenceNonBudgetedExpense.Data.EvidenceNonBudgetedExpense = (from evi in TmsContext.EvidenceNonBudgetedExpense
                             where evi.NonBudgetedExpenseId == idNonBudgetedExpense
                             select new IO.Swagger.Models.EvidenceNonBudgetedExpense()
                             {
                                 IdNonBudgetedExpense = idNonBudgetedExpense,
                                 Guid = evi.Guid
                             }).ToList();

            rEvidenceNonBudgetedExpense.Reply = new Reply();

            if (rEvidenceNonBudgetedExpense.Data.EvidenceNonBudgetedExpense.Count > 0)
            {
                rEvidenceNonBudgetedExpense.Reply.Code = 200;
                rEvidenceNonBudgetedExpense.Reply.Message = "Registros encontrados";
            }
            else
            {
                rEvidenceNonBudgetedExpense.Reply.Code = 200;
                rEvidenceNonBudgetedExpense.Reply.Message = "Registros No encontrados";
            }

            return new ObjectResult(rEvidenceNonBudgetedExpense);
        }
    }
}
