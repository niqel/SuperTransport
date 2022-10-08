using AuthenticationHandler.Business;
using CrmTc.DAL.Models;
using InnovaLinks.DAL.Models;
using IO.Swagger.Models;
using ListdbTc.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;

namespace Viajes.Api.Business
{
    public class SalaryBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        protected TmsTcEntities TmsContext { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
        public SalaryBusiness(TmsTcEntities context, CrmTcEntities crmContext, InnovaLinksEntities innovaLinksContext, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            ListdbTcContext = listdbTcContext;
            TmsContext = context;
        }
        public ObjectResult GetSalary()
        {
            return new ObjectResult(null);
        }
    }
}
