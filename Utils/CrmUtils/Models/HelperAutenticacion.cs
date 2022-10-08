using Core.Api.BLL.Enum;
using System;
using System.Collections.Generic;

namespace CrmTcAPI.Models
{
    public class HelperAutenticacion
    {
        public string nombreProcedimientoAlmacenado { get; set; }
        public List<param_idusuario> listaUsuario { get; set; }
        public List<PermisosRol> listaRolesFuncionalidadesPermisos { get; set; }

        public object valorRegresa { get; set; }
        public string mensaje { get; set; }
        public HelperAutenticacion()
        {
            valorRegresa = null;
            mensaje = "Ok";
            listaUsuario = new List<param_idusuario>();
            listaRolesFuncionalidadesPermisos = new List<PermisosRol>();
        }
        public void AsignaError(ErrorEnum.TypeofError error, Exception ex)
        {
            valorRegresa = (int)error;
            mensaje = EnumHelper.SetErrorMessage(mensaje, ex, error);
        }
    }
}
