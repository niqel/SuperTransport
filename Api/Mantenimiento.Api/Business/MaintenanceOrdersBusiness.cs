using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using AuthenticationHandler.Business;
using System.Linq;
using ListdbTc.DAL.Models;
using IO.Swagger.Models;
using System;

namespace IO.Swagger.Business
{
    public class MaintenanceOrdersBusiness: BusinessBase
    {
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        public MaintenanceOrdersBusiness(TmsTcEntities context, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            ListdbTcContext = listdbTcContext;
        }

        public ObjectResult GetMaintenanceOrders(Status? status, DateTime? startDate)
        {
            string estado = GetEstado(status);
            var maintenanceOrders = ListdbTcContext.MttoOrden.AsQueryable();
            if (startDate.HasValue)
                maintenanceOrders = maintenanceOrders.Where(mo => mo.FechaInicio >= startDate);
            if (estado != null)
                maintenanceOrders = maintenanceOrders.Where(mo => mo.Estado == estado);
            return new OkObjectResult(maintenanceOrders.ToList());
        }

        private string GetEstado(Status? status)
        {
            switch (status)
            {
                case Status.Released: return "L";
                case Status.Closed: return "C";
                case Status.Open: return "A";
                case Status.Canceled: return "N";
                default: return null;
            }
        }
    }
}
