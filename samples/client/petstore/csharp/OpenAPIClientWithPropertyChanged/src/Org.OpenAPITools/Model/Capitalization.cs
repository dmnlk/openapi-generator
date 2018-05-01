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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Capitalization
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class Capitalization :  IEquatable<Capitalization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capitalization" /> class.
        /// </summary>
        /// <param name="smallCamel">smallCamel.</param>
        /// <param name="capitalCamel">capitalCamel.</param>
        /// <param name="smallSnake">smallSnake.</param>
        /// <param name="capitalSnake">capitalSnake.</param>
        /// <param name="sCAETHFlowPoints">sCAETHFlowPoints.</param>
        /// <param name="aTTNAME">Name of the pet .</param>
        public Capitalization(string smallCamel = default(string), string capitalCamel = default(string), string smallSnake = default(string), string capitalSnake = default(string), string sCAETHFlowPoints = default(string), string aTTNAME = default(string))
        {
            this.SmallCamel = smallCamel;
            this.CapitalCamel = capitalCamel;
            this.SmallSnake = smallSnake;
            this.CapitalSnake = capitalSnake;
            this.SCAETHFlowPoints = sCAETHFlowPoints;
            this.ATT_NAME = aTTNAME;
        }
        
        /// <summary>
        /// Gets or Sets SmallCamel
        /// </summary>
        [DataMember(Name="smallCamel", EmitDefaultValue=false)]
        public string SmallCamel { get; set; }

        /// <summary>
        /// Gets or Sets CapitalCamel
        /// </summary>
        [DataMember(Name="CapitalCamel", EmitDefaultValue=false)]
        public string CapitalCamel { get; set; }

        /// <summary>
        /// Gets or Sets SmallSnake
        /// </summary>
        [DataMember(Name="small_Snake", EmitDefaultValue=false)]
        public string SmallSnake { get; set; }

        /// <summary>
        /// Gets or Sets CapitalSnake
        /// </summary>
        [DataMember(Name="Capital_Snake", EmitDefaultValue=false)]
        public string CapitalSnake { get; set; }

        /// <summary>
        /// Gets or Sets SCAETHFlowPoints
        /// </summary>
        [DataMember(Name="SCA_ETH_Flow_Points", EmitDefaultValue=false)]
        public string SCAETHFlowPoints { get; set; }

        /// <summary>
        /// Name of the pet 
        /// </summary>
        /// <value>Name of the pet </value>
        [DataMember(Name="ATT_NAME", EmitDefaultValue=false)]
        public string ATT_NAME { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Capitalization {\n");
            sb.Append("  SmallCamel: ").Append(SmallCamel).Append("\n");
            sb.Append("  CapitalCamel: ").Append(CapitalCamel).Append("\n");
            sb.Append("  SmallSnake: ").Append(SmallSnake).Append("\n");
            sb.Append("  CapitalSnake: ").Append(CapitalSnake).Append("\n");
            sb.Append("  SCAETHFlowPoints: ").Append(SCAETHFlowPoints).Append("\n");
            sb.Append("  ATT_NAME: ").Append(ATT_NAME).Append("\n");
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
            return this.Equals(input as Capitalization);
        }

        /// <summary>
        /// Returns true if Capitalization instances are equal
        /// </summary>
        /// <param name="input">Instance of Capitalization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Capitalization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmallCamel == input.SmallCamel ||
                    (this.SmallCamel != null &&
                    this.SmallCamel.Equals(input.SmallCamel))
                ) && 
                (
                    this.CapitalCamel == input.CapitalCamel ||
                    (this.CapitalCamel != null &&
                    this.CapitalCamel.Equals(input.CapitalCamel))
                ) && 
                (
                    this.SmallSnake == input.SmallSnake ||
                    (this.SmallSnake != null &&
                    this.SmallSnake.Equals(input.SmallSnake))
                ) && 
                (
                    this.CapitalSnake == input.CapitalSnake ||
                    (this.CapitalSnake != null &&
                    this.CapitalSnake.Equals(input.CapitalSnake))
                ) && 
                (
                    this.SCAETHFlowPoints == input.SCAETHFlowPoints ||
                    (this.SCAETHFlowPoints != null &&
                    this.SCAETHFlowPoints.Equals(input.SCAETHFlowPoints))
                ) && 
                (
                    this.ATT_NAME == input.ATT_NAME ||
                    (this.ATT_NAME != null &&
                    this.ATT_NAME.Equals(input.ATT_NAME))
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
                if (this.SmallCamel != null)
                    hashCode = hashCode * 59 + this.SmallCamel.GetHashCode();
                if (this.CapitalCamel != null)
                    hashCode = hashCode * 59 + this.CapitalCamel.GetHashCode();
                if (this.SmallSnake != null)
                    hashCode = hashCode * 59 + this.SmallSnake.GetHashCode();
                if (this.CapitalSnake != null)
                    hashCode = hashCode * 59 + this.CapitalSnake.GetHashCode();
                if (this.SCAETHFlowPoints != null)
                    hashCode = hashCode * 59 + this.SCAETHFlowPoints.GetHashCode();
                if (this.ATT_NAME != null)
                    hashCode = hashCode * 59 + this.ATT_NAME.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
