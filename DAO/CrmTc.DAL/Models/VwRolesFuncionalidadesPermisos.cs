using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwRolesFuncionalidadesPermisos
    {
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public int IdModulo { get; set; }
        public string Modulo { get; set; }
        public int IdFuncionalidad { get; set; }
        public string Funcionalidad { get; set; }
        public int IdPermiso { get; set; }
        public int Leer { get; set; }
        public int Escribir { get; set; }
        public int Ejecutar { get; set; }
    }
}
