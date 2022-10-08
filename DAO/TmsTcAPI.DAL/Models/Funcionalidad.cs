using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Funcionalidad
    {
        public Funcionalidad()
        {
            Permisos = new HashSet<Permisos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdModulo { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? FuncionalidadPadre { get; set; }
        public bool Leer { get; set; }
        public bool Escribir { get; set; }
        public bool Ejecutar { get; set; }

        public virtual Modulos IdModuloNavigation { get; set; }
        public virtual ICollection<Permisos> Permisos { get; set; }
    }
}
