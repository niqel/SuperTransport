using System;
using System.Collections.Generic;
using System.Text;

namespace TmsTcAPI.BLL.Enum
{
    public class EnumTipoEntrada
    {
        public enum TipoEntrada
        {
            DocumentoAgregado = 1,
            BeneficiarioAgregado = 2,
            CambioEtapa = 3,
            NotificacionActualizada = 4,
            ComentarioAgregado = 5,
            CancelacionOperacion = 6,
            CompraVentaActualizacion = 8

        }
        public enum TipoConsulta
        {
            Usuario = 1,
            Rol = 2
        }
    }
    
}
