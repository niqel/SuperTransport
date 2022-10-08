using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwDashBoardCotizacion
    {
        public string Cliente { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? Iniciada { get; set; }
        public int? ProcesoAnálisis { get; set; }
        public int? EnAprobaciónDirecciónComercial { get; set; }
        public int? EnAprobaciónDirectorAdministrativo { get; set; }
        public int? EnAprobaciónDirecciónAdministrativoYGeneral { get; set; }
        public int? SolicitudAjustesPorCliente { get; set; }
        public int? AprobadoTransportesCuauthémoc { get; set; }
        public int? EnviadoACliente { get; set; }
        public int? Clonada { get; set; }
        public int? NoAprobadaPorCliente { get; set; }
        public int? AprobadaCliente { get; set; }
        public int? Cancelada { get; set; }
    }
}
