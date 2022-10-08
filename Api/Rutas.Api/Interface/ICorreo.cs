using TmsTcAPI.Models;

namespace TmsTcAPI.BLL.Interface
{
    public interface ICorreo
    {
        JsonResult EnviarCorreo(string correo, string listaDocumentos, string tipoEnvio, string nombreCliente, string numeroOperacion, string textoAdicional);
        JsonResult enviarCorreoNotificacion(int objetoId, int tipoNotificacion);
        JsonResult SendPasswordRecoveryMail(string email, int userId, string userName, string token);
        JsonResult pruebaConexionBD();
    }
}
