using System;
using System.Collections.Generic;

namespace TmsTcAPI.BLL.Models.Operations
{
    public class Operation
    {
        public DateTime FechaANEC { get; set; }
        public DateTime FechaFolio { get; set; }
        public int CapturistaId { get; set; }
        public int TramitadorId { get; set; }
        public DateTime FechaApendice { get; set; }
        public int ResponsableId { get; set; }
        public int DepartamentoId { get; set; }
        public int TipoOperacionId { get; set; }
        public int SubtipoOperacionid { get; set; }
    }

    public class Documento
    {
        public int Id { get; set; }
        public int Clienteid { get; set; }
        public string Descripcion { get; set; }
        public int OperacionId { get; set; }
        public string BlobstorageId { get; set; }
        public int Interesadosid { get; set; }
        public string ExtensionDocumento { get; set; }
        public int TipoDocumentoInteresadoOperacionid { get; set; }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string Pais { get; set; }
        public string Calle { get; set; }
        public string Estado { get; set; }
        public string Genero { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Celular { get; set; }
        public string Colonia { get; set; }
        public string Telefono { get; set; }
        public string Municipio { get; set; }
        public string Ocupacion { get; set; }
        public List<Documento> Documentos { get; set; }
        public string EstadoCivil { get; set; }
        public int Municipioid { get; set; }
        public string CodigoPostal { get; set; }
        public string Nacionalidad { get; set; }
        public int EstadoCivilId { get; set; }
        public string TipoInteresado { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public int TipoInteresadoid { get; set; }
        public string CorreoElectronico { get; set; }
    }

    public class Interesado
    {
        public int Id { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string Pais { get; set; }
        public string Calle { get; set; }
        public string Estado { get; set; }
        public string Genero { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Celular { get; set; }
        public string Colonia { get; set; }
        public string Telefono { get; set; }
        public string Municipio { get; set; }
        public string Ocupacion { get; set; }
        public List<Documento> Documentos { get; set; }
        public string EstadoCivil { get; set; }
        public string Municipioid { get; set; }
        public string CodigoPostal { get; set; }
        public string Nacionalidad { get; set; }
        public int EstadoCivilId { get; set; }
        public string TipoInteresado { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public int TipoInteresadoid { get; set; }
        public string CorreoElectronico { get; set; }
    }

    public class JsonbAddOperation
    {
        public Operation Operation { get; set; }
        public Cliente Cliente { get; set; }
        public List<Interesado> Interesados { get; set; }
    }
}
