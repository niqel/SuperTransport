using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationService.Models
{
    public class TemplateCorreo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }
        public string Body { get; set; }
        public string Bcc { get; set; }
    }
}
