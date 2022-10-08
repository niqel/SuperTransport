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

namespace Viajes.Api.Business
{
    public class TechnicalSupportBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        protected TmsTcEntities TmsContext { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
        public TechnicalSupportBusiness(TmsTcEntities context, CrmTcEntities crmContext, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            ListdbTcContext = listdbTcContext;
            TmsContext = context;
        }

        public ObjectResult UpdateSupportRestorePassword(LocationType type)
        {
            return new ObjectResult(null);
        }

        public ObjectResult UpdateSupportPassword(LocationType type)
        {
            return new ObjectResult(null);
        }
    }
}
