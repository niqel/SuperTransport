using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System.Linq;
using System.Collections.Generic;
using CrmTc.DAL.Models;
using ListdbTc.DAL.Models;
using InnovaLinks.DAL.Models;
using System;
using ClosedXML.Excel;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Truck = TmsTcAPI.DAL.Models.Truck;
using Viajes.Api.Configuration;
using TravelPlansConfiguration = Viajes.Api.Configuration.TravelPlansConfiguration;
using Viajes.Api.Extensions;
using Trips = TmsTcAPI.DAL.Models.Trips;
using Viajes.Api.Business;
using Viajes.Api.Models;
using Viajes.Api.Enums.LoadPlans;
using Viajes.Api.Common;

namespace IO.Swagger.Business
{
    public class TravelPlansBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected InnovaLinksEntities InnovaLinksContext { get; private set; }
        protected ListdbTcEntities ListdbTcContext { get; private set; }
        protected TmsTcEntities TmsContext { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
        public TravelPlansBusiness(TmsTcEntities context, CrmTcEntities crmContext, InnovaLinksEntities innovaLinksContext, ListdbTcEntities listdbTcContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            InnovaLinksContext = innovaLinksContext;
            ListdbTcContext = listdbTcContext;
            TmsContext = context;
        }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private List<TravelPlan> TravelPlans { get; set; }
        private List<Office> Oficinas { get; set; }
        //private List<TruckOperator> OperadoresActivos { get; set; }
        //private List<OperatorTruck> OperadoresActivos { get; set; }
        private List<TmsTcAPI.DAL.Models.Operator> OperadoresActivos { get; set; }

        private List<TmsTcAPI.DAL.Models.Truck> TractoresActivos { get; set; }
        private List<Models.LoadPlan> PlanesDeCarga { get; set; }
        private List<TblTiemposBitacora> BitacoraOperadores { get; set; }
        private List<Models.InternalTransfer> MovimientosInterOficina { get; set; }
        private List<Models.Forecast> Forecasts { get; set; }
        private List<Models.Truck> TractoresActualizados { get; set; }
        private Dictionary<TruckCostIndex, TravelCost> TruckCosts { get; set; }
        private TravelPlansConfiguration ParametrosConfiguracion { get; set; }
        private List<MttoOrden> OrdenesMantenimiento { get; set; }
        private List<Office> Talleres { get; set; }
        private List<NivelesCombustibleActuales> NivelesCombustibleActuales { get; set; }
        private List<DistanciasRegresos> DistanciasRegresos { get; set; }
        private List<TrafficPlan> ViajesActuales { get; set; }
        public class TruckCostIndex : IEquatable<TruckCostIndex>
        {
            public Models.Truck Truck { get; set; }
            public Office Office { get; set; }

            public bool Equals(TruckCostIndex other)
            {
                return (Truck.Id == other.Truck.Id && Office.Location.Id == other.Office.Location.Id);
            }
        }
        public ObjectResult PostTravelPlans(DateTime? startDate, DateTime? endDate)
        {
            if (startDate.HasValue)
            {
                StartDate = startDate.Value;
            }

            else
            {
                return new BadRequestObjectResult(new ProblemDetails { Status = 400, Title = "Fecha Inválida", Detail = "La fecha de inicio es obligatoria" });
            }


            if (endDate.HasValue)
            {
                EndDate = endDate.Value;
            }

            else
            {
                return new BadRequestObjectResult(new ProblemDetails { Status = 400, Title = "Fecha Inválida", Detail = "La fecha final es obligatoria" });
            }
                

            RealizaPlanDeCarga();

            return LoadPlansBusiness.UpdateLoadPlans(Context, CurrentUser, LoadPlansBusiness.UpdateLoadPlans(TmsContext), StartDate, EndDate);
        }
        public ObjectResult GetTravelPlans(DateTime? startDate, DateTime? endDate)
        {
            if (startDate.HasValue)
                StartDate = startDate.Value;
            else
                return new BadRequestObjectResult(new ProblemDetails { Status = 400, Title = "Fecha Inválida", Detail = "La fecha de inicio es obligatoria" });

            if (endDate.HasValue)
                EndDate = endDate.Value;
            else
                return new BadRequestObjectResult(new ProblemDetails { Status = 400, Title = "Fecha Inválida", Detail = "La fecha final es obligatoria" });

            RealizaPlanDeCarga();
            return new OkObjectResult(TravelPlans);
        }
        public IActionResult DownloadTravelPlans(DateTime? startDate, DateTime? endDate)
        {
            var travelPlansResult = GetTravelPlans(startDate, endDate);
            if (travelPlansResult is OkObjectResult)
            {
                return GetExcel();
            } else
            {
                return travelPlansResult;
            }
        }

        private FileContentResult GetExcel()
        {
            var workbook = new XLWorkbook();
            AddTravelPlansSheet(workbook, "TravelPlans");
            AddTruckCostsSheet(workbook, "TruckCosts");

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return new FileContentResult(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            }
        }

        private void AddTravelPlansSheet(XLWorkbook workbook, string sheetName)
        {
            IXLWorksheet worksheet = workbook.Worksheets.Add(sheetName);

            worksheet.Cell(2, 2).Value = "Oficinas";

            for (int officeIndex = 0; officeIndex < Oficinas.Count; officeIndex++)
            {
                var nameCell = worksheet.Cell(officeIndex + 3, 1);
                nameCell.Value = Oficinas[officeIndex].Location.Name;
                var lat = Oficinas[officeIndex].Location.Coordinates.Latitude;
                var lng = Oficinas[officeIndex].Location.Coordinates.Longitude;
                nameCell.Hyperlink = new XLHyperlink(@"http://www.google.com/maps/place/" + lat + "," + lng);
                worksheet.Cell(officeIndex + 3, 2).Value = Oficinas[officeIndex].Location.Id;
            }

            for (int dateIndex = 0; dateIndex < TravelPlans.Count; dateIndex++)
            {
                var initialCell = worksheet.Cell(1, 3 + dateIndex * 4);
                var endCell = worksheet.Cell(1, 3 + dateIndex * 4 + 3);
                initialCell.Value = TravelPlans[dateIndex].Date;
                initialCell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Range(initialCell, endCell).Merge();

                worksheet.Cell(2, 3 + dateIndex * 4).Value = "D";
                worksheet.Cell(2, 3 + dateIndex * 4 + 1).Value = "P";
                worksheet.Cell(2, 3 + dateIndex * 4 + 2).Value = "A";
                worksheet.Cell(2, 3 + dateIndex * 4 + 3).Value = "C";

                for (int officeIndex = 0; officeIndex < TravelPlans[dateIndex].OfficePlans.Count; officeIndex++)
                {
                    worksheet.Cell(officeIndex + 3, 3 + dateIndex * 4).Value = TravelPlans[dateIndex].OfficePlans[officeIndex].TrucksPlan.Demand.Sum(d => d.Demand);
                    worksheet.Cell(officeIndex + 3, 3 + dateIndex * 4 + 1).Value = TravelPlans[dateIndex].OfficePlans[officeIndex].TrucksPlan.Positioned.Count;
                    worksheet.Cell(officeIndex + 3, 3 + dateIndex * 4 + 2).Value = TravelPlans[dateIndex].OfficePlans[officeIndex].TrucksPlan.Arrivals.Count;
                    worksheet.Cell(officeIndex + 3, 3 + dateIndex * 4 + 3).Value = (TravelPlans[dateIndex].OfficePlans[officeIndex].TrucksPlan.Completed == true) ? "Si" : "No";
                }
            }

        }

        private void AddTruckCostsSheet(XLWorkbook workbook, string sheetName)
        {
            IXLWorksheet worksheet = workbook.Worksheets.Add(sheetName);
            
            worksheet.Cell(4, 2).Value = "Tractor";
            worksheet.Cell(4, 3).Value = "Oficina";
            worksheet.Cell(4, 4).Value = "Fecha";

            // Selecciona todos los registros diferentes que tengan en comun su Nombre de tractor y su Id de Ubicación
            var trucksId = TruckCosts.GroupBy(g => new { g.Key.Truck.Name, g.Key.Office.Location.Id })
                .OrderBy(o => o.Key.Name)
                .Select(g => g.First())
                .Distinct()
                .ToList();

            // Agrupa en listas de elementos por fecha (Ascendente)
            var datesGroup = TruckCosts
                .GroupBy(u => u.Value.Arrival)
                .OrderBy(u => u.ElementAt(0).Value.Arrival)
                .Select(grp => grp.ToList())
                .ToList();

            int indexX = 4;
            int indexY = 4;
            int truckIdControl = 0;
            for (int trucksIndex = 0; trucksIndex < trucksId.Count(); trucksIndex++)
            {
                // Si el valor del id del tractor cambia, redibuja encabezado con fechas
                if (truckIdControl != (int)trucksId[trucksIndex].Key.Truck.Id)
                {
                    truckIdControl = (int)trucksId[trucksIndex].Key.Truck.Id;
                    indexX = 4;
                    indexY++;
                    foreach (var date in datesGroup)
                    {
                        worksheet.Cell(indexY, indexX).Value = date[0].Value.Arrival;
                        indexX++;
                    }
                    indexY++;
                }
                // Por cada fecha existente, busca un registro TravelCost que coincida con el Id del tractor y el Id de ubicación actual
                for (int datesIndex = 0; datesIndex < datesGroup.Count(); datesIndex++)
                {
                    var cost = datesGroup[datesIndex].Where(d => d.Key.Truck.Id == trucksId[trucksIndex].Key.Truck.Id
                                               && d.Key.Office.Location.Id == trucksId[trucksIndex].Key.Office.Location.Id).FirstOrDefault().Value;
                    worksheet.Cell(indexY, datesIndex + 4).Value = cost != null ? cost.Cost : null;
                }
                worksheet.Cell(indexY, 2).Value = trucksId.ElementAt(trucksIndex).Key.Truck.Name;
                worksheet.Cell(indexY, 3).Value = trucksId.ElementAt(trucksIndex).Key.Office.Location.Name;
                indexY++;
            }
            worksheet.Columns().AdjustToContents();
        }



        // El algoritmo empieza a partir de esta línea


        // que sean configurables los siguientes parámetros:
        // 1. Distancias.
        // 2. tomar en cuenta costos: casetas + combustible
        // 3. Tomar en cuenta tiempos
        // ¡WARNING!: se tiene que hacer un calendario de operadores que:por fecha (día exacto) se pueda poner como disponible / no disponible. Lo que noss permitirá:
        // 1. que cuando se deshabiklite manualmente, se podrá elegir día(s) en los que no estará disponible.
        // 2. Por vacaciones.
        // 3. Por permisos.

        // debe proveerse de una funcionalidad en la que el usuario deshabilite a un operador, y acorde al catálogo lo marque en su calendario los días que se indiquen.

        private void RealizaPlanDeCarga()
        {
            InicializaProcesoDePlaneacion();
            ActualizarInformacionOperadoresConBitacora();
            ActualizaCalendarioDeCargaOficinas();
            ActualizaInformacionDeTractores();
            CalculaRegresosDeViajesActuales();
            // DistribuyeRegresosCalculadosAOficinasAcordeADemanda();

        }

        private void InicializaProcesoDePlaneacion()
        {
            ObtieneOficinas(); //Por dependencia las oficinas ya deben estar cargadas antes de inicializar el plan de viajes.
            ObtieneForecasts(); //Por dependencia de la demanda de las oficinas ya deben estar cargadas antes de inicializar el plan de viajes.
            Inicializa();
            ObtienePlanActualDeCarga();
            ObtieneParametrosDeConfiguracion();
            ObtieneRegresos();
            ObtieneMovimientosInterOficina();
            ObtieneViajesActuales();
            ObtieneOperadores();
            ObtieneTractores();
            ObtieneDatosTalleres();
            ObtieneOrdenesMantenimiento();
        }

        /// <summary>
        /// inicializa todos los objetos necesarios.
        /// </summary>
        private void Inicializa()
        {
            InicializaPlanDeViajes();
        }

        /// <summary>
        /// inicializa el resultado del algoritmo, debe correrse despues de cargar las oficinas
        /// </summary>
        private void InicializaPlanDeViajes()
        {
            TravelPlans = new List<TravelPlan>();

            foreach (DateTime day in EachDay(StartDate, EndDate))
            {
                var travelPlan = new TravelPlan
                {
                    Date = day,
                    OfficePlans = GetOfficePlans(day)
                };
                TravelPlans.Add(travelPlan);
            };
        }

        /// <summary>
        /// i.e.: BR para el límite para cambiar un regreso.
        /// </summary>
        private void ObtieneParametrosDeConfiguracion()
        {
            ParametrosConfiguracion = new TravelPlansConfiguration().SetTravelPlansConfiguration(TmsContext);
        }

        /// <summary>
        /// [D]: datos de la necesidad de carga por día que ya se tienen planeados en las oficinas.
        /// </summary>
        private void ObtieneForecasts()
        {
            Forecasts = ForecastsBusiness.GetForecasts(Context, StartDate, EndDate, false);
        }

        /// <summary>
        /// [D]: datos de la necesidad de carga por día que ya se tienen planeados en las oficinas.
        /// </summary>
        private void ObtienePlanActualDeCarga()
        {
            PlanesDeCarga = LoadPlansBusiness.GetLoadPlans(Context, StartDate, EndDate);
        }

        /// <summary>
        /// Obtiene todos los regresos posibles para las rutas
        /// </summary>
        private void ObtieneRegresos()
        {
            DistanciasRegresos = CrmContext.DistanciasRegresos.Include(dr => dr.Oficinas).Include(dr => dr.Destinos).ToList();
        }

        /// <summary>
        /// [br]: solo los autorizados, y que no hayan sido ya incluidos en el plan (nota: cuando un movimiento interoficina ya se agregue al plan, ponerlo en estatus terminado)
        /// [D]: tractor, operador, día de salida, origen, destino.
        /// </summary>
        private void ObtieneMovimientosInterOficina()
        {
            MovimientosInterOficina = InternalTransfersBusiness.GetInternalTransfers(Context);
        }

        /// <summary>
        /// [D]: id, status[iniciado, cancelado, aDestino, deRegreso, finalizado, cerrado], tractor, operador, día de salida, origen, destino, regreso calculado, ubicación actual.
        /// kilometrajeOrigenDestino, kilometrajeDestinoRegreso, kilometrajeActual
        /// Modelar la máquina de estados de viaje.
        /// </summary>
        private void ObtieneViajesActuales()
        {
            //GMV -Pendiente
            //ViajesActuales = (from t in TmsContext.Trips
            //                  where t.Active == true
            //                  select new TrafficPlan()
            //                  {
            //                      Id = t.Id,
            //                      Destination = t.D

            //                  }).ToList();

            //ViajesActuales = TmsContext.Trips.Where(tp => tp.Active == true).ToList();
        }

        /// <summary>
        /// [br]: todos los activos (disponibles, de vacaciones, inhabilitado temporalmente).
        /// [D]: id, nombre, tractor id, calificacionDelMes, disponibilidad.
        /// [ToDo]: se debe modelar bien la máquina de estados.
        /// </summary>
        private void ObtieneOperadores()
        {
            //OperadoresActivos = Context.TruckOperator.Where(to => to.Active).Include(to => to.Employee.CalendarEmployee).ToList();

            //OperadoresActivos = Context.OperatorTruck.Where(to => to.Operator.Active).Include(to => to.Operator.Employee.CalendarEmployee).ToList();
            OperadoresActivos = Context.Operator.Where(to => to.Active).Include(to => to.Employee.CalendarEmployee).ToList();

        }

        /// <summary>
        /// [br]: solo los que están dentro de la flota activa (esto incluye los que están en taller)
        /// [D]: tractor id, nombre, kilometraje actual, geoposición, tipo de madrina.
        /// [todo]: se dene modelar la máquina de estados.
        /// </summary>
        private void ObtieneTractores()
        {
            TractoresActivos = Context.Truck.Where(t => t.Active && t.TruckStatusNavigation.Name != "Inactivo" &&
                (
                    t.CalendarTruck.Count == 0 || t.CalendarTruck.OrderByDescending(ta => ta.Date).Select(ta => ta.Available.HasValue).FirstOrDefault()
                )
                ).ToList();//.Include(t => t.TruckOperatorTruck).ToList();
        }

        /// <summary>
        /// [D]: ubicación, capacidad máxima carga.
        /// </summary>
        private void ObtieneOficinas()
        {
            Oficinas = LocationsBusiness.GeLocations(CrmContext, LocationType.Office).Select(loc => new Office(loc, 8.5)).ToList();
        }

        /// <summary>
        /// [D]: ubicación.
        /// </summary>
        private void ObtieneDatosTalleres()
        {
            Talleres = Oficinas.Where(o => o.Location.Name == "MONTERREY, NL").ToList();
        }

        /// <summary>
        /// [D]: ubicación.
        /// </summary>
        private void ObtieneOrdenesMantenimiento()
        {
            OrdenesMantenimiento = ListdbTcContext.MttoOrden.Where( mo => mo.Estado == "A" && mo.FechaPrometida >= StartDate && mo.FechaPrometida <= EndDate).ToList();
        }

        private void ActualizarInformacionOperadoresConBitacora()
        {
            BitacoraOperadores = InnovaLinksContext.TblTiemposBitacora.Where(b => b.Fecha >= StartDate && b.Fecha <= EndDate).ToList();

            foreach (var operador in OperadoresActivos)
            {
                var bitacoraOperador = ObtieneBitacoraOperador(BitacoraOperadores, operador); //si no ha descansado el tiempo requerido.
                if (OperadorViolaReglaDeDescanso(bitacoraOperador))
                {
                    /*
                    se deshabilita por el tiempo que indica el catálogo de causas (de la cuausa falta de descanso)
                    */
                    ActualizaOperadoresANoDisponibles(operador);
                    ActualizaDisponibilidadDeTractores(operador);
                }
            }
        }


        private void ActualizaCalendarioDeCargaOficinas()
        {
            var oficinasDisponibilidad = CrmContext.OficinaDisponibilidad.Where(od => od.Active == true).ToList();
            foreach (Office oficina in Oficinas)
            {
                oficina.Availability = oficinasDisponibilidad.Where(od => od.IdOficina == oficina.Location.Id).ToList();
            }
            
        }

        private void ActualizaInformacionDeTractores()
        {
            TractoresActualizados = ObtenerTractoresActualizados();

            ActualizarRegresosTractores();

            //de los tractores activos:
            foreach (var tractor in TractoresActualizados)
            {
                /*
                Esta función deberá tomar en cuenta el kilometraje actual, + lo que está por realizar.
                Para que calcule su regreso a taller.
                */
                if (tractor.Status == ObtenerEstatusTractor("Activo"))
                { //está en oficina, o de viaje
                    CalculaSiTractorEstaProximoAMantenimiento(tractor);
                }
                else if (tractor.Status == ObtenerEstatusTractor("En taller"))
                {

                }
            }


            /*
                calcula la distancia a las oficinas que sí tienen petición de carga.
                debe tomar en cuenta los parámetros de tiempos y costos.
                actualiza la matriz de tractores con:
                por oficina con necesidad de carga: distancia, fecha de llegada, tiempos, costos.                
            */
            //debe hacer en base a la tabla de oficinas por día y su carga requeridad.
            //CalculaRutaAOficinas();
        }

        /*
debe actualizar dónde está el tractor. Y definir (quienes no están de viaje), si están en una oficina y cuál es, o están en un taller y cuál es.
*/
        private List<Models.Truck> ObtenerTractoresActualizados()
        {
            //var operadoresActivosId = OperadoresActivos.Select(oa => oa.Id);
            var operadoresActivosId = OperadoresActivos.Select(oa => oa.Id);
            TractoresActivos = TractoresActivos.Where(t => t.TruckStatus == (int)TruckStatusEnum.Viaje || t.TruckStatus == (int)TruckStatusEnum.Taller).ToList();
            NivelesCombustibleActuales = InnovaLinksContext.NivelesCombustibleActuales.ToList();
            return TractoresActivos.Select(ta => new Models.Truck
            {
                Id = ta.Id,
                Name = ta.Name,
                Active = ta.Active,
                CreatedAt = ta.CreatedAt,
                CreatedBy = ta.CreatedBy,
                Description = ta.Description,
                Position = ObtenerPosicionActual(NivelesCombustibleActuales, ta.Name, ta.TrackingId),
                Status = ta.TruckStatus,
                TrackingId = ta.TrackingId,
                Type = ta.TruckType,
                UpdatedAt = ta.UpdatedAt,
                UpdatedBy = ta.UpdatedBy
            }).ToList();
        }

        private void ActualizarRegresosTractores()
        {
            CalculateReturnBusiness calcularRegreso = new CalculateReturnBusiness(Context, CrmContext, User);
            Regreso regreso = new Regreso();
            var trips = Context.Trips.ToList();

            foreach (var tractor in TractoresActualizados)
            {

                // Busca en truck_plan_details y si cuenta con un registro, lo elimina
                var truckDetailsUpdate = Context.TruckPlanDetails.Where(tr => tr.Truckid == tractor.Id).FirstOrDefault();
                if (truckDetailsUpdate != null)
                    Context.TruckPlanDetails.Remove(truckDetailsUpdate);


                // Si es un tractor en viaje, obtiene su destino y calcula su regreso a partir de un Origen - Destino
                if (tractor.Status == (int) TruckStatusEnum.Viaje) // En viaje
                {
                    // Calcula regreso y agrega un nuevo registro a truck_plan_details
                    var plan = trips.Where(tp => tp.Truck == tractor.Id).OrderByDescending(o => o.UpdatedAt).FirstOrDefault();

                    if(plan != null)
                    {
                        regreso = calcularRegreso.ObtenerRegreso(
                        new Location { Coordinates = tractor.Position.Coordinates },
                        new Location { Id = plan.Destination },
                        new Truck { Name = tractor.Name, TruckType = tractor.Type },
                        false
                        );

                        truckDetailsUpdate = new TruckPlanDetails
                        {
                            Truckid = (int)tractor.Id,
                            MarketType = regreso.MarketType,
                            ArrivalTime = regreso.Arrival,
                            OfficeAssigned = regreso.ReturnTo
                        };
                        Context.TruckPlanDetails.Add(truckDetailsUpdate);
                    }

                }
                // Si es un tractor en taller, calcula su regreso a partir de un id de taller (Monterrey)
                else if (tractor.Status == (int) TruckStatusEnum.Taller) // En taller
                {
                    // Calcula regreso y agrega un nuevo registro a truck_plan_details
                    var orden = OrdenesMantenimiento.Where(om => om.IdUnidad == tractor.Name).FirstOrDefault();

                    regreso = calcularRegreso.ObtenerRegreso(
                        Talleres[0].Location, 
                        new Truck { Name = tractor.Name, TruckType = tractor.Type }, 
                        (DateTime) orden.FechaPrometida
                        );
                    
                    truckDetailsUpdate = new TruckPlanDetails
                    {
                        Truckid = (int)tractor.Id,
                        MarketType = regreso.MarketType,
                        ArrivalTime = regreso.Arrival,
                        OfficeAssigned = regreso.ReturnTo
                    };
                    Context.TruckPlanDetails.Add(truckDetailsUpdate);
                }
                // Actualizan regresos en la tabla de  traffic_plan a partir de los tractores con regresos ya calculados
                var trip = Context.Trips.Where(tp => tp.Truck == tractor.Id && tp.Active).SingleOrDefault();

                if (trip != null)
                {
                    trip.ReturnTo = regreso.ReturnTo;
                    Context.SaveChanges();
                }

            }
        }

        private Position ObtenerPosicionActual(List<NivelesCombustibleActuales> nivelesCombustibleActuales, string name, int? trackingId)
        {
            var posicion_actual = nivelesCombustibleActuales.Where(nCA => nCA.UnitId == trackingId).Select(nCA =>
                new Position {
                    Timestamp = nCA.DateLocation,
                    Coordinates = new Coordinates { Latitude = nCA.Latitude, Longitude = nCA.Longitude } 
                }).FirstOrDefault();

            if (ParametrosConfiguracion.ConsiderarTractoresEnTaller)
            {
                var orden_mantenimiento = OrdenesMantenimiento.Where(om => om.IdUnidad == name).FirstOrDefault();
                if(orden_mantenimiento != null)
                {
                    posicion_actual = new Position
                    {
                        Timestamp = orden_mantenimiento.FechaPrometida,
                        Coordinates = Talleres[0].Location.Coordinates
                    };
                }
            }

            return posicion_actual;
        }

        private void CalculaRegresosDeViajesActuales()
        {
            List<Object> viajes = ObtenerViajes();
            foreach (var viaje in viajes)
            {
                /*si un viaje ya no está en tiempo para calcularle su regreso, ya no lo hace.
                Esto debe venir de un parámetros, que nos indique la regla de negocio a seguir.
                */

                if (EstaEnTiempoParaCalcularRegreso(viaje))
                {
                    /*
                    Calcula todos, y los pone en el los datos del objeto de viaje. De estos regresos
                    tomará hará la selección acorde a las necesidades.
                    Si el algoritmo tiene habilitado costos y tiempos, se debe calcular.
                    actualizar la matriz de tractores con:
                        por oficina con necesidad de carga: distancia, fecha de llegada, tiempos, costos.
                    */
                    //debe hacer en base a la tabla de oficinas por día y su carga requeridad.
                    //aquí se tomaría en cuenta, a qué  hr arriba a la oficina en cuestión, y sino cumple con el tiempo límite, se debe descartar esa opción.
                    CalculaPosiblesRegresos();
                }
            }
        }

        private void CalculaPosiblesRegresos()
        {

        }

        private bool EstaEnTiempoParaCalcularRegreso(object viaje)
        {
            return true;
        }

        private List<object> ObtenerViajes()
        {
            return new List<object>();
        }

        private bool CalculaSiTractorEstaProximoAMantenimiento(Models.Truck tractor)
        {
            // Se determina que el tractor requiere mantenimiento si el kilometraje entre el último mantenimiento y el nuevo kilometraje es mayor al parámetro KmsMaximoOperarTractorMantenimiento
            var kmsUltimoMantenimiento = OrdenesMantenimiento.Where(om => om.IdUnidad == tractor.Name && om.Estado == "C").OrderByDescending(om => om.FechaCierre).Select(om => om.KmsFin).FirstOrDefault();
            var kmsActual = NivelesCombustibleActuales.Where(nCA => nCA.UnitId == tractor.TrackingId).Select(ncA => ncA.Odometro).FirstOrDefault();
            var kmsDesdeMantenimiento = kmsActual - kmsUltimoMantenimiento;
            if (kmsDesdeMantenimiento > ParametrosConfiguracion.KmsMaximoOperarTractorMantenimiento)
                return true;
            else
                return false;

        }

        private int ObtenerEstatusTractor(string estatus)
        {
            return 0;
        }

        private List<TblTiemposBitacora> ObtieneBitacoraOperador(List<TblTiemposBitacora> bitacoraOperadores, TmsTcAPI.DAL.Models.Operator operador)
        {
            //var bitacoraOperador = bitacoraOperadores.Where(bo => bo.IdConductor == operador.Id).ToList();
            var bitacoraOperador = bitacoraOperadores.Where(bo => bo.IdConductor == operador.Id).ToList();
            return bitacoraOperador;
        }

        //TODO: JON
        private bool OperadorViolaReglaDeDescanso(List<TblTiemposBitacora> bitacoraOperador)
        {
            // Se establece que las unidades no pueden conducir por más de 5 horas seguidas.
            TblTiemposBitacora ultimo = bitacoraOperador.OrderByDescending(bo => bo.Fecha).FirstOrDefault(); //TODO: No sé sabe como interpretar los datos de la bitacora del operador de momento, faltan datos de ejemplo
            if (ultimo == null)
                return false;
            if (ultimo.Transito > ParametrosConfiguracion.TiempoMaximoConduccionConsecutivo)
                return true;
            else
                return false;
        }

        private void ActualizaOperadoresANoDisponibles(TmsTcAPI.DAL.Models.Operator operador)
        {
            OperadoresActivos.Remove(operador); //Remover internamente para el resto de las operaciones del algoritmo

            //Desactivar en BD:

            var date = DateTime.Now.Date;
            var disponibilidad = Context.CalendarEmployee.Where(ea => ea.Employeeid == operador.Employeeid && ea.Date == date).FirstOrDefault();
            if(disponibilidad == null)
            {
                var employeeAvailability = new TmsTcAPI.DAL.Models.CalendarEmployee
                {
                    Date = date,
                    Employeeid = operador.Employeeid,
                    CreatedBy = CurrentUser.Id, // Pudiese ser 0 ya que aqui lo que se asigna es el usuario que corrio el algoritmo
                    Available = false,
                    CEmployeeUnavailableReasonTypeid = (int)Viajes.Api.Enums.LoadPlans.EmployeeAvailability.WorkBreak,
                };
                Context.CalendarEmployee.Add(employeeAvailability);
            } else
            {
                disponibilidad.Available = false;
                disponibilidad.CEmployeeUnavailableReasonTypeid = (int)Viajes.Api.Enums.LoadPlans.EmployeeAvailability.WorkBreak;
            }
            Context.SaveChanges();
        }

        private void ActualizaDisponibilidadDeTractores(TmsTcAPI.DAL.Models.Operator operador)
        {
            var tractoresPorActualizar = TractoresActivos;
            TractoresActivos.RemoveAll(t => tractoresPorActualizar.Select(tPA => tPA.Id).Contains(t.Id));

            //Desactivar en BD
            var date = DateTime.Now.Date;

            foreach(var truck in tractoresPorActualizar)
            {
                var disponibilidad = Context.CalendarTruck.Where(ea => ea.Id == truck.Id && ea.Date == date).FirstOrDefault();
                if (disponibilidad == null)
                {
                    var truckAvailability = new TmsTcAPI.DAL.Models.CalendarTruck
                    {
                        Date = date,
                        Truckid = operador.Employeeid,
                        CreatedBy = CurrentUser.Id, // Pudiese ser 0 ya que aqui lo que se asigna es el usuario que corrio el algoritmo
                        Available = false,
                        CTruckUnavailableReasonTypeid = (int)Viajes.Api.Enums.LoadPlans.TruckAvailability.NotAvailableByTruckOperator,
                    };
                    Context.CalendarTruck.Add(truckAvailability);
                }
                else
                {
                    disponibilidad.Available = false;
                    disponibilidad.CTruckUnavailableReasonTypeid = (int)Viajes.Api.Enums.LoadPlans.TruckAvailability.NotAvailableByTruckOperator;
                }
            }
            Context.SaveChanges();
        }

        private List<OfficePlan> GetOfficePlans(DateTime day)
        {
            var officePlans = new List<OfficePlan>();

            foreach (Office office in Oficinas)
            {
                var officePlan = new OfficePlan
                {
                    Office = office,
                    TrucksPlan = GetTrucksPlan(office.Location, day)
                };
                officePlans.Add(officePlan);
            }

            return officePlans;
        }

        private TrucksPlan GetTrucksPlan(Location office, DateTime day)
        {
            var demandaIquery = Forecasts.Where(f => f.Origin == office.Id && f.Date == day);
            var demanda = demandaIquery.Select(d =>
                new CustomerDemand
                {
                    Customer = d.Customer,
                    MarketType = d.MarketType,
                    Demand = (d.TrucksQuantity == null) ? 0 : d.TrucksQuantity
                }
            ).ToList();
            var trucksPlan = new TrucksPlan
            {
                Demand = demanda,
                Positioned = new List<Models.Truck>(),
                Arrivals = new List<Models.Truck>()
            };

            CalculaCompletado(trucksPlan);
            return trucksPlan;
        }

        private bool CalculaCompletado(TrucksPlan trucksPlan)
        {
            trucksPlan.Completed = trucksPlan.Positioned.Count + trucksPlan.Arrivals.Count >= trucksPlan.Demand.Sum(d => d.Demand);
            return trucksPlan.Completed == true;
        }

        private IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}
