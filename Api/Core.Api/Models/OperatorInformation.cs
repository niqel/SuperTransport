/*
 * Transportes Cuauhtémoc
 *
 * Transportes Cuauhtémoc (ASP.NET Core 3.1)
 *
 * OpenAPI spec version: 1.0.0
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
    public partial class OperatorInformation : IEquatable<OperatorInformation>
    { 
        /// <summary>
        /// Id del operador
        /// </summary>
        /// <value>Id del operador</value>

        [DataMember(Name="idOperator")]
        public int? IdOperator { get; set; }

        /// <summary>
        /// Rating del operador
        /// </summary>
        /// <value>Rating del operador</value>

        [DataMember(Name="rating")]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Tractor asignado del operador
        /// </summary>
        /// <value>Tractor asignado del operador</value>

        [DataMember(Name="truck")]
        public string Truck { get; set; }

        /// <summary>
        /// Remolques asignados al tractor
        /// </summary>
        /// <value>Remolques asignados al tractor</value>

        [DataMember(Name="towing")]
        public List<string> Towing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperatorInformation {\n");
            sb.Append("  IdOperator: ").Append(IdOperator).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Truck: ").Append(Truck).Append("\n");
            sb.Append("  Towing: ").Append(Towing).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OperatorInformation)obj);
        }

        /// <summary>
        /// Returns true if OperatorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of OperatorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperatorInformation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdOperator == other.IdOperator ||
                    IdOperator != null &&
                    IdOperator.Equals(other.IdOperator)
                ) && 
                (
                    Rating == other.Rating ||
                    Rating != null &&
                    Rating.Equals(other.Rating)
                ) && 
                (
                    Truck == other.Truck ||
                    Truck != null &&
                    Truck.Equals(other.Truck)
                ) && 
                (
                    Towing == other.Towing ||
                    Towing != null &&
                    Towing.SequenceEqual(other.Towing)
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
                    if (IdOperator != null)
                    hashCode = hashCode * 59 + IdOperator.GetHashCode();
                    if (Rating != null)
                    hashCode = hashCode * 59 + Rating.GetHashCode();
                    if (Truck != null)
                    hashCode = hashCode * 59 + Truck.GetHashCode();
                    if (Towing != null)
                    hashCode = hashCode * 59 + Towing.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OperatorInformation left, OperatorInformation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OperatorInformation left, OperatorInformation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
