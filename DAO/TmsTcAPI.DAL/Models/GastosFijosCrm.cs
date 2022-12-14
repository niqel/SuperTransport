using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class GastosFijosCrm
    {
        public int? CMescalculo { get; set; }
        public int Ejercicio { get; set; }
        public string DescRango { get; set; }
        public string Cta { get; set; }
        public string Tipo { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal? Cargo { get; set; }
        public decimal? Abono { get; set; }
        public decimal? SaldoMes { get; set; }
        public decimal? SaldoFinal { get; set; }
    }
}
