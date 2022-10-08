using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class SesionHistory
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
