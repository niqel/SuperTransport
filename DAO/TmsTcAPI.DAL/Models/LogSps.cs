using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class LogSps
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Sp { get; set; }
    }
}
