using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwMaquinaEstados
    {
        public int IdEstadoActual { get; set; }
        public string EstadoActual { get; set; }
        public int IdEstadoSig { get; set; }
        public string EstadoSiguiente { get; set; }
    }
}
