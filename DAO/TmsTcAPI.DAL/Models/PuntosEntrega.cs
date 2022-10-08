using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class PuntosEntrega
    {
        public PuntosEntrega()
        {
            CondicionesEspecialesPuntosEntrega = new HashSet<CondicionesEspecialesPuntosEntrega>();
            DealerTelefonos = new HashSet<DealerTelefonos>();
            HorasRecepcion = new HashSet<HorasRecepcion>();
        }

        public int Id { get; set; }
        public int? Numero { get; set; }
        public bool? CalculoSeguroEspecial { get; set; }
        public string Alias { get; set; }
        public string Cuenta { get; set; }
        public string Email { get; set; }
        public float? KmsNegociados { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int IdTipoPuntoEntrega { get; set; }
        public int Ciudadesid { get; set; }
        public int? Cp { get; set; }
        public string Calle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Colonia { get; set; }

        public virtual Ciudades Ciudades { get; set; }
        public virtual TipoPuntoEntrega IdTipoPuntoEntregaNavigation { get; set; }
        public virtual ICollection<CondicionesEspecialesPuntosEntrega> CondicionesEspecialesPuntosEntrega { get; set; }
        public virtual ICollection<DealerTelefonos> DealerTelefonos { get; set; }
        public virtual ICollection<HorasRecepcion> HorasRecepcion { get; set; }
    }
}
