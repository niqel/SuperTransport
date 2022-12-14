using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class FlujoEstatusCotizacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public int IdEstatusActual { get; set; }
        public int IdEstatusSiguiente { get; set; }
        public int IdEstatusAnterior { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
