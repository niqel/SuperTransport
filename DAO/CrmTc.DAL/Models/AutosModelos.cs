using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class AutosModelos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Marcas IdMarcaNavigation { get; set; }
    }
}
