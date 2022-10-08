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
    public partial class RNonBudgetedExpenseData : IEquatable<RNonBudgetedExpenseData>
    { 
        /// <summary>
        /// Gets or Sets NonBudgetedExpense
        /// </summary>

        [DataMember(Name="nonBudgetedExpense")]
        public List<NonBudgetedExpense> NonBudgetedExpense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RNonBudgetedExpenseData {\n");
            sb.Append("  NonBudgetedExpense: ").Append(NonBudgetedExpense).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RNonBudgetedExpenseData)obj);
        }

        /// <summary>
        /// Returns true if RNonBudgetedExpenseData instances are equal
        /// </summary>
        /// <param name="other">Instance of RNonBudgetedExpenseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RNonBudgetedExpenseData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NonBudgetedExpense == other.NonBudgetedExpense ||
                    NonBudgetedExpense != null &&
                    NonBudgetedExpense.SequenceEqual(other.NonBudgetedExpense)
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
                    if (NonBudgetedExpense != null)
                    hashCode = hashCode * 59 + NonBudgetedExpense.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RNonBudgetedExpenseData left, RNonBudgetedExpenseData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RNonBudgetedExpenseData left, RNonBudgetedExpenseData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}