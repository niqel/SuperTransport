using TmsTcAPI.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class EvaluationDetail
    {
        public EvaluationDetail() { }

        public void SetProperties(Dictionary<string, object> dictionary)
        {
            if (dictionary.ContainsKey(EvaluationKeys.IdUsuario))
            {
                IdUsuario = int.Parse(dictionary[EvaluationKeys.IdUsuario].ToString());
            }

            if (dictionary.ContainsKey(EvaluationKeys.IdDemandado))
            {
                IdDemandado = int.Parse(dictionary[EvaluationKeys.IdDemandado].ToString());
            }

            if (dictionary.ContainsKey(EvaluationKeys.NombreUsuario))
            {
                NombreUsuario = dictionary[EvaluationKeys.NombreUsuario].ToString();
            }

            if (dictionary.ContainsKey(EvaluationKeys.NombreDemandado))
            {
                NombreDemandado = dictionary[EvaluationKeys.NombreDemandado].ToString();
            }
        }

        public int IdUsuario { get; set; }
        public int IdDemandado { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreDemandado { get; set; }
        public List<EvaluationResult> Evaluaciones { get; set; }

    }
}