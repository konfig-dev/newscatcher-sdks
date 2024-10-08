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
    /// Sources request DTO
    /// </summary>
    [DataContract(Name = "SourcesRequest")]
    public partial class SourcesRequest : IEquatable<SourcesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourcesRequest" /> class.
        /// </summary>
        /// <param name="lang">lang.</param>
        /// <param name="countries">countries.</param>
        /// <param name="predefinedSources">predefinedSources.</param>
        /// <param name="includeAdditionalInfo">includeAdditionalInfo.</param>
        /// <param name="fromRank">fromRank.</param>
        /// <param name="toRank">toRank.</param>
        /// <param name="sourceName">sourceName.</param>
        /// <param name="sourceUrl">sourceUrl.</param>
        /// <param name="isNewsDomain">isNewsDomain.</param>
        /// <param name="newsDomainType">newsDomainType.</param>
        /// <param name="newsType">newsType.</param>
        public SourcesRequest(Object lang = default(Object), Object countries = default(Object), Object predefinedSources = default(Object), bool includeAdditionalInfo = default(bool), int fromRank = default(int), int toRank = default(int), Object sourceName = default(Object), Object sourceUrl = default(Object), bool isNewsDomain = default(bool), Object newsDomainType = default(Object), Object newsType = default(Object))
        {
            this.Lang = lang;
            this.Countries = countries;
            this.PredefinedSources = predefinedSources;
            this.IncludeAdditionalInfo = includeAdditionalInfo;
            this.FromRank = fromRank;
            this.ToRank = toRank;
            this.SourceName = sourceName;
            this.SourceUrl = sourceUrl;
            this.IsNewsDomain = isNewsDomain;
            this.NewsDomainType = newsDomainType;
            this.NewsType = newsType;
        }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [DataMember(Name = "lang", EmitDefaultValue = true)]
        public Object Lang { get; set; }

        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name = "countries", EmitDefaultValue = true)]
        public Object Countries { get; set; }

        /// <summary>
        /// Gets or Sets PredefinedSources
        /// </summary>
        [DataMember(Name = "predefined_sources", EmitDefaultValue = true)]
        public Object PredefinedSources { get; set; }

        /// <summary>
        /// Gets or Sets IncludeAdditionalInfo
        /// </summary>
        [DataMember(Name = "include_additional_info", EmitDefaultValue = true)]
        public bool IncludeAdditionalInfo { get; set; }

        /// <summary>
        /// Gets or Sets FromRank
        /// </summary>
        [DataMember(Name = "from_rank", EmitDefaultValue = false)]
        public int FromRank { get; set; }

        /// <summary>
        /// Gets or Sets ToRank
        /// </summary>
        [DataMember(Name = "to_rank", EmitDefaultValue = false)]
        public int ToRank { get; set; }

        /// <summary>
        /// Gets or Sets SourceName
        /// </summary>
        [DataMember(Name = "source_name", EmitDefaultValue = true)]
        public Object SourceName { get; set; }

        /// <summary>
        /// Gets or Sets SourceUrl
        /// </summary>
        [DataMember(Name = "source_url", EmitDefaultValue = true)]
        public Object SourceUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsNewsDomain
        /// </summary>
        [DataMember(Name = "is_news_domain", EmitDefaultValue = true)]
        public bool IsNewsDomain { get; set; }

        /// <summary>
        /// Gets or Sets NewsDomainType
        /// </summary>
        [DataMember(Name = "news_domain_type", EmitDefaultValue = true)]
        public Object NewsDomainType { get; set; }

        /// <summary>
        /// Gets or Sets NewsType
        /// </summary>
        [DataMember(Name = "news_type", EmitDefaultValue = true)]
        public Object NewsType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourcesRequest {\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  PredefinedSources: ").Append(PredefinedSources).Append("\n");
            sb.Append("  IncludeAdditionalInfo: ").Append(IncludeAdditionalInfo).Append("\n");
            sb.Append("  FromRank: ").Append(FromRank).Append("\n");
            sb.Append("  ToRank: ").Append(ToRank).Append("\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  IsNewsDomain: ").Append(IsNewsDomain).Append("\n");
            sb.Append("  NewsDomainType: ").Append(NewsDomainType).Append("\n");
            sb.Append("  NewsType: ").Append(NewsType).Append("\n");
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
            return this.Equals(input as SourcesRequest);
        }

        /// <summary>
        /// Returns true if SourcesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SourcesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourcesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                ) && 
                (
                    this.Countries == input.Countries ||
                    (this.Countries != null &&
                    this.Countries.Equals(input.Countries))
                ) && 
                (
                    this.PredefinedSources == input.PredefinedSources ||
                    (this.PredefinedSources != null &&
                    this.PredefinedSources.Equals(input.PredefinedSources))
                ) && 
                (
                    this.IncludeAdditionalInfo == input.IncludeAdditionalInfo ||
                    this.IncludeAdditionalInfo.Equals(input.IncludeAdditionalInfo)
                ) && 
                (
                    this.FromRank == input.FromRank ||
                    this.FromRank.Equals(input.FromRank)
                ) && 
                (
                    this.ToRank == input.ToRank ||
                    this.ToRank.Equals(input.ToRank)
                ) && 
                (
                    this.SourceName == input.SourceName ||
                    (this.SourceName != null &&
                    this.SourceName.Equals(input.SourceName))
                ) && 
                (
                    this.SourceUrl == input.SourceUrl ||
                    (this.SourceUrl != null &&
                    this.SourceUrl.Equals(input.SourceUrl))
                ) && 
                (
                    this.IsNewsDomain == input.IsNewsDomain ||
                    this.IsNewsDomain.Equals(input.IsNewsDomain)
                ) && 
                (
                    this.NewsDomainType == input.NewsDomainType ||
                    (this.NewsDomainType != null &&
                    this.NewsDomainType.Equals(input.NewsDomainType))
                ) && 
                (
                    this.NewsType == input.NewsType ||
                    (this.NewsType != null &&
                    this.NewsType.Equals(input.NewsType))
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
                if (this.Lang != null)
                {
                    hashCode = (hashCode * 59) + this.Lang.GetHashCode();
                }
                if (this.Countries != null)
                {
                    hashCode = (hashCode * 59) + this.Countries.GetHashCode();
                }
                if (this.PredefinedSources != null)
                {
                    hashCode = (hashCode * 59) + this.PredefinedSources.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeAdditionalInfo.GetHashCode();
                hashCode = (hashCode * 59) + this.FromRank.GetHashCode();
                hashCode = (hashCode * 59) + this.ToRank.GetHashCode();
                if (this.SourceName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceName.GetHashCode();
                }
                if (this.SourceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SourceUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsNewsDomain.GetHashCode();
                if (this.NewsDomainType != null)
                {
                    hashCode = (hashCode * 59) + this.NewsDomainType.GetHashCode();
                }
                if (this.NewsType != null)
                {
                    hashCode = (hashCode * 59) + this.NewsType.GetHashCode();
                }
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
