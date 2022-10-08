using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class param_firebasetoken
    {
        public int id_usuario { get; set; }
        public string token { get; set; }

        public param_firebasetoken(int id, string ftoken)
        {
            id_usuario = id;
            token = ftoken;
        }
    }
}