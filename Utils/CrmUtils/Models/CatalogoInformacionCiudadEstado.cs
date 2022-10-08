namespace CrmTcAPI.Models
{
    public class CatalogoInformacionCiudadEstado
    {
        public int id { get; set; }
        public int idEstado { get; set; }
        public int idMunicipio { get; set; }
        public int idZona { get; set; }
        public string  estadoCiudad { get; set; }
        public string nombreEstado { get; set; }
        public string nombreCiudad { get; set; }
        public string nombreMunucipio { get; set; }
        public string nombreZona { get; set; }



    }
}
