using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class ClientesTipoGirosCliente
    {
        public int IdCliente { get; set; }
        public int IdTipoGiroCliente { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual TiposGirosCliente IdTipoGiroClienteNavigation { get; set; }
    }
}
