using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationService.Models
{
    public class OneSignalCredentials
    {
        public string Url { get; set; }

        //ONESIGNAL DESARROLLO
        public string APIKey { get; set; }
        public string AppId { get; set; }

        //ONESIGNAL PRODUCCION
        // public static string APIKey = "M2U5NDgyY2MtZjhlOC00NWJmLWFjZDAtZWU3NmM2OWNkYmIx";
        // public static string AppId = "59211908-f33a-4b55-baa9-7930191dd1c2";        
    }
}
