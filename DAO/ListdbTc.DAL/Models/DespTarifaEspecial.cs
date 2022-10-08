using System;
using System.Collections.Generic;

namespace ListdbTc.DAL.Models
{
    public partial class DespTarifaEspecial
    {
        public int IdTarifa { get; set; }
        public int IdArea { get; set; }
        public int IdCliente { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
        public int TipoFormula { get; set; }
        public string IdIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string IdModifico { get; set; }
        public DateTime FechaModifico { get; set; }
    }
}
