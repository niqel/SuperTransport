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
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum Status
        {
            /// <summary>
            /// Enum OriginEnum for Released
            /// </summary>
            [EnumMember(Value = "released")]
            Released = 0,
            /// <summary>
            /// Enum DestinationEnum for Closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 1,
            /// <summary>
            /// Enum OfficeEnum for Open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 2,

            /// <summary>
            /// Enum OfficeEnum for Canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 3
    }
}