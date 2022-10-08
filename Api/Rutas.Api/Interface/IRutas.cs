using TmsTcAPI.BLL.Models;

namespace TmsTcAPI.BLL.Interface
{
    public interface IRutas
    {
        InfoRuta ObtenerInfoRuta(
             string OrigenLatitude
            ,string OrigenLongitude
            ,string DestinoLatitude
            ,string DestinoLongitude
            ,string TipoVehiculo
            //,string PesoVehiculo
            //,string LargoVehiculo
            //,string AnchoVehiculo
            //,string AlturaVehiculo
            //,string EvitarCasetas
            //,string EvitarFerrys
            //,string OptimizarParadas
            //,string OptimizarNOM
            //,string RutaCamion
            //,string Velocidad
            );
    }
}
