using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    [DataContract]
    public partial class HistoryRecord
    {
        public HistoryRecord()
        {
            Previous = new Dictionary<string, object>();
            Current = new Dictionary<string, object>();
        }

        [Required]
        [DataMember(Name = "previous")]
        public IDictionary<string, object> Previous { get; }
        [Required]
        [DataMember(Name = "current")]
        public IDictionary<string, object> Current { get; }
        [Required]
        [DataMember(Name = "user")]
        public string User { get; set; }
        [Required]
        [DataMember(Name = "date")]
        public DateTime Date { get; set; }
    }
}
