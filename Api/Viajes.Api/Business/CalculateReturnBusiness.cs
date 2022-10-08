using AuthenticationHandler.Business;
using CrmTc.DAL.Models;
using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using TmsTcAPI.BLL.Business;
using TmsTcAPI.DAL.Models;
using Viajes.Api.Common;
using Viajes.Api.Models;
using TravelPlansConfiguration = Viajes.Api.Configuration.TravelPlansConfiguration;
using Truck = TmsTcAPI.DAL.Models.Truck;

namespace Viajes.Api.Business
{
    public class CalculateReturnBusiness : BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        protected TmsTcEntities TmsContext { get; private set; }
        protected ClaimsPrincipal User { get; private set; }
        private RutasBusiness RutasBusiness { get; set; }
        public TravelPlansConfiguration ParametrosConfiguracion { get; set; }
        private List<CrmTc.DAL.Models.Destinos> Destinos { get; set; }
        private bool UsarGlobalMaps { get; set; }
        private DateTime FechaSalida { get; set; }


        public CalculateReturnBusiness(TmsTcEntities context, CrmTcEntities crmContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
            TmsContext = context;
        }

        List<Regreso> Regresos = new List<Regreso>();
        private double TiempoRuta { get; set; }


        // Obtiene el regreso cuando el tractor se encuentra en medio de un viaje
        public Regreso ObtenerRegreso(Location ubicacionActual, Location destino, Truck truck, bool usarGM)
        {
            InicializarConfiguracion();
            ObtenerOficinasRegreso(ubicacionActual, destino, null, null);
            ObtenerNecesidadCarga(truck);
            UsarGlobalMaps = usarGM;
            return SeleccionarRegreso();
        }

        // Obtiene el regreso cuando el tractor se encuentra en una oficina
        public Regreso ObtenerRegreso(Location ubicacion, Truck truck, DateTime fechaSalida)
        {
            InicializarConfiguracion();
            ObtenerOficinasRegreso(null, ubicacion, null, fechaSalida);
            ObtenerNecesidadCarga(truck);
            return SeleccionarRegreso();
        }

        // Se obtienen los parámetros de configuración del algoritmo
        private void InicializarConfiguracion()
        {
            ParametrosConfiguracion = new TravelPlansConfiguration().SetTravelPlansConfiguration(TmsContext);
            RutasBusiness = new RutasBusiness(null);
            Destinos = CrmContext.Destinos.ToList();
            Regresos.Clear();
        }


        // Obtiene las oficinas y las agrega a la lista de regresos
        private void ObtenerOficinasRegreso(Location origen, Location destino, Truck tractor = null, DateTime? fechaSalida = null)
        {
            // Hace una consulta de todas las oficinas a donde puede regresar un tractor que se encuentra en un destino 
            //var oficinasRegreso = CrmContext.DistanciasRegresos.Where(dr => dr.Destinosid == destino.Id).ToList();
            var oficinasRegreso = (from d in CrmContext.DistanciasRegresos
                                    join o in CrmContext.OficinasOperativas on d.Oficinasid equals o.Oficinasid
                                    where d.Destinosid == destino.Id
                                    select new InfoDistanciasRegresos {
                                        Id = d.Destinosid,
                                        CalculadoGlobalMap = d.CalculadoGlobalMap,
                                        Kms = d.Kms,
                                        Oficinasid =d.Oficinasid,
                                        Destinosid = d.Destinosid,
                                        CostoCasetas = d.CostoCasetas,
                                        Tiempo = d.Tiempo,
                                        HoraLimiteLlegada = o.HoraLimiteLlegada
                                    }).ToList();
            if (!oficinasRegreso.Any())
                oficinasRegreso = ObtenerOficinasConGlobalMaps(destino);

            TiempoRuta = CalcularTiempoRuta(origen, destino, tractor);
            foreach (var oficina in oficinasRegreso)
            {
                Regresos.Add(new Regreso
                {
                    Origin = oficina.Destinosid,
                    ReturnTo = oficina.Oficinasid,
                    Distance = oficina.Kms,
                    Arrival = CalcularFechaRegreso(oficina.Tiempo, (DateTime) oficina.HoraLimiteLlegada, fechaSalida)
                });
                
            }
        }

