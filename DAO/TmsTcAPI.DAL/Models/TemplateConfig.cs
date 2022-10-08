using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TemplateConfig
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string LayoutVariant { get; set; }
        public string LayoutMenuPosition { get; set; }
        public bool LayoutCustomizerHidden { get; set; }
        public string NavbarType { get; set; }
        public bool SidebarCollapsed { get; set; }
        public string SidebarSize { get; set; }
        public string SidebarBackgroundColor { get; set; }
        public bool SidebarBackgroundImage { get; set; }
        public string SidebarBackgroundImageUrl { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
