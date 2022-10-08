using System;

namespace CrmTcAPI.Models
{
    public class BitacoraCustom
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string entity { get; set; }
        public int idObject { get; set; }
        public string descripcionFuncionalidad { get; set; }
        public int idModulo { get; set; }
        public string nombreModulo { get; set; }
        public int idTipoEntradaBitacora { get; set; }
        public string DescrpcionTipoEntradaBitacora { get; set; }

    }
}
