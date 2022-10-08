using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class RutaTipoTractor
    {
        public RutaTipoTractor()
        {
            DetalleRuta = new HashSet<DetalleRuta>();
            Paradas = new HashSet<Paradas>();
            PreciosHistoricosRutas = new HashSet<PreciosHistoricosRutas>();
        }

        public int Id { get; set; }
        public int TiposTractorid { get; set; }
        public int Rutasid { get; set; }

        public virtual Rutas Rutas { get; set; }
        public virtual TiposTractor TiposTractor { get; set; }
        public virtual ICollection<DetalleRuta> DetalleRuta { get; set; }
        public virtual ICollection<Paradas> Paradas { get; set; }
        public virtual ICollection<PreciosHistoricosRutas> PreciosHistoricosRutas { get; set; }
    }
}
