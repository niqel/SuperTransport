namespace CrmTcAPI.Models
{
    public class PermisosRol
    {
        public int usuariosId { get; set; }
        public int rolesId { get; set; }
        public string nombreRol { get; set; }
        //public string nombre { get; set; }
        //public string mail { get; set; }
        public int idModulo { get; set; }
        public string nombreModulo { get; set; }
        public string descripcionModulo { get; set; }
        public int idFuncionalidad { get; set; }
        public string nombreFuncionalidad { get; set; }
        public int? idPermiso { get; set; }
        public int? funcionalidadPadre { get; set; }
        public int Leer { get; set; }
        public int Escribir { get; set; }
        public int Ejecutar { get; set; }


        public PermisosRol()
        {
        }
    }
}