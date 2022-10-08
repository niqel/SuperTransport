using System;
using System.Collections.Generic;

namespace ListdbTc.DAL.Models
{
    public partial class TraficoPlaza
    {
        public int IdPlaza { get; set; }
        public string DescPlaza { get; set; }
        public int IdPlazaMatriz { get; set; }
        public string Matriz { get; set; }
        public string Estado { get; set; }
        public string Cell { get; set; }
        public string Cuenta { get; set; }
        public string Subcuenta { get; set; }
        public string NumPlaza { get; set; }
        public int IdZona { get; set; }
        public string Estatus { get; set; }
        public string NumPlazaext { get; set; }
        public string Nombrext { get; set; }
        public int Base { get; set; }
        public decimal DieselAdicional { get; set; }
        public byte? Nacional { get; set; }
        public bool? RegresoAutomatico { get; set; }
        public bool Procesado { get; set; }
        public int? RadioGeocerca { get; set; }
        public string OnuPais { get; set; }
        public string OnuEdo { get; set; }
        public string OnuCd { get; set; }
        public int Importacion { get; set; }
    }
}
