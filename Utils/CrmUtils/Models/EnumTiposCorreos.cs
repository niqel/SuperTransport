using System.ComponentModel;

namespace Core.Api.BLL.Enum
{
    public class EnumTiposCorreos
    {
        public enum TypeofTiposCorreos
        {

            [Description("Enviar a Autorización")]
            EnviarAutorización = 1,

            [Description("Autorizacion Pendiente")]
            AutorizacionPendiente = 2,

            [Description("Cancelar")]
            Cancelar = 3,

            [Description("Contrato Documento DC")]
            ContratoDocumentoDC = 4,

            [Description("Contrato Extencion DC")]
            ContratoEXtencionDC = 5,

            [Description("Contrato Vencido Agente")]
            ContratoVencidoAgente = 6,

            [Description("Contrato Vencido DC")]
            ContratoVencidoDC = 7,

            [Description("DA")]
            DA = 8,

            [Description("DC")]
            DC = 9,

            [Description("DG")]
            DG = 10,

            [Description("Enviada Cliente")]
            EnviadaCliente = 11,

            [Description("Fuel a DC")]
            FuelaDC = 12,

            [Description("Fuel Agente")]
            FuelAgente = 13,

            [Description("Respuesta Cliente")]
            RespuestaCliente = 14,

            [Description("Término Contrato Agente")]
            TerminoContratoAgente = 15,

            [Description("Término Contrato DC")]
            TerminoContratoDC = 16
            
        }
    }
}
