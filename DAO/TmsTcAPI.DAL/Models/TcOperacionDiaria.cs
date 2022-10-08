using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TcOperacionDiaria
    {
        public int Id { get; set; }
        public int? IdArea { get; set; }
        public string Oficina { get; set; }
        public int? IdCliente { get; set; }
        public string Cliente { get; set; }
        public int? Programado { get; set; }
        public int? Posicionado { get; set; }
        public int? Viajes { get; set; }
        public int? Embarcados { get; set; }
        public int? ProgPos { get; set; }
        public int? ProgEmba { get; set; }
        public int? Cumplido { get; set; }
        public string Fecha { get; set; }
        public string UsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string UsuarioModif { get; set; }
        public DateTime? FechaModif { get; set; }
    }
}
