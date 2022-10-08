namespace CrmTcAPI.Models
{
    public class TemplateConfiguracionCustom
    {
        public TemplateConfiguracionCustom()
        {
            layout = new Layout();
            layout.customizer = new Customizer();
            layout.navbar = new Navbar();
            layout.sidebar = new Sidebar();
        }

        public Layout layout { get; set; }

    }
    public class Customizer
    {
        public bool hidden { get; set; }
    }

    public class Navbar
    {
        public string type { get; set; }
    }

    public class Sidebar
    {
        public bool collapsed { get; set; }
        public string size { get; set; }
        public string backgroundColor { get; set; }
        public bool backgroundImage { get; set; }
        public string backgroundImageURL { get; set; }
    }

    public class Layout
    {
        public string variant { get; set; }
        public string menuPosition { get; set; }
        public Customizer customizer { get; set; }
        public Navbar navbar { get; set; }
        public Sidebar sidebar { get; set; }
    }




}
