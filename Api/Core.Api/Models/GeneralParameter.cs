using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    [DataContract]
    public partial class GeneralParameter
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [Required]
        [DataMember(Name = "module")]
        public string Module { get; set; }
        [Required]
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [Required]
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [Required]
        [DataMember(Name = "regex")]
        public string Regex { get; set; }
        [Required]
        [DataMember(Name = "order")]
        public int Order { get; set; }
        [Required]
        [DataMember(Name = "value")]
        public string Value { get; set; }
        [Required]
        [DataMember(Name = "active")]
        public bool Active { get; set; }
        [Required]
        [DataMember(Name = "created_by")]
        public int CreatedBy { get; set; }
        [Required]
        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [DataMember(Name = "updated_by")]
        public int UpdatedBy { get; set; }
        [Required]
        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
