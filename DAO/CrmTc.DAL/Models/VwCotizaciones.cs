using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwCotizaciones
    {
        public int Id { get; set; }
        public int? CotizacionIdentity { get; set; }
        public DateTime? FechaInicioServicio { get; set; }
        public DateTime? FechaFinServicio { get; set; }
        public bool? FuelSurcharge { get; set; }
        public float? FuelSurchargeValor { get; set; }
        public float? TasaTiie { get; set; }
        public bool? ActivacionFlota { get; set; }
        public bool? IncrementoFlota { get; set; }
        public bool? Aprobacion { get; set; }
        public decimal? PrecioTotalCotizacion { get; set; }
        public string Version { get; set; }
        public string ObservacionVersion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public float? Descuento { get; set; }
        public int? IdProyecto { get; set; }
        public string Proyecto { get; set; }
        public int? IdProductoTransportar { get; set; }
        public string ProductoTransportar { get; set; }
        public int? IdTipoTractor { get; set; }
        public string TipoTractor { get; set; }
        public int? IdEstructuraCostosFijos { get; set; }
        public int? IdParametroCotizacion { get; set; }
        public int? IdFormulaCotizacion { get; set; }
        public int? IdContrato { get; set; }
        public int NoCliente { get; set; }
        public string NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public int IdEstatusCotizacion { get; set; }
        public string EstatusCotizacion { get; set; }
        public int? RespuestaDa { get; set; }
        public int? RespuestaDg { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