        private List<InfoDistanciasRegresos> ObtenerOficinasConGlobalMaps(Location destino)
        {
            // Obtiene los regresos posibles del CRM
            var regresos = (from d in CrmContext.DistanciasRegresos.Select(d => d.Oficinasid).Distinct()
                            join o in CrmContext.OficinasOperativas on d equals o.Oficinasid
                            select new InfoDistanciasRegresos
                            {
                                Id = 0,
                                Kms = 0,
                                Oficinasid = (int) destino.Id,
                                Destinosid = d,
                                CostoCasetas = 0,
                                Tiempo = 0,
                                HoraLimiteLlegada = o.HoraLimiteLlegada,
                                Oficina = new Location()
                                {
                                    Coordinates = new Coordinates()
                                    {
                                        Latitude = float.Parse(o.Latitud),
                                        Longitude = float.Parse(o.Longitud)
                                    }
                                }
                            }).ToList();

            // Si se especifica no usar GlobalMaps regresa la información del regreso en ceros
            if (!UsarGlobalMaps)
                return regresos;

            // Calcula la información de los regresos
            foreach(var regreso in regresos)
            {
                var destinoRuta = Destinos.Where(d => d.Ciudadesid == destino.Id).FirstOrDefault();
                var infoRuta = RutasBusiness.ObtenerInfoRuta(
                    regreso.Oficina.Coordinates.Latitude.ToString(),
                    regreso.Oficina.Coordinates.Longitude.ToString(),
                    destinoRuta.Latitud.ToString(),
                    destinoRuta.Longitud.ToString(),
                    "25");
                if (infoRuta.Error_GlobalMap == "")
                {
                    regreso.CostoCasetas = decimal.Parse(infoRuta.CostoCasetas);
                    regreso.Tiempo = (float) ConvertirTiempoRuta(infoRuta.TiempoTotal);
                }
            }
            return regresos;
        }

        // Obtener tiempo de arribo del destino - oficina
        private float CalcularTiempoRegreso(float? tiempo)
        {
            // Calcular fecha y hora de legada a la oficina a partir del tiempo de viaje
            var tiempoRegreso = (float)(tiempo ?? 0 / 60);
            return tiempoRegreso;
        }

        // Calcular tiempo desde origen - destino usando la información de GlobalMaps
        private double CalcularTiempoRuta(Location origen, Location destino, Truck tractor)
        {
            if (origen == null && tractor == null || !UsarGlobalMaps)
                return 0;

            var destinoRuta = Destinos.Where(d => d.Ciudadesid == destino.Id).FirstOrDefault();
            var infoRuta = RutasBusiness.ObtenerInfoRuta(
                origen.Coordinates.Latitude.ToString(),
                origen.Coordinates.Longitude.ToString(),
                destinoRuta.Latitud.ToString(),
                destinoRuta.Longitud.ToString(),
                "25");

            if (infoRuta.Error_GlobalMap == "")            
                return ConvertirTiempoRuta(infoRuta.TiempoTotal);
            
            return 0; 
        }

        private double ConvertirTiempoRuta(string tiempo)
        {
            string sTiempoRuta = tiempo.Replace("h", "").Replace("m", "");
            double tiempoRuta = new TimeSpan(int.Parse(sTiempoRuta.Split(':')[0]), int.Parse(sTiempoRuta.Split(':')[1]), 0).TotalHours;
            return tiempoRuta;
        }


        // Obtiene el tiempo de viaje desde Origen a Destino + Destino a Regreso y considera tiempos de descanso
        private DateTime CalcularFechaRegreso(float? tiempo, DateTime horaLimite, DateTime? fechaSalida)
        {
            double tiempoRestanteSalida = 0;
            if (fechaSalida != null)
                tiempoRestanteSalida = ((DateTime)fechaSalida).Subtract(DateTime.Now).TotalHours;

            double tiempoRuta = TiempoRuta;
            double tiempoRegreso = CalcularTiempoRegreso(tiempo);
            double tiempoDescanso = (tiempoRuta + tiempoRegreso) * ParametrosConfiguracion.TiempoDescanso / ParametrosConfiguracion.TiempoMaximoConduccionConsecutivo;
            double tiempoTotal = tiempoRestanteSalida + tiempoRuta + tiempoRegreso + tiempoDescanso;
            DateTime fechaLlegada = DateTime.Now.AddHours((double)tiempoTotal);

            if (fechaLlegada.TimeOfDay <= horaLimite.TimeOfDay)
                return fechaLlegada;
            else
                return fechaLlegada.AddDays(1).Date.AddHours(5);
        }

