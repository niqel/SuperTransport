using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Configuracioncorreos
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int? BPassword { get; set; }
        public string IncomingServer { get; set; }
        public int IncomingPort { get; set; }
        public string OutgoingServer { get; set; }
        public int OutgoingPort { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
