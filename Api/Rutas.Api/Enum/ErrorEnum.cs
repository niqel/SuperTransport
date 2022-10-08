using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TmsTcAPI.BLL.Enum
{
    public class ErrorEnum
    {
        public enum TypeofError
        {
           
            [Description("Error USUARIO y/o CONTRASEÑA incorrectos, favor de verificar.")]
            UsuarioNoEncontrado = -1,
            [Description("Error CONTRASEÑA no coincide con la registrada en el sistema, favor de verificar.")]
            PasswordUsuarioNoCoincide = -2,
            [Description("Error Usuario desactivado.")]
            UsuarioDesactivado = -3,
            [Description("Error ejecutar insercion en base de datos")]
            ErrorAlInsertarBD = -4,
            [Description("Error al ejecutar la consulta")]
            ErrorAlObtenerConsulta = -5,
            [Description("Ha ocurrido un error al cambiar el estado de la Operacion")]
            ErrorAlCambiarEtapa = -6,
            [Description("Ha ocurrido un error al insertar una Operacion")]
            ErrorAlCrearOperacion = -7,
            [Description("Ha ocurrido un error al insertar una comentario")]
            ErrorAlInsertarComentario = -8,
            [Description("Ha ocurrido un error al cambiar el estado de una notificacion")]
            ErrorAlActualizarNotificacion = -9,
            [Description("Error, no se tiene comunicacion con el servidor....Base de Datos")]
            ErrorNoSeTieneComunicacionServidor = -10,
            [Description("Ha ocurrido un error con el servidor de correo")]
            ErrorEnElServidorDeCorreo = -11,
            [Description("Ha ocurrido un error al insertar un cliente")]
            ErrorAlInsertarCliente = -12,
            [Description("Ha ocurrido un error al insertar un Interesado")]
            ErrorAlInsertarInteresado = -13,
            [Description("Ha ocurrido un error al insertar un Documento")]
            ErrorAlInsertarDocumento = -14,
            [Description("Ha ocurrido un error al inactivar una Operacion")]
            ErrorAlInactivarOperacion = -15,
            [Description("Ha ocurrido un error al actualizar la operación")]
            ErrorAlActualizarOperacion=-16,
            [Description("Ha ocurrido un error al obtener el detalle de la operación Infonavit compra venta")]
            ErrorAlObtenerDetalleOperacionInfonavitCV = -17
        }
    }
}
