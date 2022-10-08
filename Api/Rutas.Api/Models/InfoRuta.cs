using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.BLL.Models
{
    public class InfoRuta
    {
        public string OrigenNombre { get; set; }
        public string OrigenLat { get; set; }
        public string OrigenLon { get; set; }
        public string DestinoNombre { get; set; }
        public string DestinoLat { get; set; }
        public string DestinoLon { get; set; }
        public string DistanciaTotal { get; set; }
        public string TiempoTotal { get; set; }
        public string CostoCasetas { get; set; }
        public string Error_GlobalMap { get; set; }
        public int ErrorInterno { get; set; }
        public string ErrorInternoMsg { get; set; }
        public InfoRuta()
        {

        }

    }
}