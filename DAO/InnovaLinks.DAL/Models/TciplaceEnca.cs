using System;
using System.Collections.Generic;

namespace InnovaLinks.DAL.Models
{
    public partial class TciplaceEnca
    {
        public int Id { get; set; }
        public string IdUnidad { get; set; }
        public int? IdArea { get; set; }
        public int? NoViaje { get; set; }
        public string CartaPorte { get; set; }
        public int? Repartos { get; set; }
        public int? IdOperador { get; set; }
        public int? IdCliente { get; set; }
        public string Cliente { get; set; }
        public int? IdOrigen { get; set; }
        public string Origen { get; set; }
        public int? IdDestino { get; set; }
        public string Destino { get; set; }
        public int? IdrutaLis { get; set; }
        public int? Kms { get; set; }
        public int? IdDestinatario { get; set; }
        public string Destinatario { get; set; }
        public DateTime? Fecha { get; set; }
        public string EstatusViaje { get; set; }
        public long? Enviado { get; set; }
        public string Mensaje { get; set; }
        public int? Idtc { get; set; }
    }
}
