﻿using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class FactorParaCalculoFlete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}