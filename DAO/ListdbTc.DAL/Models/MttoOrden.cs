using System;
using System.Collections.Generic;

namespace ListdbTc.DAL.Models
{
    public partial class MttoOrden
    {
        public int IdArea { get; set; }
        public int IdOrden { get; set; }
        public string IdServicio { get; set; }
        public int? IdEntrada { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? IdRazon { get; set; }
        public string Estado { get; set; }
        public int KmsInicio { get; set; }
        public int? KmsFin { get; set; }
        public int? IdSupervisoEntrada { get; set; }
        public int? IdSupervisoSalida { get; set; }
        public decimal? DuracionEstimada { get; set; }
        public decimal? DuracionReal { get; set; }
        public string IdConjunto { get; set; }
        public string IdUnidad { get; set; }
        public string IdIngreso { get; set; }
        public string IdUnidadConta { get; set; }
        public DateTime? FechaPrometida { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public decimal? CostoManoObra { get; set; }
        public decimal? CostoTallerExterno { get; set; }
        public decimal? HrsApertura { get; set; }
        public decimal? HrsCierre { get; set; }
        public int? KmsEntrada { get; set; }
        public decimal? HrsEntrada { get; set; }
        public string Express { get; set; }
        public int? IdOperador { get; set; }
        public int? IdRazonCierre { get; set; }
        public decimal? CostoRefacciones { get; set; }
        public int? Secuencia { get; set; }
        public string Reliberada { get; set; }
        public int? FacturaStatus { get; set; }
        public int? IdAreaunidad { get; set; }
        public int? IdDeptounidad { get; set; }
        public int? NoMedidor { get; set; }
        public DateTime? FechaEdoDoc { get; set; }
        public DateTime? FechaServicioSig { get; set; }
        public decimal? KmsServicioSig { get; set; }
        public int? IdEvaluacionorden { get; set; }
        public int? IdAreaguia { get; set; }
        public int? NoGuia { get; set; }
        public string IdRemolque { get; set; }
        public string IdLinea { get; set; }
        public int? IdSucursal { get; set; }
        public int HorasRazon { get; set; }
        public string Archivo { get; set; }
        public int? IdRecepcion { get; set; }
        public string UnidadReclamada { get; set; }
        public string AdvertenciaGarantiaRefacciones { get; set; }
        public string AdvertenciaGarantiaComponentes { get; set; }
        public string EstadoFacturacion { get; set; }
        public decimal? PrecioMoFactura { get; set; }
        public decimal? PrecioRefFactura { get; set; }
        public decimal? PrecioOsteFactura { get; set; }
        public decimal? PrecioTotalFactura { get; set; }
        public string IdModifico { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaModifico { get; set; }
        public int? FactIdCliente { get; set; }
        public int? IdAreaFactura { get; set; }
        public int? IdFactura { get; set; }
        public int? IdTipoOperacion { get; set; }
        public int? IdMultiEmpresa { get; set; }
        public int? IdMultiEmpresaUnidad { get; set; }
    }
}
