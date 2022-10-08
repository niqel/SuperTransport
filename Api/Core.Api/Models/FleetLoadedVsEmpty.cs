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
    public partial class FleetLoadedVsEmpty : IEquatable<FleetLoadedVsEmpty>
    {
        /// <summary>
        /// Fecha del movimiento
        /// </summary>
        /// <value>Fecha del movimiento</value>

        [DataMember(Name = "fecha")]
        public string Fecha { get; set; }

        /// <summary>
        /// Estatus del tractor
        /// </summary>
        /// <value>Estatus del tractor</value>

        [DataMember(Name = "truck_statusid")]
        public int? TruckStatusid { get; set; }

        /// <summary>
        /// Id del tractor
        /// </summary>
        /// <value>Id del tractor</value>

        [DataMember(Name = "truckid")]
        public int? Truckid { get; set; }

        /// <summary>
        /// Texto que determina si está o no cargado
        /// </summary>
        /// <value>Texto que determina si está o no cargado</value>

        [DataMember(Name = "cargado")]
        public string Cargado { get; set; }

        /// <summary>
        /// Nombre del tractor
        /// </summary>
        /// <value>Nombre del tractor</value>

        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Descripción del tractor
        /// </summary>
        /// <value>Descripción del tractor</value>

        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Nombre del operador
        /// </summary>
        /// <value>Nombre del operador</value>

        [DataMember(Name = "given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FleetLoadedVsEmpty {\n");
            sb.Append("  Fecha: ").Append(Fecha).Append("\n");
            sb.Append("  TruckStatusid: ").Append(TruckStatusid).Append("\n");
            sb.Append("  Truckid: ").Append(Truckid).Append("\n");
            sb.Append("  Cargado: ").Append(Cargado).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FleetLoadedVsEmpty)obj);
        }

        /// <summary>
        /// Returns true if FleetLoadedVsEmpty instances are equal
        /// </summary>
        /// <param name="other">Instance of FleetLoadedVsEmpty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FleetLoadedVsEmpty other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Fecha == other.Fecha ||
                    Fecha != null &&
                    Fecha.Equals(other.Fecha)
                ) &&
                (
                    TruckStatusid == other.TruckStatusid ||
                    TruckStatusid != null &&
                    TruckStatusid.Equals(other.TruckStatusid)
                ) &&
                (
                    Truckid == other.Truckid ||
                    Truckid != null &&
                    Truckid.Equals(other.Truckid)
                ) &&
                (
                    Cargado == other.Cargado ||
                    Cargado != null &&
                    Cargado.Equals(other.Cargado)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) &&
                (
                    GivenName == other.GivenName ||
                    GivenName != null &&
                    GivenName.Equals(other.GivenName)
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
                if (Fecha != null)
                    hashCode = hashCode * 59 + Fecha.GetHashCode();
                if (TruckStatusid != null)
                    hashCode = hashCode * 59 + TruckStatusid.GetHashCode();
                if (Truckid != null)
                    hashCode = hashCode * 59 + Truckid.GetHashCode();
                if (Cargado != null)
                    hashCode = hashCode * 59 + Cargado.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (GivenName != null)
                    hashCode = hashCode * 59 + GivenName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(FleetLoadedVsEmpty left, FleetLoadedVsEmpty right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FleetLoadedVsEmpty left, FleetLoadedVsEmpty right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
