using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viajes.Api.Models
{
    public class CurrentTrip
    {
        public int Id { get; set; }
        
        public int Origin { get; set; }
        
        public int Destination { get; set; }

        public DateTime FechaInicio { get; set; }

        public string NombreOrigen { get; set; }

        public string NombreDestino { get; set; }
    }
}
