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
    /// Contiene las listas dos listas Operadores, tracores y demanda
    /// </summary>
    [DataContract]
    public partial class TrackingNotAvailable : IEquatable<TrackingNotAvailable>
    { 
        /// <summary>
        /// Gets or Sets Operators
        /// </summary>

        [DataMember(Name="operators")]
        public List<OperatorNotAvailable> Operators { get; set; }

        /// <summary>
        /// Gets or Sets Trucks
        /// </summary>

        [DataMember(Name="trucks")]
        public List<TruckNotAvailable> Trucks { get; set; }

        /// <summary>
        /// Gets or Sets Plan
        /// </summary>

        [DataMember(Name="plan")]
        public int? Plan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingNotAvailable {\n");
            sb.Append("  Operators: ").Append(Operators).Append("\n");
            sb.Append("  Trucks: ").Append(Trucks).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TrackingNotAvailable)obj);
        }

        /// <summary>
        /// Returns true if TrackingNotAvailable instances are equal
        /// </summary>
        /// <param name="other">Instance of TrackingNotAvailable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingNotAvailable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Operators == other.Operators ||
                    Operators != null &&
                    Operators.SequenceEqual(other.Operators)
                ) && 
                (
                    Trucks == other.Trucks ||
                    Trucks != null &&
                    Trucks.SequenceEqual(other.Trucks)
                ) && 
                (
                    Plan == other.Plan ||
                    Plan != null &&
                    Plan.Equals(other.Plan)
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
                    if (Operators != null)
                    hashCode = hashCode * 59 + Operators.GetHashCode();
                    if (Trucks != null)
                    hashCode = hashCode * 59 + Trucks.GetHashCode();
                    if (Plan != null)
                    hashCode = hashCode * 59 + Plan.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TrackingNotAvailable left, TrackingNotAvailable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TrackingNotAvailable left, TrackingNotAvailable right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
