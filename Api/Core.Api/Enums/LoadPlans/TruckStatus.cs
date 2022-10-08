using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Enums.LoadPlans
{
    enum TruckStatusEnum
    {
        Activo = 1,
        Inactivo = 2,
        Posicionado = 1004,
        Cargando = 1007,
        Viaje = 1008,
        Descargando = 1009,
        Regreso = 1010,
        Taller = 1011,
        Accidente = 1012,
    }
}
