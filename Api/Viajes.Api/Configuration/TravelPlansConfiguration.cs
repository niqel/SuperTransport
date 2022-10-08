using System;
using System.Collections.Generic;
using System.Linq;
using TmsTcAPI.DAL.Models;
using Viajes.Api.Enums.LoadPlans;

namespace Viajes.Api.Configuration
{
    public class TravelPlansConfiguration {

        /// <summary>
        /// Parámetro para indicar si se puede o no cambiar un regreso cuando el viaje ya inicio.
        /// </summary>
        public bool CambioRegresoViajeIniciado { get; set; }

        /// <summary>
        /// Parámetro para considerar el % máximo del recorrido permitido para cambiar un regreso.
        /// </summary>        
        public double PorcentajeRecorridoMaximoRegreso { get; set; }

        /// <summary>
        /// Parámetro para saber cuántos días máximos se puede modificar un regreso.
        /// </summary>
        public int DiasMaximosModificarRegreso { get; set; }

        /// <summary>
        /// Parámetro para considerar si se toman en cuenta o no Tractores que se encuentren en taller con una OT.
        /// </summary>
        public bool ConsiderarTractoresEnTaller { get; set; }

        /// <summary>
        /// Parámetro para indicar cuantos KMs Máximo se permite seguir operando a un tractor cuando ya rebaso los KMs de Mantenimiento.
        /// </summary>
        public double KmsMaximoOperarTractorMantenimiento { get; set; }

        /// <summary>
        /// Parámetro que se usa para saber cuantas horas en descarga se pueda tomar como disponible.
        /// </summary>
        public double TiempoDescargaTractor { get; set; }

        /// <summary>
        /// Tiempo que tarda en cargar un tractor
        /// </summary>
        public double HorasCarga { get; set; }

        /// <summary>
        /// Tiempo que tarda en descargar un tractor
        /// </summary>
        public double HorasDescarga { get; set; }

        /// <summary>
        /// Tiempo en horas máximo que una unidad puede conducir de forma seguida
        /// </summary>

        public double TiempoMaximoConduccionConsecutivo { get; set; }

        /// <summary>
        /// Tiempo de descanso del operador en horas
        /// </summary>
        public double TiempoDescanso { get; set; }

        /// <summary>
        /// Limite máximo en días que puede buscar carga en una oficina
        /// </summary>
        public int MaximoDiasBuscarCargaOficinas { get; set; }

        /// <summary>
        /// Numero de días a futuro que el usuario no puede editar el forecast
        /// </summary>
        public int ResticcionForecastEdicion { get; set; }

        public TravelPlansConfiguration()
        {
        }

        public TravelPlansConfiguration SetTravelPlansConfiguration(TmsTcEntities context)
        {
            List<TmsTcAPI.DAL.Models.Parameters> configuration = context.Parameters.Where(tpc=> tpc.Active == true).ToList();
            CambioRegresoViajeIniciado = Convert.ToBoolean(configuration.Where(ps => ps.Key == "CREG").Select(p => p.Value).FirstOrDefault() == "0" ? false : true);
            PorcentajeRecorridoMaximoRegreso = Double.Parse(configuration.Where(ps => ps.Key == "PREG").Select(p => p.Value).FirstOrDefault());
            DiasMaximosModificarRegreso = int.Parse(configuration.Where(ps => ps.Key == "DREG").Select(p => p.Value).FirstOrDefault());
            ConsiderarTractoresEnTaller = Convert.ToBoolean(configuration.Where(ps => ps.Key == "TALL").Select(p => p.Value).FirstOrDefault() == "0" ? false : true);
            KmsMaximoOperarTractorMantenimiento = Double.Parse(configuration.Where(ps => ps.Key == "TOPX").Select(p => p.Value).FirstOrDefault());
            TiempoDescargaTractor = Double.Parse(configuration.Where(ps => ps.Key == "TDES").Select(p => p.Value).FirstOrDefault());
            HorasCarga = Double.Parse(configuration.Where(ps => ps.Key == "HCAR").Select(p => p.Value).FirstOrDefault());
            HorasDescarga = Double.Parse(configuration.Where(ps => ps.Key == "HDES").Select(p => p.Value).FirstOrDefault());
            TiempoMaximoConduccionConsecutivo = Double.Parse(configuration.Where(ps => ps.Key == "CONX").Select(p => p.Value).FirstOrDefault());
            TiempoDescanso = Double.Parse(configuration.Where(ps => ps.Key == "TDES").Select(p => p.Value).FirstOrDefault());
            MaximoDiasBuscarCargaOficinas = int.Parse(configuration.Where(ps => ps.Key == "DBUS").Select(p => p.Value).FirstOrDefault());
            ResticcionForecastEdicion = int.Parse(configuration.Where(ps => ps.Key == "RFOR").Select(p => p.Value).FirstOrDefault());

            return this;
        }

    }
}
