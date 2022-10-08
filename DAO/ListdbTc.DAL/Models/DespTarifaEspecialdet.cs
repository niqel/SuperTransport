using System;
using System.Collections.Generic;

namespace ListdbTc.DAL.Models
{
    public partial class DespTarifaEspecialdet
    {
        public int IdTarifadet { get; set; }
        public int IdTarifa { get; set; }
        public int IdTipoOperacion { get; set; }
        public int IdOrigen { get; set; }
        public int IdDestino { get; set; }
        public string Categoria { get; set; }
        public int CantUnidades { get; set; }
        public int TarifaConvenio { get; set; }
        public DateTime IniVigencia { get; set; }
        public DateTime FinVigencia { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public decimal Factor { get; set; }
        public int IdFormula { get; set; }
        public string Estatus { get; set; }
        public int IdTipoUnidad { get; set; }
        public string IdIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string IdModifico { get; set; }
        public DateTime FechaModifico { get; set; }
        public string Dealer { get; set; }
        public decimal? KmsNegociados { get; set; }
        public decimal? Casetas { get; set; }
        public decimal? FactorVariable { get; set; }
        public decimal? Seguro { get; set; }
        public decimal? BaseFuel { get; set; }
    }
}
