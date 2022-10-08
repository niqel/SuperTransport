using System.ComponentModel;

namespace Core.Api.BLL.Enum
{
    public class EnumEstatusCotizacion
    {

        public enum TypeofEstatus
        {

             nuevo = 0
            , inicial = 1
            , datos = 2
            , parametros = 3
            , rutas = 4
            , cotizando = 5
            , analizando = 6
            , enAprobDC = 7
            , aprobadaDC = 8
            , rechazadaDC = 9
            , enAprobDA = 10
            , aprobadaDA = 11
            , rechazadaDA = 12
            , enAprobDAG = 13
            , aprobadaDAG = 14
            , rechazadaDAG = 15
            , aprobDA_rechDG = 16
            , rechDA_aprobDG = 17
            , aprobadoTC = 18
            , enviado = 19
            , aprobadaCliente = 20
            , ajustesCliente = 21
            , rechazadaCliente = 22
            , cancelada = 23


        }
    }
}
