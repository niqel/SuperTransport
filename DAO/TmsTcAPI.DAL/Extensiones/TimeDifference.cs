using System;
using System.Collections.Generic;
using System.Text;

namespace TmsTcAPI.DAL.Extensiones
{
    public class TimeDifference
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public TimeDifference()
        {

        }

        public TimeDifference(DateTime initialDatetime, DateTime finalDatetime)
        {
            this.CalculateTimeDifference(initialDatetime, finalDatetime);
        }

        public void CalculateTimeDifference(DateTime initialDatetime, DateTime finalDatetime)
        {
            int initialDay = initialDatetime.Day;
            int initialMonth = initialDatetime.Month;
            int initialYear = initialDatetime.Year;

            int finalDay = finalDatetime.Day;
            int finalMonth = finalDatetime.Month;
            int finalYear = finalDatetime.Year;

            if (finalDay < initialDay)
            {
                if (finalMonth == 4 || finalMonth == 6 || finalMonth == 9 || finalMonth == 11)
                {
                    finalDay += 30;
                    finalMonth -= 1;
                }
                else
                {
                    if (finalMonth != 2)
                    {
                        finalDay += 31;
                        finalMonth -= 1;
                    }
                    else
                    {
                        if (finalYear % 4 == 0)
                        {
                            if (finalYear % 100 == 0)
                            {
                                if (finalYear % 400 == 0)
                                {
                                    finalDay += 29;
                                    finalMonth -= 1;
                                    //Si es un año bisisesto
                                }
                                else
                                {
                                    finalDay += 28;
                                    finalMonth -= 1;
                                    //No es año bisiesto
                                }
                            }
                            else
                            {
                                finalDay += 29;
                                finalMonth -= 1;
                                //Es una año bisiesto
                            }
                        }
                        else
                        {
                            finalDay += 28;
                            finalMonth -= 1;
                            //No es año bisiesto
                        }
                    }
                }
            }

            this.Day = finalDay - initialDay;

            if (finalMonth < initialMonth)
            {
                finalMonth += 12;
                finalYear -= 1;
            }

            this.Month = finalMonth - initialMonth;
            this.Year = finalYear - initialYear;
        }
    }
}
