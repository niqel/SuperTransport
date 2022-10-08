using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class JsonResult
    {
        public object Data { get; set; }
        public string Mensaje { get; set; }

        public JsonResult(object data)
        {
            Data = data;
        }

        public JsonResult()
        {
        }
    }
}