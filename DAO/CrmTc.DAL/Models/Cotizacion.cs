using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Cotizacion
    {
        public Cotizacion()
        {
            CotizaRutas = new HashSet<CotizaRutas>();
            CotizacionParametros = new HashSet<CotizacionParametros>();
            DocumentosCotizacion = new HashSet<DocumentosCotizacion>();
            EstatusCotizacionHistory = new HashSet<EstatusCotizacionHistory>();
        }

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
        public int? IdProductoTransportar { get; set; }
        public int? IdTipoTractor { get; set; }
        public int? IdEstructuraCostosFijos { get; set; }
        public int? IdParametroCotizacion { get; set; }
        public int? IdFormulaCotizacion { get; set; }
        public int? IdContratos { get; set; }
        public int IdCliente { get; set; }
        public int IdEstatusCotizacion { get; set; }
        public int IdUsuarios { get; set; }
        public int? IdMotivosRechazoCliente { get; set; }
        public bool? Reprocesar { get; set; }
        public int? RespuestaDa { get; set; }
        public int? RespuestaDg { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual Contratos IdContratosNavigation { get; set; }
        public virtual EstatusCotizacion IdEstatusCotizacionNavigation { get; set; }
        public virtual EstructuraCostosFijos IdEstructuraCostosFijosNavigation { get; set; }
        public virtual FormulasCotizacion IdFormulaCotizacionNavigation { get; set; }
        public virtual MotivosRechazoCliente IdMotivosRechazoClienteNavigation { get; set; }
        public virtual ProductoTransportar IdProductoTransportarNavigation { get; set; }
        public virtual Proyectos IdProyectoNavigation { get; set; }
        public virtual TiposTractor IdTipoTractorNavigation { get; set; }
        public virtual Usuarios IdUsuariosNavigation { get; set; }
        public virtual ICollection<CotizaRutas> CotizaRutas { get; set; }
        public virtual ICollection<CotizacionParametros> CotizacionParametros { get; set; }
        public virtual ICollection<DocumentosCotizacion> DocumentosCotizacion { get; set; }
        public virtual ICollection<EstatusCotizacionHistory> EstatusCotizacionHistory { get; set; }
    }
}
