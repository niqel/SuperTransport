using System;
using System.Collections.Generic;

namespace ListdbTc.DAL.Models
{
    public partial class GeneralArea
    {
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public int? Cp { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public int? Areacont { get; set; }
        public int? ConsecutivoPoliza { get; set; }
        public int? Idcia { get; set; }
        public int? Idsuc { get; set; }
        public decimal? Montosm { get; set; }
        public string Cuenta { get; set; }
        public string Subcuenta { get; set; }
        public string Auxiliar1 { get; set; }
        public string Activa { get; set; }
        public int IdRazon { get; set; }
        public string Segmento { get; set; }
        public string Nombrecorto { get; set; }
        public int IdNivel1 { get; set; }
        public int IdNivel2 { get; set; }
        public int IdNivel4 { get; set; }
        public int IdNivel5 { get; set; }
        public int IdNivel6 { get; set; }
        public int? IdPais { get; set; }
        public string Oficina { get; set; }
        public string Liquida { get; set; }
        public int? IdPlaza { get; set; }
        public string Estatus { get; set; }
        public int EsEmpresa { get; set; }
        public int IdCompania { get; set; }
        public int? IdPlazaTarifa { get; set; }
        public int? IdMultiEmpresa { get; set; }
    }
}
