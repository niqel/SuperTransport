using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class TemplateCorreos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Body { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
