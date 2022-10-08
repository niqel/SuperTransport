using Core.Api.BLL.Enum;
using CrmTcAPI.Models;

namespace Core.Api.BLL.Interface
{
    public interface IAdminSistema
    {
        JsonResult ObtenerParametrosSistema();
        JsonResult ObtenerParametroSistemaHistory(string sParametro);
        public JsonResult GrabarParametrosSistema(
            int idUsuario
            , string Correo_Cuenta
            , string Correo_Contrasena
            , string Correo_ServerSMTP
            , string Correo_Puerto
            , string Correo_Admin
            , string Correo_Notificaciones
            , string Correo_AsuntoCliente
            , string Correo_CuerpoCliente
            , string Endpoint_Innovalinks
            , string Endpoint_ZAM
            , string Endpoint_PowerBI
            , string GlobalMaps
            , string TMS
            , string ActiveDirectory
            , string AD_Domain
            , string AD_TenantId
            , string AD_ClientId
            , string AD_Callback
            , string AD_SignedOutCallbackPath
            , string AD_ClientSecret
            , string DB_ZAM
            , string DB_Usuario
            , string DB_Contrasena
            , string GlobalMaps_ClientKey
            , string NotifTerminoContrato
            , string Endpoint_SharePoint
            , string Usuario_SharePoint
            , string Contrasena_SharePoint
            , string Usuario_PowerBI
            , string Contrasena_PowerBI
            );

        JsonResult ActualizarPermisos(
             int idUsuario
            , string idPermiso
            , int iLeer
            , int iEscribir
            , int iEjecutar
            );

        JsonResult ObtenerPermisosHistory(int idPermiso);
        JsonResult ObtenerBitacora(int idUsuarioTmp);
    }
}
