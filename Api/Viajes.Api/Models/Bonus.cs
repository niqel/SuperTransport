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
    /// Bono
    /// </summary>
    [DataContract]
    public partial class Bonus : IEquatable<Bonus>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets TravelId
        /// </summary>

        [DataMember(Name="travel_id")]
        public decimal? TravelId { get; set; }

        /// <summary>
        /// Gets or Sets PayingId
        /// </summary>

        [DataMember(Name="paying_id")]
        public decimal? PayingId { get; set; }

        /// <summary>
        /// Gets or Sets OperatorId
        /// </summary>

        [DataMember(Name="operator_id")]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Gets or Sets OperatorName
        /// </summary>

        [DataMember(Name="operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// Gets or Sets OperatorType
        /// </summary>

        [DataMember(Name="operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// Gets or Sets OperationBonus
        /// </summary>

        [DataMember(Name="operation_bonus")]
        public Object OperationBonus { get; set; }

        /// <summary>
        /// Gets or Sets QualityBonus
        /// </summary>

        [DataMember(Name="quality_bonus")]
        public Object QualityBonus { get; set; }

        /// <summary>
        /// Gets or Sets PeopleBonus
        /// </summary>

        [DataMember(Name="people_bonus")]
        public Object PeopleBonus { get; set; }

        /// <summary>
        /// Gets or Sets FinancesBonus
        /// </summary>

        [DataMember(Name="finances_bonus")]
        public Object FinancesBonus { get; set; }

        /// <summary>
        /// Gets or Sets CustomerBonus
        /// </summary>

        [DataMember(Name="customer_bonus")]
        public Object CustomerBonus { get; set; }

        /// <summary>
        /// Gets or Sets InfraestructureBonus
        /// </summary>

        [DataMember(Name="infraestructure_bonus")]
        public Object InfraestructureBonus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bonus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TravelId: ").Append(TravelId).Append("\n");
            sb.Append("  PayingId: ").Append(PayingId).Append("\n");
            sb.Append("  OperatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  OperatorName: ").Append(OperatorName).Append("\n");
            sb.Append("  OperatorType: ").Append(OperatorType).Append("\n");
            sb.Append("  OperationBonus: ").Append(OperationBonus).Append("\n");
            sb.Append("  QualityBonus: ").Append(QualityBonus).Append("\n");
            sb.Append("  PeopleBonus: ").Append(PeopleBonus).Append("\n");
            sb.Append("  FinancesBonus: ").Append(FinancesBonus).Append("\n");
            sb.Append("  CustomerBonus: ").Append(CustomerBonus).Append("\n");
            sb.Append("  InfraestructureBonus: ").Append(InfraestructureBonus).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Bonus)obj);
        }

        /// <summary>
        /// Returns true if Bonus instances are equal
        /// </summary>
        /// <param name="other">Instance of Bonus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bonus other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    TravelId == other.TravelId ||
                    TravelId != null &&
                    TravelId.Equals(other.TravelId)
                ) && 
                (
                    PayingId == other.PayingId ||
                    PayingId != null &&
                    PayingId.Equals(other.PayingId)
                ) && 
                (
                    OperatorId == other.OperatorId ||
                    OperatorId != null &&
                    OperatorId.Equals(other.OperatorId)
                ) && 
                (
                    OperatorName == other.OperatorName ||
                    OperatorName != null &&
                    OperatorName.Equals(other.OperatorName)
                ) && 
                (
                    OperatorType == other.OperatorType ||
                    OperatorType != null &&
                    OperatorType.Equals(other.OperatorType)
                ) && 
                (
                    OperationBonus == other.OperationBonus ||
                    OperationBonus != null &&
                    OperationBonus.Equals(other.OperationBonus)
                ) && 
                (
                    QualityBonus == other.QualityBonus ||
                    QualityBonus != null &&
                    QualityBonus.Equals(other.QualityBonus)
                ) && 
                (
                    PeopleBonus == other.PeopleBonus ||
                    PeopleBonus != null &&
                    PeopleBonus.Equals(other.PeopleBonus)
                ) && 
                (
                    FinancesBonus == other.FinancesBonus ||
                    FinancesBonus != null &&
                    FinancesBonus.Equals(other.FinancesBonus)
                ) && 
                (
                    CustomerBonus == other.CustomerBonus ||
                    CustomerBonus != null &&
                    CustomerBonus.Equals(other.CustomerBonus)
                ) && 
                (
                    InfraestructureBonus == other.InfraestructureBonus ||
                    InfraestructureBonus != null &&
                    InfraestructureBonus.Equals(other.InfraestructureBonus)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (TravelId != null)
                    hashCode = hashCode * 59 + TravelId.GetHashCode();
                    if (PayingId != null)
                    hashCode = hashCode * 59 + PayingId.GetHashCode();
                    if (OperatorId != null)
                    hashCode = hashCode * 59 + OperatorId.GetHashCode();
                    if (OperatorName != null)
                    hashCode = hashCode * 59 + OperatorName.GetHashCode();
                    if (OperatorType != null)
                    hashCode = hashCode * 59 + OperatorType.GetHashCode();
                    if (OperationBonus != null)
                    hashCode = hashCode * 59 + OperationBonus.GetHashCode();
                    if (QualityBonus != null)
                    hashCode = hashCode * 59 + QualityBonus.GetHashCode();
                    if (PeopleBonus != null)
                    hashCode = hashCode * 59 + PeopleBonus.GetHashCode();
                    if (FinancesBonus != null)
                    hashCode = hashCode * 59 + FinancesBonus.GetHashCode();
                    if (CustomerBonus != null)
                    hashCode = hashCode * 59 + CustomerBonus.GetHashCode();
                    if (InfraestructureBonus != null)
                    hashCode = hashCode * 59 + InfraestructureBonus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Bonus left, Bonus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Bonus left, Bonus right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}