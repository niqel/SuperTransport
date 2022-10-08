using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwParadasRutaTipoTractor
    {
        public int TiposTractorId { get; set; }
        public int RutasId { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public decimal? Casetas { get; set; }
        public decimal? CasetasAcum { get; set; }
        public decimal? Kms { get; set; }
        public decimal? KmsAcum { get; set; }
        public decimal? TiempoTotal { get; set; }
        public decimal? TiempoTotalAcum { get; set; }
        public int CiudadesId { get; set; }
        public decimal? KmsDetalleRuta { get; set; }
        public decimal? CostoCasetasDetalleRuta { get; set; }
        public float? TiempoTotalDetalleRuta { get; set; }
        public int? IdRutaInnovaLinksDetalleRuta { get; set; }
        public bool? EsReparto { get; set; }
        public short? Orden { get; set; }
        public int IdParada { get; set; }
        public int IdRutaDetalle { get; set; }
    }
}
