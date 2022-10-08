
using System.Collections.Generic;

namespace CrmTcAPI.Models
{
    public class CatalogosAutenticacion
    {
        public CatalogosAutenticacion()
        {
            Usuarios = new List<param_idusuario>();
            PermisosUsuario = new List<PermisosUsuario>();

        }
        public List<param_idusuario> Usuarios { get; set; }
        public List<PermisosUsuario> PermisosUsuario { get; set; }

    }
}
