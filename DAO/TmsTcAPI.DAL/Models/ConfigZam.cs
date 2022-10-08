using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class ConfigZam
    {
        public int Id { get; set; }
        public string Servername { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
