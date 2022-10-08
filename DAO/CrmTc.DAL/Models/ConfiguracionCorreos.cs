using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class ConfiguracionCorreos
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string BContrasena { get; set; }
        public string ServidorEntrada { get; set; }
        public int? PuertoEntrada { get; set; }
        public string ServidorSalida { get; set; }
        public int? PuertoSalida { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
