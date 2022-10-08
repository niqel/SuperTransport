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
    /// Ticket
    /// </summary>
    [DataContract]
    public partial class Ticket : IEquatable<Ticket>
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
        public int? TravelId { get; set; }

        /// <summary>
        /// Gets or Sets OperatorId
        /// </summary>

        [DataMember(Name="operator_id")]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Gets or Sets DepartmentId
        /// </summary>

        [DataMember(Name="department_id")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Gets or Sets OperatorName
        /// </summary>

        [DataMember(Name="operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>

        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>

        [DataMember(Name="comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseTypeId
        /// </summary>

        [DataMember(Name="expense_type_id")]
        public int? ExpenseTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Evidences
        /// </summary>

        [DataMember(Name="evidences")]
        public List<decimal?> Evidences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ticket {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TravelId: ").Append(TravelId).Append("\n");
            sb.Append("  OperatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  OperatorName: ").Append(OperatorName).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ExpenseTypeId: ").Append(ExpenseTypeId).Append("\n");
            sb.Append("  Evidences: ").Append(Evidences).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Ticket)obj);
        }

        /// <summary>
        /// Returns true if Ticket instances are equal
        /// </summary>
        /// <param name="other">Instance of Ticket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ticket other)
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
                    OperatorId == other.OperatorId ||
                    OperatorId != null &&
                    OperatorId.Equals(other.OperatorId)
                ) && 
                (
                    DepartmentId == other.DepartmentId ||
                    DepartmentId != null &&
                    DepartmentId.Equals(other.DepartmentId)
                ) && 
                (
                    OperatorName == other.OperatorName ||
                    OperatorName != null &&
                    OperatorName.Equals(other.OperatorName)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    ExpenseTypeId == other.ExpenseTypeId ||
                    ExpenseTypeId != null &&
                    ExpenseTypeId.Equals(other.ExpenseTypeId)
                ) && 
                (
                    Evidences == other.Evidences ||
                    Evidences != null &&
                    Evidences.SequenceEqual(other.Evidences)
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
                    if (OperatorId != null)
                    hashCode = hashCode * 59 + OperatorId.GetHashCode();
                    if (DepartmentId != null)
                    hashCode = hashCode * 59 + DepartmentId.GetHashCode();
                    if (OperatorName != null)
                    hashCode = hashCode * 59 + OperatorName.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (ExpenseTypeId != null)
                    hashCode = hashCode * 59 + ExpenseTypeId.GetHashCode();
                    if (Evidences != null)
                    hashCode = hashCode * 59 + Evidences.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Ticket left, Ticket right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Ticket left, Ticket right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
