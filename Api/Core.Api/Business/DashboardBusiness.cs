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
using ListdbTc.DAL.Models;

namespace Core.Api.Business
{
    public class DashboardBusiness : BusinessBase
    {
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        public DashboardBusiness(TmsTcEntities context, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            ListdbTcContext = listdbTcContext;
        }

        public ObjectResult GetForecastVsReal(DateTime? startDate, DateTime? endDate)
        {

            var forecastVsReal = (from lp in Context.LoadPlan
                                  where lp.Date >= startDate.Value.Date && lp.Date <= endDate.Value.Date
                                  orderby lp.Date
                                  select new
                                  {
                                      market_type = lp.MarketType,
                                      customer = lp.Customer,
                                      office = lp.Office,
                                      date = lp.Date,
                                      vins_planned = lp.VinsPlanned,
                                      vins_loaded = lp.VinsLoaded,
                                      vins_positioned = lp.VinsPositioned
                                  }).ToList();
            return new OkObjectResult(forecastVsReal);
        }

        public ObjectResult GetLoadedVsEmpty(DateTime? startDate, DateTime? endDate)
        {
            var loadedVsEmpty = (from dtsh in Context.DailyTruckStatusHistory
                                 join tf in Context.Trips on dtsh.Truckid equals tf.Truck into temp
                                 from tf in temp.DefaultIfEmpty()
                                 join t in Context.Truck on dtsh.Truckid equals t.Id
                                 join ot in Context.Operator on t.Id equals ot.Truckid into temp2
                                 from ot in temp2.DefaultIfEmpty()
                                 join e in Context.Employee on ot.Employeeid equals e.Id into temp4
                                 from e in temp4.DefaultIfEmpty()
                                 where dtsh.CreatedAt.Date >= startDate.Value.Date && dtsh.CreatedAt.Date <= endDate.Value.Date
                                 group dtsh by new
                                 {
                                     CreatedAt = dtsh.CreatedAt.Date,
                                     TruckStatusid = dtsh.TruckStatusid,
                                     Truckid = dtsh.Truckid,
                                     Name = t.Name,
                                     Description = t.Description,
                                     GivenName = e.GivenName,
                                     tf.Truck
                                 } into grupo
                                 select new
                                 {
                                     fecha = grupo.Key.CreatedAt.Date,
                                     truck_statusid = grupo.Key.TruckStatusid,
                                     truckid = grupo.Key.Truckid,
                                     cargado = grupo.Key.Truck.ToString() == null ? "No" : "Yes",
                                     name = grupo.Key.Name,
                                     description = grupo.Key.Description,
                                     given_name = grupo.Key.GivenName
                                 }).ToList();
            return new OkObjectResult(loadedVsEmpty);
        }
    }
}
