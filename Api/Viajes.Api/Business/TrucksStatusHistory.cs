using AuthenticationHandler.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;
using CrmTc.DAL.Models;

namespace Viajes.Api.Business
{
    public class TrucksStatusHistoryBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }

        public TrucksStatusHistoryBusiness(TmsTcEntities tmsTcEntities, ClaimsPrincipal user) : base(tmsTcEntities, user)
        {

        }
        public TrucksStatusHistoryBusiness(TmsTcEntities tmsTcEntities, CrmTcEntities crmContext) : base(tmsTcEntities)
        {
            CrmContext = crmContext;
        }

        public List<IO.Swagger.Models.TrucksStatusHistory> GetTruckStatusHistoryPosicionates(DateTime date, int OfficeId, int MarketTypeId)
        {
            // Tractores posicionados en la oficina
            List<IO.Swagger.Models.TrucksStatusHistory> queryTrucksStatusHistory;
            queryTrucksStatusHistory = (from itemA in Context.TruckStatusHistory
                                        join itemB in Context.Truck on itemA.TruckId equals itemB.Id
                                        join itemC in Context.TruckType on itemB.TruckType equals itemC.Id
                                        where itemA.PositionedDate == date.Date && itemA.OfficeAssigned == OfficeId && itemA.MarketTypeId == MarketTypeId
                                        select new IO.Swagger.Models.TrucksStatusHistory()
                                        {
                                            Id = itemA.TruckId,
                                            Name = itemB.Name,
                                            Year = itemB.Year,
                                            Bran = itemB.Brand,
                                            TypeTractor = new TypeTruck()
                                            {
                                                Id = itemB.TruckType,
                                                Name = itemC.Name
                                            }
                                        }).ToList();

            return queryTrucksStatusHistory;
        }

        public List<IO.Swagger.Models.TrucksStatusHistory> GetTruckStatusHistoryLoaded(DateTime date, int officeId, int marketTypeId)
        {
            // Oficinas operativas
            var oficinas = (from o in CrmContext.Oficinas
                            join op in CrmContext.OficinasOperativas on o.Id equals op.Oficinasid
                            select new OficinasOperativas { 
                                Id = (int) o.IdOficinaZam,
                                Oficinasid = op.Id
                            }
                            ).ToList();
            int origenId = oficinas.Where(o => o.Oficinasid == officeId).FirstOrDefault().Id;

            if (origenId == null)
                return new List<TrucksStatusHistory>();

            // Viajes que se hayan puesto en tránsito para un día, origen, tipo de mercado específico
            var queryTrucksStatusHistory = (from tp in Context.Trips
                                            join tl in Context.TripsLog on tp.Id equals tl.Tripsid
                                            join tr in Context.Truck on tp.Truck equals tr.Id
                                            join ty in Context.TruckType on tr.TruckType equals ty.Id
                                            where tl.CreatedAt.Date == date.Date && tp.Origin == origenId && tp.MarketType == marketTypeId && tl.TripsStatusid == 3 // Transito
                                            select new IO.Swagger.Models.TrucksStatusHistory()
                                            {
                                                Id = tp.Truck,
                                                Name = tr.Name,
                                                Year = tr.Year,
                                                Bran = tr.Brand,
                                                TypeTractor = new TypeTruck()
                                                {
                                                    Id = tr.TruckType,
                                                    Name = ty.Name
                                                }
                                            }).ToList();

            return queryTrucksStatusHistory;
        }

        public void UpdatePositionedTruckHistory()
        {
            DateTime? beforeDate = DateTime.Today.AddDays(-1);

            var truckHistories = (from item in Context.TruckStatusHistory
                                  where item.PositionedDate == beforeDate
                                  select new TruckStatusHistory()
                                  {
                                      TruckId = item.TruckId,
                                      ArrivalTime = item.ArrivalTime,
                                      PositionedDate = DateTime.Now,
                                      MarketType = item.MarketType,
                                      OfficeAssigned = item.OfficeAssigned,
                                      TruckStatusId = item.TruckStatusId
                                  });
            Context.AddRange(truckHistories);

            Context.SaveChanges();
            LogSps logSps = new LogSps()
            {
                FechaHora = DateTime.Now,
                Sp = @"/trucks-status-history"
            };
            Context.LogSps.Add(logSps);
            Context.SaveChanges();
        }
    }





}
