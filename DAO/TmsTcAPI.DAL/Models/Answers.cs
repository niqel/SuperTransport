using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Answers
    {
        public int Id { get; set; }
        public string Answers1 { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int GastoNoPresupuestadoid { get; set; }
    }
}
