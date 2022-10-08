using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmsTcAPI.BLL.Models
{
    public class DetalleOperacionInfonavit
    {
        public int id { get; set; }
        public int operacionId { get; set; }
        public int expediente { get; set; }
        public int escritura { get; set; }
        public DateTime fechadeEscritura { get; set; }
        public string expCatastral { get; set; }
        public int numerodeCredito { get; set; }
        public DateTime prePreventivoFechadeSolicitud { get; set; }
        public DateTime prePreventivoFechadeAutorizacion { get; set; }
        public DateTime informativoFechadeSolicitud { get; set; }
        public DateTime informativoFechadeAutorizacion { get; set; }
        public DateTime fechadeDictaminacion { get; set; }
        public DateTime fechadeTituladoyConfirmado { get; set; }
        public DateTime preventivoFechadeSolicitud { get; set; }
        public DateTime preventivoFechadeAutorizacion { get; set; }
        public DateTime iSAIFechadeSolicitud { get; set; }
        public DateTime iSAIFechadeAutorización { get; set; }
        public string iSR { get; set; }
        public DateTime catastroFechadeSolicitud { get; set; }
        public DateTime catastroFechadeAutorizacion { get; set; }
        public DateTime registroFechadeSolicitud { get; set; }
        public DateTime registroFechadeAutorizacion { get; set; }
        public DateTime fechadeEntregadeFolios { get; set; }
        public DateTime fechadeEntregadeApendice { get; set; }
        public DateTime fechadeANEC { get; set; }
        public DateTime fechadeEntregaalcliente { get; set; }
        public short creadoPor { get; set; }
        public short modificadoPor { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public bool activo { get; set; }

    }
}