        // Obtener todas las oficinas con necesidad de carga
        private void ObtenerNecesidadCarga(Truck truck)
        {
            var maximoDiasFuturo = ParametrosConfiguracion.MaximoDiasBuscarCargaOficinas;
            var incrementoDias = 0;
            do
            {
                ObtenerCargaOficinas(incrementoDias, truck);
                incrementoDias++;
            } while (!HayNecesidadDeCarga() && incrementoDias <= maximoDiasFuturo);

        }

        // Obtiene la cantidad de tractores por cargar de cada oficina el día y hora estimada de llegada, si ninguna oficina tiene carga para ese día
        // Se consulta la necesidad de carga del dia siguiente
        private void ObtenerCargaOficinas(int incrementoDias, Truck truck)
        {
            // Obtiene la demanda de tractores de una oficina, para todos los tipos de mercado, para un tipo de tractor y un día específico 
            var planCargaView = LoadPlanView.GetLoadPlanView(TmsContext, (int) truck.TruckType);
            foreach (Regreso regreso in Regresos)
            {
                var PlanCargaDia = planCargaView.Where(pc => pc.Fecha == regreso.Arrival.AddDays(incrementoDias).Date && pc.Oficina == regreso.ReturnTo);

                regreso.Plan = new TrucksPlan
                {
                    Demand = PlanCargaDia.Where(d => d.Faltante > 0).Select(d => new CustomerDemand {
                        Demand = d.Demanda,
                        MarketType = d.Mercado
                    }).ToList(),
                    Completed = PlanCargaDia.Any() && PlanCargaDia.Sum(s => s.Faltante) <= 0
                };
                regreso.Arrival = regreso.Arrival.AddDays(incrementoDias);
            }            
        }

        // Determina si hay necesidad de carga en al menos un regreso para ese día en específico
        private bool HayNecesidadDeCarga()
        {
            var carga = Regresos.Sum(r => r.Plan.Demand.Sum(s => s.Demand));
            if (carga == 0)
                return false;
            else
                return true;
        }

        // De la lista, seleccionar el regreso (con carga) de menor distancia
        private Regreso SeleccionarRegreso()
        {
            /** 
             * Selecciona los regresos que aun no hayan completado su plan de carga
             */
            Regresos = Regresos.OrderBy(r => r.Plan.Completed).ToList();

            /**
             * Ordenar los regresos por distancia y seleccionar el de menor distancia, que tenga carga el dia de llegada estimado.
             * Si ningún regreso tiene demanda en ningun dia, selecciona simplemente el mas cercano al destino.
             */
            var carga = Regresos.Sum(r => r.Plan.Demand.Sum(s => s.Demand));
            if (carga == 0)
            {
                var regresoSeleccionado = Regresos.OrderBy(r => r.Distance).FirstOrDefault();
                regresoSeleccionado.MarketType = 1;
                return regresoSeleccionado;
            }
                

            /**
             * Si uno o varios regresos tienen demanda de tractores, selecciona el mas cercano con demanda.
             */
            else
            {
                var regresosConforecasts = Regresos.Where(r => r.Plan.Demand.Any()).OrderBy(r => r.Distance).ToList();
                var regresosConCarga = regresosConforecasts.Where(r => r.Plan.Demand.Sum(s => s.Demand) != 0).FirstOrDefault();
                // Ordena ascendentemente los tipos de mercado: Exportacion, Doméstico, Shuttle y lo asigna al regreso
                regresosConCarga.MarketType = (int) regresosConCarga.Plan.Demand.OrderBy(o => o.MarketType).FirstOrDefault().MarketType;

                if (regresosConCarga.MarketType == 0)
                    regresosConCarga.MarketType = 1;
                return regresosConCarga;
            }

        }

    }

}
