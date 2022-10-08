using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NotificationService.Enum
{
    public class ErrorEnum
    {
        public enum TypeofError
        {
            [Description("Ha ocurrido un error en servicio de envio de correo")]
            ErrorEnElServidorDeCorreo = -16,
            [Description("Ha ocurrido un error en servicio de envio de correo no se tiene comunicación con el servidor")]
            ErrorNoSeTieneComunicacionServidor = -17
        }
    }

}
