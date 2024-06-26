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
    /// LatestHeadlinesResponse DTO class.
    /// </summary>
    [DataContract(Name = "LatestHeadlinesResponse")]
    public partial class LatestHeadlinesResponse : IEquatable<LatestHeadlinesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestHeadlinesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LatestHeadlinesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestHeadlinesResponse" /> class.
        /// </summary>
        /// <param name="status">status (default to &quot;ok&quot;).</param>
        /// <param name="totalHits">totalHits (required).</param>
        /// <param name="page">page (required).</param>
        /// <param name="totalPages">totalPages (required).</param>
        /// <param name="pageSize">pageSize (required).</param>
        /// <param name="articles">articles (required).</param>
        /// <param name="userInput">userInput (required).</param>
        public LatestHeadlinesResponse(string status = "ok", int totalHits = default(int), int page = default(int), int totalPages = default(int), int pageSize = default(int), List<Object> articles = default(List<Object>), Object userInput = default(Object))
        {
            this.TotalHits = totalHits;
            this.Page = page;
            this.TotalPages = totalPages;
            this.PageSize = pageSize;
            // to ensure "articles" is required (not null)
            if (articles == null)
            {
                throw new ArgumentNullException("articles is a required property for LatestHeadlinesResponse and cannot be null");
            }
            this.Articles = articles;
            // to ensure "userInput" is required (not null)
            if (userInput == null)
            {
                throw new ArgumentNullException("userInput is a required property for LatestHeadlinesResponse and cannot be null");
            }
            this.UserInput = userInput;
            // use default value if no "status" provided
            this.Status = status ?? "ok";
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets TotalHits
        /// </summary>
        [DataMember(Name = "total_hits", IsRequired = true, EmitDefaultValue = true)]
        public int TotalHits { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", IsRequired = true, EmitDefaultValue = true)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name = "total_pages", IsRequired = true, EmitDefaultValue = true)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "page_size", IsRequired = true, EmitDefaultValue = true)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets Articles
        /// </summary>
        [DataMember(Name = "articles", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> Articles { get; set; }

        /// <summary>
        /// Gets or Sets UserInput
        /// </summary>
        [DataMember(Name = "user_input", IsRequired = true, EmitDefaultValue = true)]
        public Object UserInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LatestHeadlinesResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  UserInput: ").Append(UserInput).Append("\n");
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
            return this.Equals(input as LatestHeadlinesResponse);
        }

        /// <summary>
        /// Returns true if LatestHeadlinesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LatestHeadlinesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatestHeadlinesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TotalHits == input.TotalHits ||
                    this.TotalHits.Equals(input.TotalHits)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Articles == input.Articles ||
                    this.Articles != null &&
                    input.Articles != null &&
                    this.Articles.SequenceEqual(input.Articles)
                ) && 
                (
                    this.UserInput == input.UserInput ||
                    (this.UserInput != null &&
                    this.UserInput.Equals(input.UserInput))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalHits.GetHashCode();
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.Articles != null)
                {
                    hashCode = (hashCode * 59) + this.Articles.GetHashCode();
                }
                if (this.UserInput != null)
                {
                    hashCode = (hashCode * 59) + this.UserInput.GetHashCode();
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
