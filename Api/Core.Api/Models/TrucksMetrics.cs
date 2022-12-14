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
    public partial class TrucksMetrics : IEquatable<TrucksMetrics>
    { 
        /// <summary>
        /// Total equipo requerido
        /// </summary>
        /// <value>Total equipo requerido</value>

        [DataMember(Name="required")]
        public int? Required { get; set; }

        /// <summary>
        /// Total equipo cargado
        /// </summary>
        /// <value>Total equipo cargado</value>

        [DataMember(Name="loaded")]
        public int? Loaded { get; set; }

        /// <summary>
        /// Total equipo posicionado
        /// </summary>
        /// <value>Total equipo posicionado</value>

        [DataMember(Name="positioned")]
        public int? Positioned { get; set; }

        /// <summary>
        /// Equipo sin programa de carga
        /// </summary>
        /// <value>Equipo sin programa de carga</value>

        [DataMember(Name="no_scheduled_load")]
        public int? NoScheduledLoad { get; set; }

        /// <summary>
        /// Porcentaje de flota cargada
        /// </summary>
        /// <value>Porcentaje de flota cargada</value>

        [DataMember(Name="loaded_vs_fleet")]
        public float? LoadedVsFleet { get; set; }

        /// <summary>
        /// Porcentaje Forecast vs Posicionado Cargado
        /// </summary>
        /// <value>Porcentaje Forecast vs Posicionado Cargado</value>

        [DataMember(Name="loaded_vs_forecast")]
        public float? LoadedVsForecast { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrucksMetrics {\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Loaded: ").Append(Loaded).Append("\n");
            sb.Append("  Positioned: ").Append(Positioned).Append("\n");
            sb.Append("  NoScheduledLoad: ").Append(NoScheduledLoad).Append("\n");
            sb.Append("  LoadedVsFleet: ").Append(LoadedVsFleet).Append("\n");
            sb.Append("  LoadedVsForecast: ").Append(LoadedVsForecast).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TrucksMetrics)obj);
        }

        /// <summary>
        /// Returns true if TrucksMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of TrucksMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrucksMetrics other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Required == other.Required ||
                    Required != null &&
                    Required.Equals(other.Required)
                ) && 
                (
                    Loaded == other.Loaded ||
                    Loaded != null &&
                    Loaded.Equals(other.Loaded)
                ) && 
                (
                    Positioned == other.Positioned ||
                    Positioned != null &&
                    Positioned.Equals(other.Positioned)
                ) && 
                (
                    NoScheduledLoad == other.NoScheduledLoad ||
                    NoScheduledLoad != null &&
                    NoScheduledLoad.Equals(other.NoScheduledLoad)
                ) && 
                (
                    LoadedVsFleet == other.LoadedVsFleet ||
                    LoadedVsFleet != null &&
                    LoadedVsFleet.Equals(other.LoadedVsFleet)
                ) && 
                (
                    LoadedVsForecast == other.LoadedVsForecast ||
                    LoadedVsForecast != null &&
                    LoadedVsForecast.Equals(other.LoadedVsForecast)
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
                    if (Required != null)
                    hashCode = hashCode * 59 + Required.GetHashCode();
                    if (Loaded != null)
                    hashCode = hashCode * 59 + Loaded.GetHashCode();
                    if (Positioned != null)
                    hashCode = hashCode * 59 + Positioned.GetHashCode();
                    if (NoScheduledLoad != null)
                    hashCode = hashCode * 59 + NoScheduledLoad.GetHashCode();
                    if (LoadedVsFleet != null)
                    hashCode = hashCode * 59 + LoadedVsFleet.GetHashCode();
                    if (LoadedVsForecast != null)
                    hashCode = hashCode * 59 + LoadedVsForecast.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TrucksMetrics left, TrucksMetrics right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TrucksMetrics left, TrucksMetrics right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
