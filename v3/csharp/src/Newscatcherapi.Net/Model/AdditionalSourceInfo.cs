/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 * Generated by: https://konfigthis.com
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Newscatcherapi.Net.Client.OpenAPIDateConverter;

namespace Newscatcherapi.Net.Model
{
    /// <summary>
    /// AdditionalSourceInfo DTO class.
    /// </summary>
    [DataContract(Name = "AdditionalSourceInfo")]
    public partial class AdditionalSourceInfo : IEquatable<AdditionalSourceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalSourceInfo" /> class.
        /// </summary>
        /// <param name="nbArticlesFor7d">nbArticlesFor7d.</param>
        /// <param name="country">country.</param>
        /// <param name="rank">rank.</param>
        public AdditionalSourceInfo(int nbArticlesFor7d = default(int), string country = default(string), int rank = default(int))
        {
            this.NbArticlesFor7d = nbArticlesFor7d;
            this.Country = country;
            this.Rank = rank;
        }

        /// <summary>
        /// Gets or Sets NbArticlesFor7d
        /// </summary>
        [DataMember(Name = "nb_articles_for_7d", EmitDefaultValue = false)]
        public int NbArticlesFor7d { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int Rank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalSourceInfo {\n");
            sb.Append("  NbArticlesFor7d: ").Append(NbArticlesFor7d).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalSourceInfo);
        }

        /// <summary>
        /// Returns true if AdditionalSourceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalSourceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalSourceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NbArticlesFor7d == input.NbArticlesFor7d ||
                    this.NbArticlesFor7d.Equals(input.NbArticlesFor7d)
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
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
                hashCode = (hashCode * 59) + this.NbArticlesFor7d.GetHashCode();
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
