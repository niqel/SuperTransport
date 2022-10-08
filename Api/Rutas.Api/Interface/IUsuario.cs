using TmsTcAPI.BLL.Enum;
using TmsTcAPI.Models;

namespace TmsTcAPI.BLL.Interface
{
    public interface IUsuario
    {
        JsonResult ObtenerPermisos(int identificadorId, EnumTipoEntrada.TipoConsulta consulta);
    }
}
