/*
 * Transportes Cuauhtémoc
 *
 * Transportes Cuauhtémoc (ASP.NET Core 3.1)
 *
 * OpenAPI spec version: 1.0.1
 * Contact: support@tc.com.mx
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class NamedEntity : BaseEntity, IEquatable<NamedEntity>
    {
        /// <summary>
        /// El nombre de esta entidad
        /// </summary>
        /// <value>El nombre de esta entidad</value>
        [Required]

        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// El nombre de esta entidad
        /// </summary>
        /// <value>El nombre de esta entidad</value>
        [Required]

        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// El alias de esta entidad, se obtine del cliente
        /// </summary>
        /// <value>El alias de esta entidad, se obtine del cliente</value>

        [DataMember(Name = "alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamedEntity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((NamedEntity)obj);
        }

        /// <summary>
        /// Returns true if NamedEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of NamedEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamedEntity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) &&
                (
                    Alias == other.Alias ||
                    Alias != null &&
                    Alias.Equals(other.Alias)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Alias != null)
                    hashCode = hashCode * 59 + Alias.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(NamedEntity left, NamedEntity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NamedEntity left, NamedEntity right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
