using System;
using System.ComponentModel;
using System.Reflection;
using static Core.Api.BLL.Enum.ErrorEnum;

namespace Core.Api.BLL.Enum
{
    public class EnumHelper
    {
        public static string StringValueOf(ErrorEnum.TypeofError value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static string SetErrorMessage(string message, Exception ex, TypeofError error)
        {
            string errorMessage = string.Empty;
            string exceptionMessage = string.Empty;
            if (ex.InnerException != null)
                exceptionMessage = ex.Message + ". " + ex.InnerException.Message;
            else
                exceptionMessage = ex.Message;

            errorMessage = EnumHelper.StringValueOf(error) + " | Exception : " + exceptionMessage;

            return errorMessage;
        }
    }
}
