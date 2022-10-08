using System;

namespace CrmTcAPI.Models
{
    public class PermisosHistoryCustom
    {
        public string campo { get; set; }
        public string usuario { get; set; }
        public string actual { get; set; }
        public string nuevo { get; set; }
        public DateTime? fechaMovimiento { get; set; }

    }
}
