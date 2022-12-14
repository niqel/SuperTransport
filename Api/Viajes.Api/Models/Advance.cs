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
    /// anticipos del operador por viaje
    /// </summary>
    [DataContract]
    public partial class Advance : IEquatable<Advance>
    { 
        /// <summary>
        /// Gets or Sets IdTravel
        /// </summary>

        [DataMember(Name="idTravel")]
        public int? IdTravel { get; set; }

        /// <summary>
        /// Gets or Sets IdOperator
        /// </summary>

        [DataMember(Name="idOperator")]
        public int? IdOperator { get; set; }

        /// <summary>
        /// Gets or Sets IdTruck
        /// </summary>

        [DataMember(Name="idTruck")]
        public int? IdTruck { get; set; }

        /// <summary>
        /// Gets or Sets Concept
        /// </summary>

        [DataMember(Name="concept")]
        public string Concept { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>

        [DataMember(Name="details")]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>

        [DataMember(Name="amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Advance {\n");
            sb.Append("  IdTravel: ").Append(IdTravel).Append("\n");
            sb.Append("  IdOperator: ").Append(IdOperator).Append("\n");
            sb.Append("  IdTruck: ").Append(IdTruck).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Advance)obj);
        }

        /// <summary>
        /// Returns true if Advance instances are equal
        /// </summary>
        /// <param name="other">Instance of Advance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Advance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdTravel == other.IdTravel ||
                    IdTravel != null &&
                    IdTravel.Equals(other.IdTravel)
                ) && 
                (
                    IdOperator == other.IdOperator ||
                    IdOperator != null &&
                    IdOperator.Equals(other.IdOperator)
                ) && 
                (
                    IdTruck == other.IdTruck ||
                    IdTruck != null &&
                    IdTruck.Equals(other.IdTruck)
                ) && 
                (
                    Concept == other.Concept ||
                    Concept != null &&
                    Concept.Equals(other.Concept)
                ) && 
                (
                    Details == other.Details ||
                    Details != null &&
                    Details.Equals(other.Details)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
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
                    if (IdTravel != null)
                    hashCode = hashCode * 59 + IdTravel.GetHashCode();
                    if (IdOperator != null)
                    hashCode = hashCode * 59 + IdOperator.GetHashCode();
                    if (IdTruck != null)
                    hashCode = hashCode * 59 + IdTruck.GetHashCode();
                    if (Concept != null)
                    hashCode = hashCode * 59 + Concept.GetHashCode();
                    if (Details != null)
                    hashCode = hashCode * 59 + Details.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Advance left, Advance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Advance left, Advance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
