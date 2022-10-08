using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    [DataContract]
    public partial class City
    {
        [DataMember(Name = "id")]
        public int? Id { get; set; }
        [Required]
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [Required]
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [Required]
        [DataMember(Name = "latitude")]
        public string Latitude { get; set; }
        [Required]
        [DataMember(Name = "longitude")]
        public string Longitude { get; set; }
        [Required]
        [DataMember(Name = "zone")]
        public int? Zone { get; set; }
        [Required]
        [DataMember(Name = "active")]
        public bool Active { get; set; }
    }
}
