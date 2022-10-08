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
    /// Serie de datos para la gráfica Viajes Realizados vs Cancelados
    /// </summary>
    [DataContract]
    public partial class TripsMadeVsCancelled : IEquatable<TripsMadeVsCancelled>
    { 
        /// <summary>
        /// Gets or Sets TripsMade
        /// </summary>

        [DataMember(Name="trips_made")]
        public List<DataSeries> TripsMade { get; set; }

        /// <summary>
        /// Gets or Sets TripsCancelled
        /// </summary>

        [DataMember(Name="trips_cancelled")]
        public List<DataSeries> TripsCancelled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TripsMadeVsCancelled {\n");
            sb.Append("  TripsMade: ").Append(TripsMade).Append("\n");
            sb.Append("  TripsCancelled: ").Append(TripsCancelled).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TripsMadeVsCancelled)obj);
        }

        /// <summary>
        /// Returns true if TripsMadeVsCancelled instances are equal
        /// </summary>
        /// <param name="other">Instance of TripsMadeVsCancelled to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TripsMadeVsCancelled other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TripsMade == other.TripsMade ||
                    TripsMade != null &&
                    TripsMade.SequenceEqual(other.TripsMade)
                ) && 
                (
                    TripsCancelled == other.TripsCancelled ||
                    TripsCancelled != null &&
                    TripsCancelled.SequenceEqual(other.TripsCancelled)
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
                    if (TripsMade != null)
                    hashCode = hashCode * 59 + TripsMade.GetHashCode();
                    if (TripsCancelled != null)
                    hashCode = hashCode * 59 + TripsCancelled.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TripsMadeVsCancelled left, TripsMadeVsCancelled right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TripsMadeVsCancelled left, TripsMadeVsCancelled right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}