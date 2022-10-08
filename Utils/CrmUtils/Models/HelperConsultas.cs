using Core.Api.BLL.Enum;
using System;

namespace CrmTcAPI.Models
{
    public class HelperConsultasCatalogos
    {
        public string nombreProcedimientoAlmacenado { get; set; }

        public object valorRegresa { get; set; }
        public string mensaje { get; set; }
        public HelperConsultasCatalogos()
        {
            nombreProcedimientoAlmacenado = "";
            valorRegresa = null;
            mensaje = "Ok";
        }
        public void AsignaError(ErrorEnum.TypeofError error, Exception ex)
        {
            valorRegresa = (int)error;
            mensaje = EnumHelper.SetErrorMessage(mensaje, ex, error);
        }
    }
}
