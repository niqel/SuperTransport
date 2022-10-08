using AuthenticationHandler.Business;
using CrmTc.DAL.Models;
using InnovaLinks.DAL.Models;
using IO.Swagger.Models;
using ListdbTc.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using NotificationService.Business;
using NotificationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;

namespace Viajes.Api.Business
{
    public class NotificationBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        protected TmsTcEntities TmsContext { get; private set; }
        protected OneSignalCredentials OneSignal { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
        public NotificationBusiness(TmsTcEntities context, CrmTcEntities crmContext, InnovaLinksEntities innovaLinksContext, ListdbTcEntities listdbTcContext, OneSignalCredentials oneSignal, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            ListdbTcContext = listdbTcContext;
            TmsContext = context;
            OneSignal = oneSignal;
        }        

        public ObjectResult UpdateNotification(LocationType type)
        {
            return new ObjectResult(null);
        }

        public ObjectResult SendNotificationEmail()
        {
            NotificationServiceBusiness notification = new NotificationServiceBusiness(Context, CrmContext);            
            return new ObjectResult(notification.EnviarCorreo("joncanizales@gmail.com"));
        }

        public ObjectResult SendNotification(LocationType type)
        {
            return new ObjectResult(null);
        }

        public ObjectResult GetNotificationStatus()
        {
            return new ObjectResult(null);
        }

        public ObjectResult GetNotification(LocationType type)
        {
            return new ObjectResult(null);
        }

        public ObjectResult CreateNotification(LocationType type)
        {
            return new ObjectResult(null);
        }

        public async Task<ObjectResult> SendNotificationAsync()
        {
            NotificationSenderBusiness sender = new NotificationSenderBusiness(OneSignal);
            // Implementación demostrativa
            var tokens = new string[] { "", "" };            
            return new ObjectResult(await NotificationSenderBusiness.Send(tokens, "title", "body", 0));
        }
    }
}
