namespace CrmTcAPI.Models
{
    public class PermisosUsuario
    {
        public int usuariosId { get; set; }
        public int idModulo { get; set; }
        public string nombreModulo { get; set; }
        public string descripcionModulo { get; set; }
        public int idFuncionalidad { get; set; }
        public string nombreFuncionalidad { get; set; }
        public bool Leer { get; set; }
        public bool Escribir { get; set; }
        public bool Ejecutar { get; set; }


        public PermisosUsuario()
        {
        }
    }
}