using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Enums.LoadPlans
{
    enum OperatorStatusEnum
    {
        NoDisponible = 1,
        EnOficina = 2,
        EnViaje = 3,
        SinEquipo = 4,
        EnDescanso = 5,
        Liquidando = 6
    }
}
