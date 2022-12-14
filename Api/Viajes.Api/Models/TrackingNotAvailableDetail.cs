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
    /// tiene los totales del seguimiento
    /// </summary>
    [DataContract]
    public partial class TrackingNotAvailableDetail : IEquatable<TrackingNotAvailableDetail>
    { 
        /// <summary>
        /// Gets or Sets ToCharge
        /// </summary>

        [DataMember(Name="toCharge")]
        public int? ToCharge { get; set; }

        /// <summary>
        /// Gets or Sets Transit
        /// </summary>

        [DataMember(Name="transit")]
        public int? Transit { get; set; }

        /// <summary>
        /// Gets or Sets Download
        /// </summary>

        [DataMember(Name="download")]
        public int? Download { get; set; }

        /// <summary>
        /// Gets or Sets ZeroDays
        /// </summary>

        [DataMember(Name="zeroDays")]
        public int? ZeroDays { get; set; }

        /// <summary>
        /// Gets or Sets OneDays
        /// </summary>

        [DataMember(Name="OneDays")]
        public int? OneDays { get; set; }

        /// <summary>
        /// Gets or Sets TwoDays
        /// </summary>

        [DataMember(Name="twoDays")]
        public int? TwoDays { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDaysOrmore
        /// </summary>

        [DataMember(Name="threeDaysOrmore")]
        public int? ThreeDaysOrmore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingNotAvailableDetail {\n");
            sb.Append("  ToCharge: ").Append(ToCharge).Append("\n");
            sb.Append("  Transit: ").Append(Transit).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  ZeroDays: ").Append(ZeroDays).Append("\n");
            sb.Append("  OneDays: ").Append(OneDays).Append("\n");
            sb.Append("  TwoDays: ").Append(TwoDays).Append("\n");
            sb.Append("  ThreeDaysOrmore: ").Append(ThreeDaysOrmore).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TrackingNotAvailableDetail)obj);
        }

        /// <summary>
        /// Returns true if TrackingNotAvailableDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of TrackingNotAvailableDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingNotAvailableDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ToCharge == other.ToCharge ||
                    ToCharge != null &&
                    ToCharge.Equals(other.ToCharge)
                ) && 
                (
                    Transit == other.Transit ||
                    Transit != null &&
                    Transit.Equals(other.Transit)
                ) && 
                (
                    Download == other.Download ||
                    Download != null &&
                    Download.Equals(other.Download)
                ) && 
                (
                    ZeroDays == other.ZeroDays ||
                    ZeroDays != null &&
                    ZeroDays.Equals(other.ZeroDays)
                ) && 
                (
                    OneDays == other.OneDays ||
                    OneDays != null &&
                    OneDays.Equals(other.OneDays)
                ) && 
                (
                    TwoDays == other.TwoDays ||
                    TwoDays != null &&
                    TwoDays.Equals(other.TwoDays)
                ) && 
                (
                    ThreeDaysOrmore == other.ThreeDaysOrmore ||
                    ThreeDaysOrmore != null &&
                    ThreeDaysOrmore.Equals(other.ThreeDaysOrmore)
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
                    if (ToCharge != null)
                    hashCode = hashCode * 59 + ToCharge.GetHashCode();
                    if (Transit != null)
                    hashCode = hashCode * 59 + Transit.GetHashCode();
                    if (Download != null)
                    hashCode = hashCode * 59 + Download.GetHashCode();
                    if (ZeroDays != null)
                    hashCode = hashCode * 59 + ZeroDays.GetHashCode();
                    if (OneDays != null)
                    hashCode = hashCode * 59 + OneDays.GetHashCode();
                    if (TwoDays != null)
                    hashCode = hashCode * 59 + TwoDays.GetHashCode();
                    if (ThreeDaysOrmore != null)
                    hashCode = hashCode * 59 + ThreeDaysOrmore.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TrackingNotAvailableDetail left, TrackingNotAvailableDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TrackingNotAvailableDetail left, TrackingNotAvailableDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
