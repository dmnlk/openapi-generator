/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MapTest
    /// </summary>
    [DataContract]
    public partial class MapTest :  IEquatable<MapTest>
    {
        /// <summary>
        /// Defines Inner
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InnerEnum
        {
            
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            [EnumMember(Value = "UPPER")]
            UPPER = 1,
            
            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            [EnumMember(Value = "lower")]
            Lower = 2
        }


        /// <summary>
        /// Gets or Sets MapOfEnumString
        /// </summary>
        [DataMember(Name="map_of_enum_string", EmitDefaultValue=false)]
        public Dictionary<string, InnerEnum> MapOfEnumString { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MapTest" /> class.
        /// </summary>
        /// <param name="mapMapOfString">mapMapOfString.</param>
        /// <param name="mapOfEnumString">mapOfEnumString.</param>
        public MapTest(Dictionary<string, Dictionary<string, string>> mapMapOfString = default(Dictionary<string, Dictionary<string, string>>), Dictionary<string, InnerEnum> mapOfEnumString = default(Dictionary<string, InnerEnum>))
        {
            this.MapMapOfString = mapMapOfString;
            this.MapOfEnumString = mapOfEnumString;
        }
        
        /// <summary>
        /// Gets or Sets MapMapOfString
        /// </summary>
        [DataMember(Name="map_map_of_string", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> MapMapOfString { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MapTest {\n");
            sb.Append("  MapMapOfString: ").Append(MapMapOfString).Append("\n");
            sb.Append("  MapOfEnumString: ").Append(MapOfEnumString).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MapTest);
        }

        /// <summary>
        /// Returns true if MapTest instances are equal
        /// </summary>
        /// <param name="input">Instance of MapTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapTest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MapMapOfString == input.MapMapOfString ||
                    this.MapMapOfString != null &&
                    this.MapMapOfString.SequenceEqual(input.MapMapOfString)
                ) && 
                (
                    this.MapOfEnumString == input.MapOfEnumString ||
                    this.MapOfEnumString != null &&
                    this.MapOfEnumString.SequenceEqual(input.MapOfEnumString)
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
                int hashCode = 41;
                if (this.MapMapOfString != null)
                    hashCode = hashCode * 59 + this.MapMapOfString.GetHashCode();
                if (this.MapOfEnumString != null)
                    hashCode = hashCode * 59 + this.MapOfEnumString.GetHashCode();
                return hashCode;
            }
        }
    }

}
