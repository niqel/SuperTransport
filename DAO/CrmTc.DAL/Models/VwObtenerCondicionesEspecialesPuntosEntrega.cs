﻿using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwObtenerCondicionesEspecialesPuntosEntrega
    {
        public int IdPuntoEntrega { get; set; }
        public int IdCondicionEspecial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? Valor { get; set; }
        public string Telefono { get; set; }
    }
}
