using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System.Linq;
using System;
using System.Collections.Generic;
using Viajes.Api.Enums;
using Viajes.Api.Enums.Metrics;
using ListdbTc.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Core.Api.Models;
using Core.Api.Enums.LoadPlans;

namespace IO.Swagger.Business
{
    public class LoadPlansBusiness : BusinessBase
    {
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        public LoadPlansBusiness(TmsTcEntities context, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            ListdbTcContext = listdbTcContext;
        }
        public ObjectResult GetOnlyTruckOperatorsMetrics(int? year, int? month)
        {
            var startDate = new DateTime(year.Value, month.Value, 1);
            DateTime endDate;
            if (year.Value == DateTime.Now.Year && month.Value == DateTime.Now.Month)
            {
                endDate = DateTime.Today;
            }
            else
            {
                endDate = startDate.AddMonths(1).AddDays(-1);
            }


            var conteoEnDB = (from dosh in Context.DailyOperatorStatusHistory
                              join os in Context.OperatorStatus on dosh.OperatorStatusid equals os.Id
                              where dosh.CreatedAt >= startDate && dosh.CreatedAt <= endDate
                              select dosh).ToList();


            List<OperatorsMetricsResult> lstOperatorsMetricsResults = new List<OperatorsMetricsResult>();
            for (DateTime fechaActual = startDate; fechaActual <= endDate; fechaActual = fechaActual.AddDays(1))
            {
                OperatorsMetricsResult operatorsMetricsResultActual = new OperatorsMetricsResult();
                operatorsMetricsResultActual.fecha = fechaActual;

                List<Core.Api.Models.OperatorStatus> lstOperatorStatus = new List<Core.Api.Models.OperatorStatus>();

                Core.Api.Models.OperatorStatus operatorStatusNoDisponible = new Core.Api.Models.OperatorStatus();
                operatorStatusNoDisponible.estatus = Context.OperatorStatus.Where(x => x.Id == (int)OperatorStatusEnum.NoDisponible).Select(y => y.Name).FirstOrDefault();
                operatorStatusNoDisponible.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.OperatorStatusid == (int)OperatorStatusEnum.NoDisponible).Select(x => x.Id).Count();
                operatorStatusNoDisponible.idEstatus = (int)OperatorStatusEnum.NoDisponible;
                lstOperatorStatus.Add(operatorStatusNoDisponible);

                Core.Api.Models.OperatorStatus operatorStatusEnOficina = new Core.Api.Models.OperatorStatus();
                operatorStatusEnOficina.estatus = Context.OperatorStatus.Where(x => x.Id == (int)OperatorStatusEnum.EnOficina).Select(y => y.Name).FirstOrDefault();
                operatorStatusEnOficina.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.OperatorStatusid == (int)OperatorStatusEnum.EnOficina).Select(x => x.Id).Count();
                operatorStatusEnOficina.idEstatus = (int)OperatorStatusEnum.EnOficina;
                lstOperatorStatus.Add(operatorStatusEnOficina);

                Core.Api.Models.OperatorStatus operatorStatusEnViaje = new Core.Api.Models.OperatorStatus();
                operatorStatusEnViaje.estatus = Context.OperatorStatus.Where(x => x.Id == (int)OperatorStatusEnum.EnViaje).Select(y => y.Name).FirstOrDefault();
                operatorStatusEnViaje.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.OperatorStatusid == (int)OperatorStatusEnum.EnViaje).Select(x => x.Id).Count();
                operatorStatusEnViaje.idEstatus = (int)OperatorStatusEnum.EnViaje;
                lstOperatorStatus.Add(operatorStatusEnViaje);

