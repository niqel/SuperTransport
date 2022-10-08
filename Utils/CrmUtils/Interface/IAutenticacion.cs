using Core.Api.BLL.Enum;
using CrmTcAPI.Models;
using System.Net.Http;
using TmsTcAPI.DAL.Models;

namespace Core.Api.BLL.Interface

{
    public interface IAutenticacion
    {
        JsonResult ObtenerPermisos(int identificadorId, EnumTipoEntrada.TipoConsulta consulta);
        JsonResult Login(string sUser, string sPassword, string tipoUsuario="web");
        JsonResult ObtenerPermisosParametrosCotizacionRol(int idRol);
        JsonResult ObtenerPermisosFuncionalidadesRol(int idRol);
        JsonResult ObtenerCatalogos(string sUser, string sPassword);
        JsonResult ObtenerPermisosFuncionalidadesUsuario(int idUsuario);
        JsonResult ObtenerConfiguracionTemplate(int idUsuario);
        JsonResult AgregarActualizarTemplateConfiguracion(TemplateConfig template);
        JsonResult ValidarSesion(int idUsuario, string sSesionToken);
        JsonResult Logout(int idUsuario);
        JsonResult KeepAlive(string sSesionToken, int iMinutos = 15);

    }
}
