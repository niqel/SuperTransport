using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class VwRutas
    {
        public int IdRuta { get; set; }
        public int? KmsNegociados { get; set; }
        public int? Kilometros { get; set; }
        public decimal? CostoCasetas { get; set; }
        public float? TiempoTotal { get; set; }
        public int IdOrigen { get; set; }
        public int? OrigenCdId { get; set; }
        public string OrigenCdDes { get; set; }
        public int IdDestino { get; set; }
        public int? DestinoCdId { get; set; }
        public string DestinoCdDes { get; set; }
        public int IdCliente { get; set; }
        public string NombreComercial { get; set; }
    }
}
