using TmsTcAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Other
{
    public class Utils
    {
        public Utils()
        {
        }

        /// <summary>
        /// IsNull verifies if name is null then returns an empty space
        /// else returns name
        /// </summary>
        /// <returns>string</returns>
        /// <param name="nombre">nombre</param>
        public string IsNull(string nombre)
        {
            if (nombre == null)
            {
                return "";
            }

            return nombre;
        }

        public DateTime DateTimeNow()
        {
            TimeZoneInfo setTimeZoneInfo;
            DateTime currentDateTime;

            //Set the time zone information to US Mountain Standard Time 
            setTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)");

            //Get date and time in US Mountain Standard Time
            currentDateTime = TimeZoneInfo.ConvertTime(DateTime.Now, setTimeZoneInfo);

            return currentDateTime;
        }

        
    }
}