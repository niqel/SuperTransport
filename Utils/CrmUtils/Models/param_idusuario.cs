namespace CrmTcAPI.Models
{
    public class param_idusuario
    {
        public int idUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        //public Roles roles { get; set; }
        public string Rol { get; set; }
        public int RolId { get; set; }
        public byte[] Imagen { get; set; }
        public int idActiveDirectory { get; set; }
        public int idRolAD { get; set; }
        public string SesionToken { get; set; }
        public bool ConSesionActiva { get; set; }

        public bool isFirstLogin { get; set; }
        public param_idusuario()
        {

        }

        //public param_idusuario(int id)
        //{
        //    id_usuario = id;
        //}
    }
}