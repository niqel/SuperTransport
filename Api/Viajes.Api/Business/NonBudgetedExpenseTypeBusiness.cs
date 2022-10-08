using AuthenticationHandler.Business;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;

namespace Viajes.Api.Business
{
    public class NonBudgetedExpenseTypeBusiness : BusinessBase
    {
        protected TmsTcEntities TmsContext { get; private set; }
        public NonBudgetedExpenseTypeBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
            TmsContext = context;
        }


        public ObjectResult GetAllNonBudgetedExpenseType()
        {
            RNonBudgetedExpenseType rNonBudgetedExpenseType = new RNonBudgetedExpenseType();
            rNonBudgetedExpenseType.Data = new RNonBudgetedExpenseTypeData();
            rNonBudgetedExpenseType.Data.NonBudgetedExpenseType = new List<NonBudgetedExpenseType>();

            var entityNonBudgetedExpenseType = TmsContext.CNonBudgetedExpenseType.ToList();
            

            foreach (var entity in entityNonBudgetedExpenseType)
            {
                NonBudgetedExpenseType nonBudgetedExpenseType = new NonBudgetedExpenseType
                {
                    Id = entity.Id,
                    Name = entity.Description
                };
                rNonBudgetedExpenseType.Data.NonBudgetedExpenseType.Add(nonBudgetedExpenseType);
            }

            rNonBudgetedExpenseType.Reply = new Reply();

            if (rNonBudgetedExpenseType.Data.NonBudgetedExpenseType.Count > 0)
            {
                rNonBudgetedExpenseType.Reply.Code = 200;
                rNonBudgetedExpenseType.Reply.Message = "Registros encontrados";
            }
            else
            {
                rNonBudgetedExpenseType.Reply.Code = 200;
                rNonBudgetedExpenseType.Reply.Message = "Registros No encontrados";
            }

            return new ObjectResult(rNonBudgetedExpenseType);
        }
    }
}
