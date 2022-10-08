using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viajes.Api.Models
{
    public class InfoDistanciasRegresos
    {
        public int Id { get; set; }
        public bool? CalculadoGlobalMap { get; set; }
        public decimal? Kms { get; set; }
        public int Oficinasid { get; set; }
        public int Destinosid { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? CostoCasetas { get; set; }
        public DateTime? HoraLimiteLlegada { get; set; }
        public float? Tiempo { get; set; }
        public Location Oficina { get; set; }
        public Location Destino { get; set; }


    }
}
