using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class EstructuraCostosFijos
    {
        public EstructuraCostosFijos()
        {
            Cotizacion = new HashSet<Cotizacion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? SeguroEquipoTransporte { get; set; }
        public decimal? SeguroPersonalTaller { get; set; }
        public decimal? HonorariosServicios { get; set; }
        public decimal? RentaInmuebles { get; set; }
        public decimal? Remuneraciones { get; set; }
        public decimal? Comunicacion { get; set; }
        public decimal? Combustible { get; set; }
        public decimal? MantenimientoEdificios { get; set; }
        public decimal? DiversosGastosAdministrativos { get; set; }
        public decimal? Depreciacion { get; set; }
        public decimal? Utilidad { get; set; }
        public decimal? TotalCostos { get; set; }
        public decimal? PrestacionesDeLeyPersonalTaller { get; set; }
        public decimal? AceitesFiltros { get; set; }
        public decimal? DiversosGastosMantenimiento { get; set; }
        public decimal? PrestacionesLeyPersonalAdministrativo { get; set; }
        public decimal? RentaTerminales { get; set; }
        public decimal? CostoLlantasKmRecorrido { get; set; }
        public decimal? RefaccionesAccesorios { get; set; }
        public decimal? DiversosGastosTransportacion { get; set; }
        public decimal? KmsRecorridosAnuales { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal? LlantasNuevas { get; set; }

        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
    }
}