                Core.Api.Models.OperatorStatus operatorStatusSinEquipo = new Core.Api.Models.OperatorStatus();
                operatorStatusSinEquipo.estatus = Context.OperatorStatus.Where(x => x.Id == (int)OperatorStatusEnum.SinEquipo).Select(y => y.Name).FirstOrDefault();
                operatorStatusSinEquipo.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.OperatorStatusid == (int)OperatorStatusEnum.SinEquipo).Select(x => x.Id).Count();
                operatorStatusSinEquipo.idEstatus = (int)OperatorStatusEnum.SinEquipo;
                lstOperatorStatus.Add(operatorStatusSinEquipo);

                Core.Api.Models.OperatorStatus operatorStatusEnDescanso = new Core.Api.Models.OperatorStatus();
                operatorStatusEnDescanso.estatus = Context.OperatorStatus.Where(x => x.Id == (int)OperatorStatusEnum.EnDescanso).Select(y => y.Name).FirstOrDefault();
                operatorStatusEnDescanso.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.OperatorStatusid == (int)OperatorStatusEnum.EnDescanso).Select(x => x.Id).Count();
                operatorStatusEnDescanso.idEstatus = (int)OperatorStatusEnum.EnDescanso;
                lstOperatorStatus.Add(operatorStatusEnDescanso);

                Core.Api.Models.OperatorStatus operatorStatusLiquidando = new Core.Api.Models.OperatorStatus();
                operatorStatusLiquidando.estatus = Context.OperatorStatus.Where(x => x.Id == (int)OperatorStatusEnum.Liquidando).Select(y => y.Name).FirstOrDefault();
                operatorStatusLiquidando.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.OperatorStatusid == (int)OperatorStatusEnum.Liquidando).Select(x => x.Id).Count();
                operatorStatusLiquidando.idEstatus = (int)OperatorStatusEnum.Liquidando;
                lstOperatorStatus.Add(operatorStatusLiquidando);

                operatorsMetricsResultActual.operatorStatuses = lstOperatorStatus;
                lstOperatorsMetricsResults.Add(operatorsMetricsResultActual);
            }
            return new OkObjectResult(lstOperatorsMetricsResults);
        }

        public ObjectResult GetLoadPlansMetrics(int? year, int? month)
        {
            var startDate = new DateTime(year.Value, month.Value, 1);
            var endDate = startDate.AddMonths(1);
            string[] truckTypes = Enum.GetNames(typeof(TruckTypes));
            var trucks = Context.Truck.Where(t => t.Active == true && (t.TruckTypeNavigation.Active == true && truckTypes.Contains(t.TruckTypeNavigation.Name))).Include(t => t.CalendarTruck).ToList();
            var trucksInMaintenance = ListdbTcContext.MttoOrden.Where(mo => (mo.Estado == "A" && mo.FechaPrometida > startDate && mo.FechaPrometida < endDate) || (mo.Estado == "L" && mo.FechaLiberacion > startDate && mo.FechaLiberacion < endDate)).ToList();

            //var truckOperators = Context.TruckOperator.Where(t => t.Active == true).Include(to => to.Employee.CalendarEmployee).ToList();

            var truckOperators = Context.Operator.Where(t => t.Active == true).Include(to => to.Employee.CalendarEmployee).ToList();

            var loadPlan = Context.LoadPlan.Where(lp => lp.Date >= startDate && lp.Date < endDate)
                .OrderBy(lp => lp.Date)
                .GroupBy(lp => lp.Date)
                .Select(lp => new LoadPlansMetrics
                {
                    Date = lp.Key,
                    Trucks = new TrucksMetrics()
                    {
                        Required = lp.Sum(s => s.VinsPlanned),
                        Positioned = lp.Sum(s => s.VinsPositioned),
                        Loaded = lp.Sum(s => s.VinsLoaded),
                        NoScheduledLoad = lp.Sum(s => s.VinsPositioned) - lp.Sum(s => s.VinsLoaded),
                        LoadedVsForecast = GetLoadedVsForecast(lp.Sum(s => s.VinsLoaded), lp.Sum(s => s.VinsPlanned)),
                        LoadedVsFleet = lp.Sum(s => s.VinsLoaded) * 1.0f / trucks.Count()
                    },
                    Fleet = GetFleetMetrics(trucks, trucksInMaintenance, lp.Key),
                    TruckOperators = GetTruckOperatorsMetrics(truckOperators, lp.Key)
                }).ToList();
            return new OkObjectResult(loadPlan);
        }

        public ObjectResult GetOnlyLoadPlansMetrics(int? year, int? month) 
        {
            var startDate = new DateTime(year.Value, month.Value, 1);
            var endDate = startDate.AddMonths(1);
            string[] truckTypes = Enum.GetNames(typeof(TruckTypes));
            var trucks = Context.Truck.Where(t => t.Active == true && (t.TruckTypeNavigation.Active == true && truckTypes.Contains(t.TruckTypeNavigation.Name))).Include(t => t.CalendarTruck).ToList();
            var trucksInMaintenance = ListdbTcContext.MttoOrden.Where(mo => (mo.Estado == "A" && mo.FechaPrometida > startDate && mo.FechaPrometida < endDate) || (mo.Estado == "L" && mo.FechaLiberacion > startDate && mo.FechaLiberacion < endDate)).ToList();

            //var truckOperators = Context.TruckOperator.Where(t => t.Active == true).Include(to => to.Employee.CalendarEmployee).ToList();
            var truckOperators = Context.Operator.Where(t => t.Active == true).Include(to => to.Employee.CalendarEmployee).ToList();

            var loadPlan = Context.LoadPlan.Where(lp => lp.Date >= startDate && lp.Date < endDate)
                .OrderBy(lp => lp.Date)
                .GroupBy(lp => lp.Date)
                .Select(lp => new LoadPlansMetrics
                {
                    Date = lp.Key,
                    Trucks = new TrucksMetrics()
                    {
                        Required = lp.Sum(s => s.VinsPlanned),
                        Positioned = lp.Sum(s => s.VinsPositioned),
                        Loaded = lp.Sum(s => s.VinsLoaded),
                        NoScheduledLoad = lp.Sum(s => s.VinsPositioned) - lp.Sum(s => s.VinsLoaded),
                        LoadedVsForecast = GetLoadedVsForecast(lp.Sum(s => s.VinsLoaded), lp.Sum(s => s.VinsPlanned)),
                        LoadedVsFleet = lp.Sum(s => s.VinsLoaded) * 1.0f / trucks.Count()
                    }
                }).ToList();
            return new OkObjectResult(loadPlan);
        }

        public ObjectResult GetOnlyFleetMetrics(int? year, int? month)
        {
            var startDate = new DateTime(year.Value, month.Value, 1);
            DateTime endDate;
            if (year.Value == DateTime.Now.Year && month.Value == DateTime.Now.Month)
            {
                endDate = DateTime.Today;
            }
            else
            {
                endDate = startDate.AddMonths(1).AddDays(-1);
            }

            var conteoEnDB = (from dtsh in Context.DailyTruckStatusHistory
                              join ts in Context.TruckStatus on dtsh.TruckStatusid equals ts.Id
                              where dtsh.CreatedAt >= startDate && dtsh.CreatedAt <= endDate
                              select dtsh).ToList();

            List<TrucksMetricsResult> lstTrucksMetricsResultActual = new List<TrucksMetricsResult>();
            for (DateTime fechaActual = startDate; fechaActual <= endDate; fechaActual = fechaActual.AddDays(1))
            {
                TrucksMetricsResult trucksMetricsResultActual = new TrucksMetricsResult();
                trucksMetricsResultActual.fecha = fechaActual;

                List<Core.Api.Models.TruckStatus> lstTruckStatus = new List<Core.Api.Models.TruckStatus>();

                Core.Api.Models.TruckStatus truckStatusActivo = new Core.Api.Models.TruckStatus();
                truckStatusActivo.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Activo).Select(y => y.Name).FirstOrDefault();
                truckStatusActivo.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Activo).Select(x => x.Id).Count();
                truckStatusActivo.idEstatus = (int)TruckStatusEnum.Activo;
                lstTruckStatus.Add(truckStatusActivo);

                Core.Api.Models.TruckStatus truckStatusInactivo = new Core.Api.Models.TruckStatus();
                truckStatusInactivo.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Inactivo).Select(y => y.Name).FirstOrDefault();
                truckStatusInactivo.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Inactivo).Select(x => x.Id).Count();
                truckStatusInactivo.idEstatus = (int)TruckStatusEnum.Inactivo;
                lstTruckStatus.Add(truckStatusInactivo);

                Core.Api.Models.TruckStatus truckStatusPosicionado = new Core.Api.Models.TruckStatus();
                truckStatusPosicionado.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Posicionado).Select(y => y.Name).FirstOrDefault();
                truckStatusPosicionado.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Posicionado).Select(x => x.Id).Count();
                truckStatusPosicionado.idEstatus = (int)TruckStatusEnum.Posicionado;
                lstTruckStatus.Add(truckStatusPosicionado);

                Core.Api.Models.TruckStatus truckStatusCargando = new Core.Api.Models.TruckStatus();
                truckStatusCargando.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Cargando).Select(y => y.Name).FirstOrDefault();
                truckStatusCargando.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Cargando).Select(x => x.Id).Count();
                truckStatusCargando.idEstatus = (int)TruckStatusEnum.Cargando;
                lstTruckStatus.Add(truckStatusCargando);

                Core.Api.Models.TruckStatus truckStatusViaje = new Core.Api.Models.TruckStatus();
                truckStatusViaje.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Viaje).Select(y => y.Name).FirstOrDefault();
                truckStatusViaje.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Viaje).Select(x => x.Id).Count();
                truckStatusViaje.idEstatus = (int)TruckStatusEnum.Viaje;
                lstTruckStatus.Add(truckStatusViaje);

                Core.Api.Models.TruckStatus truckStatusDescargando = new Core.Api.Models.TruckStatus();
                truckStatusDescargando.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Descargando).Select(y => y.Name).FirstOrDefault();
                truckStatusDescargando.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Descargando).Select(x => x.Id).Count();
                truckStatusDescargando.idEstatus = (int)TruckStatusEnum.Descargando;
                lstTruckStatus.Add(truckStatusDescargando);

                Core.Api.Models.TruckStatus truckStatusRegreso = new Core.Api.Models.TruckStatus();
                truckStatusRegreso.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Regreso).Select(y => y.Name).FirstOrDefault();
                truckStatusRegreso.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Regreso).Select(x => x.Id).Count();
                truckStatusRegreso.idEstatus = (int)TruckStatusEnum.Regreso;
                lstTruckStatus.Add(truckStatusRegreso);

                Core.Api.Models.TruckStatus truckStatusTaller = new Core.Api.Models.TruckStatus();
                truckStatusTaller.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Taller).Select(y => y.Name).FirstOrDefault();
                truckStatusTaller.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Taller).Select(x => x.Id).Count();
                truckStatusTaller.idEstatus = (int)TruckStatusEnum.Taller;
                lstTruckStatus.Add(truckStatusTaller);

                Core.Api.Models.TruckStatus truckStatusAccidente = new Core.Api.Models.TruckStatus();
                truckStatusAccidente.estatus = Context.TruckStatus.Where(x => x.Id == (int)TruckStatusEnum.Accidente).Select(y => y.Name).FirstOrDefault();
                truckStatusAccidente.cantidad = conteoEnDB.Where(f => f.CreatedAt.Date == fechaActual && f.TruckStatusid == (int)TruckStatusEnum.Accidente).Select(x => x.Id).Count();
                truckStatusAccidente.idEstatus = (int)TruckStatusEnum.Accidente;
                lstTruckStatus.Add(truckStatusAccidente);

                trucksMetricsResultActual.truckStatuses = lstTruckStatus;
                lstTrucksMetricsResultActual.Add(trucksMetricsResultActual);
            }

            return new OkObjectResult(lstTrucksMetricsResultActual);
        }


        private static float GetLoadedVsForecast(int? vinsLoaded, int? vinsPlanned)
        {
            if (vinsPlanned == 0 || vinsPlanned == null)
                return 0;
            else
                return (float)(vinsLoaded * 1.0f / vinsPlanned);
        }

        public static FleetMetrics GetFleetMetrics(List<TmsTcAPI.DAL.Models.Truck> trucksOriginal, List<MttoOrden> trucksInMaintenance, DateTime date)
        {
            var trucks = trucksOriginal.Where(t => t.CreatedAt < date).ToList();

            var fleetMetrics = new FleetMetrics
            {
                Total = trucks.Count()
            };

            var trucksInManteinanceFilteredByDate = trucksInMaintenance.Where(tim => (tim.Estado == "A" && tim.FechaPrometida > date) || (tim.Estado == "L" && tim.FechaLiberacion > date)).Select(tim => tim.IdUnidad).Distinct();
            fleetMetrics.Maintenance = trucks.Where(t => trucksInManteinanceFilteredByDate.Contains(t.Name)).Count();

            fleetMetrics.Available = trucks.Where(t => true == TruckAvaliable(t, date)).Count();
            fleetMetrics.NotAvailable = fleetMetrics.Total - fleetMetrics.Available;
            fleetMetrics.Accident = trucks.Where(t => (int)Core.Api.Enums.LoadPlans.TruckAvailability.Accident == t.CalendarTruck.Where(ta => ta.Date <= date).OrderByDescending(ta => ta.Date).Select(ta => ta.CTruckUnavailableReasonTypeid).FirstOrDefault()).Count();
            fleetMetrics.Available = fleetMetrics.Available - fleetMetrics.Maintenance;

            return fleetMetrics;
        }

        //public static TruckOperatorsMetrics GetTruckOperatorsMetrics(List<TruckOperator> truckOperatorsOriginal, DateTime date)
        public static TruckOperatorsMetrics GetTruckOperatorsMetrics(List<Operator> truckOperatorsOriginal, DateTime date)
        {
            var truckOperators = truckOperatorsOriginal.Where(t => t.CreatedAt < date).ToList();

            var truckOperatorMetrics = new TruckOperatorsMetrics
            {
                Total = truckOperators.Count(),

                Available = truckOperators.Where(t => true == TruckOperatorAvaliable(t, date)).Count(),

                Disabled = truckOperators.Where(to => (int)Core.Api.Enums.LoadPlans.EmployeeAvailability.Disabled == to.Employee.CalendarEmployee.Where(ea => ea.Date <= date).OrderByDescending(ea => ea.Date).Select(ea => ea.CEmployeeUnavailableReasonTypeid).FirstOrDefault()).Count(),

                SpecialPermission = truckOperators.Where(to => (int)Core.Api.Enums.LoadPlans.EmployeeAvailability.SpecialPermission == to.Employee.CalendarEmployee.Where(ea => ea.Date <= date).OrderByDescending(ea => ea.Date).Select(ea => ea.CEmployeeUnavailableReasonTypeid).FirstOrDefault()).Count(),

                Vacation = truckOperators.Where(to => (int)Core.Api.Enums.LoadPlans.EmployeeAvailability.Vacation == to.Employee.CalendarEmployee.Where(ea => ea.Date <= date).OrderByDescending(ea => ea.Date).Select(ea => ea.CEmployeeUnavailableReasonTypeid).FirstOrDefault()).Count(),

                WorkBreak = truckOperators.Where(to => (int)Core.Api.Enums.LoadPlans.EmployeeAvailability.WorkBreak == to.Employee.CalendarEmployee.Where(ea => ea.Date <= date).OrderByDescending(ea => ea.Date).Select(ea => ea.CEmployeeUnavailableReasonTypeid).FirstOrDefault()).Count()
            };

            return truckOperatorMetrics;
        }


        private static bool TruckAvaliable(TmsTcAPI.DAL.Models.Truck t, DateTime date)
        {
            var avail = t.CalendarTruck.Where(ta => ta.Date <= date).OrderByDescending(ta => ta.Date).FirstOrDefault();
            if (avail == null)
                return true;
            else return avail.Available.Value;
        }

        public ObjectResult GetFechaUltimaActualizacion()
        {
            DateTime fecha = Context.LoadPlan.Max(lp => lp.UpdatedAt);
            UltimaFechaActualizacionResult ultAct = new UltimaFechaActualizacionResult()
            {
                Fecha = String.Concat(fecha.Date.Year.ToString(), "-", fecha.Date.Month < 10 ? "0" + fecha.Date.Month.ToString() : fecha.Date.Month.ToString()
                , "-", fecha.Date.Day < 10 ? "0" + fecha.Date.Day.ToString() : fecha.Date.Day.ToString())
            };
            return new ObjectResult(ultAct);
        }

        private static bool TruckOperatorAvaliable(Operator to, DateTime date)
        {
            //var avail = to.Employee.CalendarEmployee.Where(ta => ta.Date <= date).OrderByDescending(ta => ta.Date).FirstOrDefault();
            var avail = to.Employee.CalendarEmployee.Where(ta => ta.Date <= date).OrderByDescending(ta => ta.Date).FirstOrDefault();

            if (avail == null)
                return true;
            else return avail.Available.Value;
        }

    }
}
