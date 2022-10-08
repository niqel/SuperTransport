using System;
using System.Collections.Generic;

namespace InnovaLinks.DAL.Models
{
    public partial class NivelesCombustibleActuales
    {
        public int UnitId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int UnitCourse { get; set; }
        public double? Sensor1 { get; set; }
        public double? Sensor2 { get; set; }
        public double? Sensor3 { get; set; }
        public double? Sensor4 { get; set; }
        public DateTime? DateLocation { get; set; }
        public int? Odometro { get; set; }
        public double? MotorUsage { get; set; }
        public double? Tea { get; set; }
        public string Address { get; set; }
    }
}
