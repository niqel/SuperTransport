using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Bitacora
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Entity { get; set; }
        public int? IdObject { get; set; }
        public int IdBitacoraTipoEntrada { get; set; }

        public virtual BitacoraTiposEntrada IdBitacoraTipoEntradaNavigation { get; set; }
    }
}
