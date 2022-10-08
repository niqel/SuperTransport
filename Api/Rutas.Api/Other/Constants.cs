using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Other
{
    public struct OneSignal
    {
        public static string Url = "https://onesignal.com/api/v1/notifications";

        //ONESIGNAL DESARROLLO
        //public static string APIKey = "ZjM2OTg3ZGMtZmY5Yy00NmMxLWI3MTEtNjRhMTg3NjkyYTBm";
        //public static string AppId = "a066c4be-04d4-426d-a007-995bc9b6c0cd";

        //ONESIGNAL PRODUCCION
        public static string APIKey = "M2U5NDgyY2MtZjhlOC00NWJmLWFjZDAtZWU3NmM2OWNkYmIx";
        public static string AppId = "59211908-f33a-4b55-baa9-7930191dd1c2";
    }

    public struct Messages
    {
        public static string OperationRemoved = "Operación removida";
        public static string OperationAdded = "Operación agregada";
        public static string OperationFinished = "Operación terminada";
        public static string OperationsUpdated = "Actualiza tus operaciones";
        public static string OperationsCompleted = "Has completado todas tus operaciones";
        public readonly static string ExcelLoadSuccess = "El archivo excel fue cargado exitosamente.";
        public readonly static string ExcelLoadFailure = "El archivo no pudo ser cargado.";
        public readonly static string ExcelLoadPartialSuccess = "El archivo excel fue cargado pero presenta algunos errores.";
        public readonly static string ExcelFormatException = "Formato de excel incorrecto.";
    }

    public struct SP
    {
        public struct Customer
        {
            public readonly static string CreateFromList = "Customer_CreateFromList";  
        }
        public struct Params
        {
            public readonly static string List = "@List";

        }
        public struct DataType
        {
            public readonly static string CustomerList = "dbo.CustomerList";
        }
    }

    public struct EvaluationKeys
    {
        public const string IdUsuario = "IdUsuario";
        public const string IdDemandado = "IdDemandado";
        public const string NombreUsuario = "NombreUsuario";
        public const string NombreDemandado = "NombreDemandado";
        public const string Evaluaciones = "Evaluaciones";
        public const string Atencion = "Atencion";
        public const string Control = "Control";
        public const string Orden = "Orden";
        public const string IdFormulario = "IdFormulario";
        public const string IdDiligencia = "IdDiligencia";
        public const string Fecha = "Fecha";
    }
}