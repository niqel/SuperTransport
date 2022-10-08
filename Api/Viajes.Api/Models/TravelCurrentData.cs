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
    public partial class TravelCurrentData : IEquatable<TravelCurrentData>
    { 
        /// <summary>
        /// El id del viaje
        /// </summary>
        /// <value>El id del viaje</value>

        [DataMember(Name="idTrip")]
        public int? IdTrip { get; set; }

        /// <summary>
        /// Estatus del viaje
        /// </summary>
        /// <value>Estatus del viaje</value>

        [DataMember(Name="estatus")]
        public string Estatus { get; set; }

        /// <summary>
        /// Origen del viaje
        /// </summary>
        /// <value>Origen del viaje</value>

        [DataMember(Name="origen")]
        public string Origen { get; set; }

        /// <summary>
        /// Destino del viaje
        /// </summary>
        /// <value>Destino del viaje</value>

        [DataMember(Name="destino")]
        public string Destino { get; set; }

        /// <summary>
        /// fecha del viaje
        /// </summary>
        /// <value>fecha del viaje</value>

        [DataMember(Name="fecha_inicio")]
        public DateTime? FechaInicio { get; set; }

        /// <summary>
        /// Rendimiento esperado del diesel
        /// </summary>
        /// <value>Rendimiento esperado del diesel</value>

        [DataMember(Name="rendimiento_esperado_diesel")]
        public float? RendimientoEsperadoDiesel { get; set; }

        /// <summary>
        /// Rendimiento real del diesel
        /// </summary>
        /// <value>Rendimiento real del diesel</value>

        [DataMember(Name="rendimiento_real_diesel")]
        public float? RendimientoRealDiesel { get; set; }

        /// <summary>
        /// Tiempo para llegar a su destino
        /// </summary>
        /// <value>Tiempo para llegar a su destino</value>

        [DataMember(Name="eta")]
        public float? Eta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TravelCurrentData {\n");
            sb.Append("  IdTrip: ").Append(IdTrip).Append("\n");
            sb.Append("  Estatus: ").Append(Estatus).Append("\n");
            sb.Append("  Origen: ").Append(Origen).Append("\n");
            sb.Append("  Destino: ").Append(Destino).Append("\n");
            sb.Append("  FechaInicio: ").Append(FechaInicio).Append("\n");
            sb.Append("  RendimientoEsperadoDiesel: ").Append(RendimientoEsperadoDiesel).Append("\n");
            sb.Append("  RendimientoRealDiesel: ").Append(RendimientoRealDiesel).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TravelCurrentData)obj);
        }

        /// <summary>
        /// Returns true if TravelCurrentData instances are equal
        /// </summary>
        /// <param name="other">Instance of TravelCurrentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TravelCurrentData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdTrip == other.IdTrip ||
                    IdTrip != null &&
                    IdTrip.Equals(other.IdTrip)
                ) && 
                (
                    Estatus == other.Estatus ||
                    Estatus != null &&
                    Estatus.Equals(other.Estatus)
                ) && 
                (
                    Origen == other.Origen ||
                    Origen != null &&
                    Origen.Equals(other.Origen)
                ) && 
                (
                    Destino == other.Destino ||
                    Destino != null &&
                    Destino.Equals(other.Destino)
                ) && 
                (
                    FechaInicio == other.FechaInicio ||
                    FechaInicio != null &&
                    FechaInicio.Equals(other.FechaInicio)
                ) && 
                (
                    RendimientoEsperadoDiesel == other.RendimientoEsperadoDiesel ||
                    RendimientoEsperadoDiesel != null &&
                    RendimientoEsperadoDiesel.Equals(other.RendimientoEsperadoDiesel)
                ) && 
                (
                    RendimientoRealDiesel == other.RendimientoRealDiesel ||
                    RendimientoRealDiesel != null &&
                    RendimientoRealDiesel.Equals(other.RendimientoRealDiesel)
                ) && 
                (
                    Eta == other.Eta ||
                    Eta != null &&
                    Eta.Equals(other.Eta)
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
                    if (IdTrip != null)
                    hashCode = hashCode * 59 + IdTrip.GetHashCode();
                    if (Estatus != null)
                    hashCode = hashCode * 59 + Estatus.GetHashCode();
                    if (Origen != null)
                    hashCode = hashCode * 59 + Origen.GetHashCode();
                    if (Destino != null)
                    hashCode = hashCode * 59 + Destino.GetHashCode();
                    if (FechaInicio != null)
                    hashCode = hashCode * 59 + FechaInicio.GetHashCode();
                    if (RendimientoEsperadoDiesel != null)
                    hashCode = hashCode * 59 + RendimientoEsperadoDiesel.GetHashCode();
                    if (RendimientoRealDiesel != null)
                    hashCode = hashCode * 59 + RendimientoRealDiesel.GetHashCode();
                    if (Eta != null)
                    hashCode = hashCode * 59 + Eta.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TravelCurrentData left, TravelCurrentData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TravelCurrentData left, TravelCurrentData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
