using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwRutas
    {
        public int IdRuta { get; set; }
        public int? TiposTractorid { get; set; }
        public int? KmsNegociados { get; set; }
        public decimal? Kilometros9Ejes { get; set; }
        public float? CostoCasetas9Ejes { get; set; }
        public float? TiempoTotal9Ejes { get; set; }
        public decimal? Kilometros7Ejes { get; set; }
        public decimal? CostoCasetas7Ejes { get; set; }
        public float? TiempoTotal7Ejes { get; set; }
        public int IdOrigen { get; set; }
        public int? OrigenCdId { get; set; }
        public string OrigenCdDes { get; set; }
        public int IdDestino { get; set; }
        public int? DestinoCdId { get; set; }
        public string DestinoCdDes { get; set; }
        public bool Active { get; set; }
    }
}
