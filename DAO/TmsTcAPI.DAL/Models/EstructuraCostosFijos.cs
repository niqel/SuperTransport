using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class EstructuraCostosFijos
    {
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
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
