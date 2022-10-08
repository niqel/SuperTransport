using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Origenestmp
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Ciudadesid { get; set; }
    }
}
