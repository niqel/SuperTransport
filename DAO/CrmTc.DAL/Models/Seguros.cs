using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Seguros
    {
        public int Id { get; set; }
        public int ModeloAnio { get; set; }
        public decimal? CostoSeguroTr { get; set; }
        public DateTime? CostoSeguroTrupdatedAt { get; set; }
        public int? UnidadesTr { get; set; }
        public DateTime? UnidadesTrupdatedAt { get; set; }
        public decimal? CostoSeguroRemolque1 { get; set; }
        public DateTime? CostoSeguroRemolque1UpdatedAt { get; set; }
        public int? UnidadesRemolque1 { get; set; }
        public DateTime? UnidadesRemolque1UpdatedAt { get; set; }
        public decimal? CostoSeguroRemolque2 { get; set; }
        public DateTime? CostoSeguroRemolque2UpdatedAt { get; set; }
        public int? UnidadesRemolque2 { get; set; }
        public DateTime? UnidadesRemolque2UpdatedAt { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
