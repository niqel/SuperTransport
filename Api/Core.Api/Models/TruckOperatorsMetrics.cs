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
    public partial class TruckOperatorsMetrics : IEquatable<TruckOperatorsMetrics>
    { 
        /// <summary>
        /// Total
        /// </summary>
        /// <value>Total</value>

        [DataMember(Name="total")]
        public int? Total { get; set; }

        /// <summary>
        /// En operación
        /// </summary>
        /// <value>En operación</value>

        [DataMember(Name="operation")]
        public int? Operation { get; set; }

        /// <summary>
        /// Disponibles
        /// </summary>
        /// <value>Disponibles</value>

        [DataMember(Name="available")]
        public int? Available { get; set; }

        /// <summary>
        /// En descanso
        /// </summary>
        /// <value>En descanso</value>

        [DataMember(Name="work_break")]
        public int? WorkBreak { get; set; }

        /// <summary>
        /// Por liquidar
        /// </summary>
        /// <value>Por liquidar</value>

        [DataMember(Name="liquidate")]
        public int? Liquidate { get; set; }

        /// <summary>
        /// En capacitación
        /// </summary>
        /// <value>En capacitación</value>

        [DataMember(Name="training")]
        public int? Training { get; set; }

        /// <summary>
        /// Permisos Especiales
        /// </summary>
        /// <value>Permisos Especiales</value>

        [DataMember(Name="special_permission")]
        public int? SpecialPermission { get; set; }

        /// <summary>
        /// Incapacitado
        /// </summary>
        /// <value>Incapacitado</value>

        [DataMember(Name="disabled")]
        public int? Disabled { get; set; }

        /// <summary>
        /// En vacaciones
        /// </summary>
        /// <value>En vacaciones</value>

        [DataMember(Name="vacation")]
        public int? Vacation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TruckOperatorsMetrics {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  WorkBreak: ").Append(WorkBreak).Append("\n");
            sb.Append("  Liquidate: ").Append(Liquidate).Append("\n");
            sb.Append("  Training: ").Append(Training).Append("\n");
            sb.Append("  SpecialPermission: ").Append(SpecialPermission).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Vacation: ").Append(Vacation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TruckOperatorsMetrics)obj);
        }

        /// <summary>
        /// Returns true if TruckOperatorsMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of TruckOperatorsMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TruckOperatorsMetrics other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Total == other.Total ||
                    Total != null &&
                    Total.Equals(other.Total)
                ) && 
                (
                    Operation == other.Operation ||
                    Operation != null &&
                    Operation.Equals(other.Operation)
                ) && 
                (
                    Available == other.Available ||
                    Available != null &&
                    Available.Equals(other.Available)
                ) && 
                (
                    WorkBreak == other.WorkBreak ||
                    WorkBreak != null &&
                    WorkBreak.Equals(other.WorkBreak)
                ) && 
                (
                    Liquidate == other.Liquidate ||
                    Liquidate != null &&
                    Liquidate.Equals(other.Liquidate)
                ) && 
                (
                    Training == other.Training ||
                    Training != null &&
                    Training.Equals(other.Training)
                ) && 
                (
                    SpecialPermission == other.SpecialPermission ||
                    SpecialPermission != null &&
                    SpecialPermission.Equals(other.SpecialPermission)
                ) && 
                (
                    Disabled == other.Disabled ||
                    Disabled != null &&
                    Disabled.Equals(other.Disabled)
                ) && 
                (
                    Vacation == other.Vacation ||
                    Vacation != null &&
                    Vacation.Equals(other.Vacation)
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
                    if (Total != null)
                    hashCode = hashCode * 59 + Total.GetHashCode();
                    if (Operation != null)
                    hashCode = hashCode * 59 + Operation.GetHashCode();
                    if (Available != null)
                    hashCode = hashCode * 59 + Available.GetHashCode();
                    if (WorkBreak != null)
                    hashCode = hashCode * 59 + WorkBreak.GetHashCode();
                    if (Liquidate != null)
                    hashCode = hashCode * 59 + Liquidate.GetHashCode();
                    if (Training != null)
                    hashCode = hashCode * 59 + Training.GetHashCode();
                    if (SpecialPermission != null)
                    hashCode = hashCode * 59 + SpecialPermission.GetHashCode();
                    if (Disabled != null)
                    hashCode = hashCode * 59 + Disabled.GetHashCode();
                    if (Vacation != null)
                    hashCode = hashCode * 59 + Vacation.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TruckOperatorsMetrics left, TruckOperatorsMetrics right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TruckOperatorsMetrics left, TruckOperatorsMetrics right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
