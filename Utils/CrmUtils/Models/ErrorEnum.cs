using System.ComponentModel;

namespace Core.Api.BLL.Enum
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
            [Description("Ha ocurrido un error al obtener el detalle de la operación Infonavit compra venta")]
            ErrorAlObtenerDetalleOperacionInfonavitCV = -7,
            [Description("Ha ocurrido un error al actualizar un contrato")]
            ErrorAlActualizarContrato = -8,
            [Description("Ha ocurrido un error al eliminar un contrato")]
            ErrorAlEliminarContrato = -9,
            [Description("Ha ocurrido un error al actualizar un contacto")]
            ErrorAlActualizarContacto = -10,
            [Description("Ha ocurrido un error al eliminar un contacto")]
            ErrorAlEliminarContacto = -11,
            [Description("Ha ocurrido un error al actualizar ClientesFacturacion")]
            ErrorAlActualizarClientesFacturacion = -12,
            [Description("Ha ocurrido un error al eliminar ClientesFacturacion")]
            ErrorAlEliminarClientesFacturacion = -13,
            [Description("Ha ocurrido un error al actualizar Punto de Entrega")]
            ErrorAlActualizarPuntoEntrega = -14,
            [Description("Ha ocurrido un error al eliminar Punto de Entrega")]
            ErrorAlEliminarPuntoEntrega = -15,
            [Description("Ha ocurrido un error en servicio de envio de correo")]
            ErrorEnElServidorDeCorreo = -16,
            [Description("Ha ocurrido un error en servicio de envio de correo no se tiene comunicación con el servidor")]
            ErrorNoSeTieneComunicacionServidor = -17,
            [Description("Ha ocurrido un error al obtener catálogos del Cliente")]
            ErrorAlObtenerCatalogosCliente = -18,
            [Description("Usuario y/o contraseña incorrectos.")]
            ErrorAlIniciarSesion = -19,
            [Description("Ha ocurrido un error en servicio de actualización de información del cliente")]
            ErrorAlInsertarActualizarInformacionCliente = -20,
            [Description("Ha ocurrido un error en servicio de actualización de información template config")]
            ErrorAlActualizarTemplateConfig = -21,
            [Description("Ha ocurrido un error en servicio de Insertar PuntoEntregaUbicacion")]
            ErrorAlInsertarPuntoEntregaUbicacion = -22,
            [Description("Ha ocurrido un error en servicio de actualizar en cliente facturación principal en Clientes. ")]
            ErrorAlActualizarClientesFacturacionPrincipal = -23,
            [Description("Ha ocurrido un error en servicio de insertar/actualizar un contrato. ")]
            ErrorAlInsertarActualizarContrato = -24,
            [Description("Ha ocurrido un error en servicio de insertar/actualizar un proyecto. ")]
            ErrorAlActualizarAgregarProyecto = -25
        }
    }
}
