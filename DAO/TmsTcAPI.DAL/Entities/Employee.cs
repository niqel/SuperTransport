using System;
using System.Collections.Generic;
using System.Text;
using TmsTcAPI.DAL.Extensiones;

namespace TmsTcAPI.DAL.Models
{
    public partial class Employee
    {
        public int? Age
        {
            get
            {
                return GetAge();
            }
        }
        private int? GetAge()
        {
            if (this.Birthday != null)
            {
                TimeDifference timeDifference = new TimeDifference(this.Birthday.Value, DateTime.Now);
                return timeDifference.Year;
            }
            return null;
        }
    }
}
