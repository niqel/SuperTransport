using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TarifasContratos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float TarifaCalculada { get; set; }
        public float? TarifaFinal { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int IdContrato { get; set; }

        public virtual Contratos IdContratoNavigation { get; set; }
    }
}
