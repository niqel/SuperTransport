using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class OficinasTc
    {
        public int Id { get; set; }
        public int? Telefono { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
