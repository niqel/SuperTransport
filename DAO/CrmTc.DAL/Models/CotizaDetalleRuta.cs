using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaDetalleRuta
    {
        public int Id { get; set; }
        public int IdCotizaRutas { get; set; }
        public decimal Kms { get; set; }
        public decimal? CostoCasetas { get; set; }
        public short PorcentajeProbabilidadCarga { get; set; }
        public decimal TotalGastosVariables { get; set; }
        public decimal PrecioFleteCalculado { get; set; }
        public decimal? PrecioFleteFinal { get; set; }
        public decimal? Utilidad { get; set; }
        public decimal PrecioXkms { get; set; }
        public bool RutaEspecial { get; set; }
        public decimal? Rendimiento { get; set; }
        public float? TiempoTotal { get; set; }
        public bool? ConRepartos { get; set; }
        public decimal? ViajesAlMes { get; set; }
        public decimal? DiasViajeEstimados { get; set; }
        public decimal? FacturacionEstimadaMensual { get; set; }
        public decimal? KmsEstMensuales { get; set; }
        public decimal? SueldoOperador { get; set; }
        public decimal? PorcentajeSueldoOperador { get; set; }
        public decimal? CombustibleSinIva { get; set; }
        public decimal? PeajeSinIva { get; set; }
        public decimal? DiversosGastosTransportacion { get; set; }
        public decimal? Llantas { get; set; }
        public decimal? RefaccionesAccesorios { get; set; }
        public decimal? KmsNegociados { get; set; }
        public string IdRutaZam { get; set; }
        public string IdRutaInnovaLinks { get; set; }
        public decimal? PorcentajeCargado { get; set; }
        public decimal? PorcentajeVacio { get; set; }
        public decimal? PorcentajeDescuento { get; set; }
        public decimal? Volumen { get; set; }
        public bool? RequiereRevision { get; set; }
        public decimal? SalarioOperador { get; set; }
        public decimal? KilometrajeCliente { get; set; }
        public decimal? RateCarga { get; set; }
        public decimal? PrecioFleteHistorico { get; set; }
        public decimal? PorcentajeIncDec { get; set; }
        public DateTime? FechaFleteHistorico { get; set; }

        public virtual CotizaRutas IdCotizaRutasNavigation { get; set; }
    }
}
