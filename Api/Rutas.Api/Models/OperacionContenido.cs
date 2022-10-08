using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmsTcAPI.BLL.Models
{
    public class OperacionContenido
    {
        public class InformacionDocumentos
        {
            public string Id { get; set; }
            public string ExtensionDocumento { get; set; }
            public string Descripcion { get; set; }
            public int TipoDocumentoInteresadoOperacionid { get; set; }
            public int Interesadosid { get; set; }
            public int Clienteid { get; set; }
            public string BlobstorageId { get; set; }         
            public int OperacionId { get; set; }
        }

        public class Documentos
        {
            public List<InformacionDocumentos> List { get; set; }
        }

        public class ClienteData
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string LugarNacimiento { get; set; }
            public string CorreoElectronico { get; set; }
            public string Telefono { get; set; }
            public string Ocupacion { get; set; }
            public string Rfc { get; set; }
            public string Curp { get; set; }
            public string Calle { get; set; }
            public string Numero { get; set; }
            public string Colonia { get; set; }
            public string CodigoPostal { get; set; }
            public string Genero { get; set; }
            public int EstadoCivilId { get; set; }
            public string EstadoCivil { get; set; }
            public int TipoInteresadoid { get; set; }
            public string TipoInteresado { get; set; }
            public int Municipioid { get; set; }
            public string Municipio { get; set; }
            public string Celular { get; set; }
            public string Estado { get; set; }
            public string Pais { get; set; }
            public Documentos documentos { get; set; }
            public string Nacionalidad { get; set; }
        }

        public class InfoInteresadosData
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string LugarNacimiento { get; set; }
            public string CorreoElectronico { get; set; }
            public string Telefono { get; set; }
            public string Ocupacion { get; set; }
            public string Rfc { get; set; }
            public string Curp { get; set; }
            public string Calle { get; set; }
            public string Numero { get; set; }
            public string Colonia { get; set; }
            public string CodigoPostal { get; set; }
            public string Genero { get; set; }
            public int EstadoCivilId { get; set; }
            public string EstadoCivil { get; set; }
            public int TipoInteresadoid { get; set; }
            public string TipoInteresado { get; set; }
            public int Municipioid { get; set; }
            public string Municipio { get; set; }
            public string Celular { get; set; }
            public string Estado { get; set; }
            public string Pais { get; set; }
            public Documentos documentos { get; set; }
            public string Nacionalidad { get; set; }
        }

        public class InteresadosData
        {
            public List<InfoInteresadosData> List { get; set; }
        }


        public string Id { get; set; }
        public int DepartamentoId { get; set; }
        public string Departamento { get; set; }
        public int TipoOperacionId { get; set; }
        public int TipoOperacion { get; set; }
        public int ResponsableId { get; set; }
        public string Responsable { get; set; }
        public int TramitadorId { get; set; }
        public string Tramitador { get; set; }
        public DateTime FechaFolio { get; set; }
        public DateTime FechaApendice { get; set; }
        public DateTime FechaANEC { get; set; }
        public int NumeroEscritura { get; set; }
        public int NumeroCredito { get; set; }
        public string NumeroExpediente { get; set; }
        public int SubtipoOperacionid { get; set; }
        public string SubtipoOperacion { get; set; }
        public int Clienteid { get; set; }
        public ClienteData Cliente { get; set; }
        public int Activo { get; set; }
        public int ActualizadoPor { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public InteresadosData Interesados { get; set; }
        public int EtapaId  { get; set; }

}
}
