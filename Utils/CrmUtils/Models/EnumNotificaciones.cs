namespace Core.Api.BLL.Enum
{
    public class EnumNotificaciones
    {
        public enum TipoNotificacion
        {
            Vencida = 1,
            PorVencer = 2

        }
        public enum EstatusNotificacion
        {
            NoAtendida = 0,
            Atendida = 1,
            Cancelada = 2
        }
    }
}
