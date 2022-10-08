using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    [DataContract]
    public partial class Zone
    {
        [DataMember(Name = "id")]
        public int? Id { get; set; }
        [Required]
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [Required]
        [DataMember(Name = "code")]
        public string Code { get; set; }
        [Required]
        [DataMember(Name = "active")]
        public bool Active { get; set; }
    }
}
