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
    /// Serie de datos para la gráfica Uso de Equipo Actual
    /// </summary>
    [DataContract]
    public partial class TrucksUsage : IEquatable<TrucksUsage>
    { 
        /// <summary>
        /// Gets or Sets _TrucksUsage
        /// </summary>

        [DataMember(Name="trucks_usage")]
        public List<DataSeries> _TrucksUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrucksUsage {\n");
            sb.Append("  _TrucksUsage: ").Append(_TrucksUsage).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TrucksUsage)obj);
        }

        /// <summary>
        /// Returns true if TrucksUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of TrucksUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrucksUsage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    _TrucksUsage == other._TrucksUsage ||
                    _TrucksUsage != null &&
                    _TrucksUsage.SequenceEqual(other._TrucksUsage)
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
                    if (_TrucksUsage != null)
                    hashCode = hashCode * 59 + _TrucksUsage.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TrucksUsage left, TrucksUsage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TrucksUsage left, TrucksUsage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
