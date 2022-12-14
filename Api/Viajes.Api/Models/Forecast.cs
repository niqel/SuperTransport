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
    public partial class Forecast : IEquatable<Forecast>
    { 
        /// <summary>
        /// El id de este cliente
        /// </summary>
        /// <value>El id de este cliente</value>
        [Required]
        [DataMember(Name="customer")]
        public int? Customer { get; set; }

        /// <summary>
        /// El id de la localización del origen
        /// </summary>
        /// <value>El id de la localización del origen</value>
        [Required]
        [DataMember(Name="origin")]
        public int? Origin { get; set; }

        /// <summary>
        /// El id del tipo de mercado
        /// </summary>
        /// <value>El id del tipo de mercado</value>
        [Required]
        [DataMember(Name="market_type")]
        public int? MarketType { get; set; }

        /// <summary>
        /// Cantidad de Vins en el Plan
        /// </summary>
        /// <value>Cantidad de Vins en el Plan</value>
        [Required]
        [DataMember(Name="truck_type")]
        public int? TruckType { get; set; }

        /// <summary>
        /// Fecha programada
        /// </summary>
        /// <value>Fecha programada</value>
        [Required]
        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Cantidad de tractores solicitados
        /// </summary>
        /// <value>Cantidad de tractores solicitados</value>
        [DataMember(Name="trucks_quantity")]
        public int? TrucksQuantity { get; set; }

        /// <summary>
        /// Valor editado de la cantidad de tractores solicitados
        /// </summary>
        /// <value>Valor editado de la cantidad de tractores solicitados</value>
        [DataMember(Name="trucks_quantity_edited")]
        public int? TrucksQuantityEdited { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Forecast {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  MarketType: ").Append(MarketType).Append("\n");
            sb.Append("  TruckType: ").Append(TruckType).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  TrucksQuantity: ").Append(TrucksQuantity).Append("\n");
            sb.Append("  TrucksQuantityEdited: ").Append(TrucksQuantityEdited).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Forecast)obj);
        }

        /// <summary>
        /// Returns true if Forecast instances are equal
        /// </summary>
        /// <param name="other">Instance of Forecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Forecast other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Customer == other.Customer ||
                    Customer != null &&
                    Customer.Equals(other.Customer)
                ) && 
                (
                    Origin == other.Origin ||
                    Origin != null &&
                    Origin.Equals(other.Origin)
                ) && 
                (
                    MarketType == other.MarketType ||
                    MarketType != null &&
                    MarketType.Equals(other.MarketType)
                ) && 
                (
                    TruckType == other.TruckType ||
                    TruckType != null &&
                    TruckType.Equals(other.TruckType)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    TrucksQuantity == other.TrucksQuantity ||
                    TrucksQuantity != null &&
                    TrucksQuantity.Equals(other.TrucksQuantity)
                ) && 
                (
                    TrucksQuantityEdited == other.TrucksQuantityEdited ||
                    TrucksQuantityEdited != null &&
                    TrucksQuantityEdited.Equals(other.TrucksQuantityEdited)
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
                    if (Customer != null)
                    hashCode = hashCode * 59 + Customer.GetHashCode();
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                    if (MarketType != null)
                    hashCode = hashCode * 59 + MarketType.GetHashCode();
                    if (TruckType != null)
                    hashCode = hashCode * 59 + TruckType.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (TrucksQuantity != null)
                    hashCode = hashCode * 59 + TrucksQuantity.GetHashCode();
                    if (TrucksQuantityEdited != null)
                    hashCode = hashCode * 59 + TrucksQuantityEdited.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Forecast left, Forecast right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Forecast left, Forecast right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
