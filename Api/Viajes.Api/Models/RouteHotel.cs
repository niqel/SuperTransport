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
    public partial class RouteHotel : IEquatable<RouteHotel>
    { 
        /// <summary>
        /// Gets or Sets IdRoute
        /// </summary>

        [DataMember(Name="idRoute")]
        public int? IdRoute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteHotel {\n");
            sb.Append("  IdRoute: ").Append(IdRoute).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RouteHotel)obj);
        }

        /// <summary>
        /// Returns true if RouteHotel instances are equal
        /// </summary>
        /// <param name="other">Instance of RouteHotel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteHotel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdRoute == other.IdRoute ||
                    IdRoute != null &&
                    IdRoute.Equals(other.IdRoute)
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
                    if (IdRoute != null)
                    hashCode = hashCode * 59 + IdRoute.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RouteHotel left, RouteHotel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RouteHotel left, RouteHotel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
