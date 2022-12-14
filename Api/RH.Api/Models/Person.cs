/*
 * Transportes Cuauhtémoc
 *
 * Transportes Cuauhtémoc (ASP.NET Core 3.1)
 *
 * OpenAPI spec version: 1.0.0
 * 
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
    public partial class Person : BaseEntity, IEquatable<Person>
    { 
        /// <summary>
        /// Los nombres de la persona
        /// </summary>
        /// <value>Los nombres de la persona</value>
        [Required]
        [DataMember(Name="given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// El apellido paterno de la persona
        /// </summary>
        /// <value>El apellido paterno de la persona</value>
        [Required]
        [DataMember(Name="paternal_surname")]
        public string PaternalSurname { get; set; }

        /// <summary>
        /// El apellido paterno de la persona
        /// </summary>
        /// <value>El apellido paterno de la persona</value>
        [DataMember(Name="maternal_surname")]
        public string MaternalSurname { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address")]
        public Address Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Person {\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  PaternalSurname: ").Append(PaternalSurname).Append("\n");
            sb.Append("  MaternalSurname: ").Append(MaternalSurname).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((Person)obj);
        }

        /// <summary>
        /// Returns true if Person instances are equal
        /// </summary>
        /// <param name="other">Instance of Person to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Person other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    GivenName == other.GivenName ||
                    GivenName != null &&
                    GivenName.Equals(other.GivenName)
                ) && 
                (
                    PaternalSurname == other.PaternalSurname ||
                    PaternalSurname != null &&
                    PaternalSurname.Equals(other.PaternalSurname)
                ) && 
                (
                    MaternalSurname == other.MaternalSurname ||
                    MaternalSurname != null &&
                    MaternalSurname.Equals(other.MaternalSurname)
                ) && 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
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
                    if (GivenName != null)
                    hashCode = hashCode * 59 + GivenName.GetHashCode();
                    if (PaternalSurname != null)
                    hashCode = hashCode * 59 + PaternalSurname.GetHashCode();
                    if (MaternalSurname != null)
                    hashCode = hashCode * 59 + MaternalSurname.GetHashCode();
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Person left, Person right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
