/*
 * NewsCatcher News API V2
 *
 * NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: team@newscatcherapi.com
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
    /// Model200ResponseLatest
    /// </summary>
    [DataContract(Name = "200_response_latest")]
    public partial class Model200ResponseLatest : IEquatable<Model200ResponseLatest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public SuccessStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Model200ResponseLatest" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="totalHits">totalHits.</param>
        /// <param name="page">page.</param>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="articles">articles.</param>
        /// <param name="userInput">userInput.</param>
        public Model200ResponseLatest(SuccessStatus? status = default(SuccessStatus?), int totalHits = default(int), int page = default(int), int totalPages = default(int), int pageSize = default(int), List<ArticleInner> articles = default(List<ArticleInner>), LatestHeadlinesUserInput userInput = default(LatestHeadlinesUserInput))
        {
            this.Status = status;
            this.TotalHits = totalHits;
            this.Page = page;
            this.TotalPages = totalPages;
            this.PageSize = pageSize;
            this.Articles = articles;
            this.UserInput = userInput;
        }

        /// <summary>
        /// Gets or Sets TotalHits
        /// </summary>
        [DataMember(Name = "total_hits", EmitDefaultValue = false)]
        public int TotalHits { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets Articles
        /// </summary>
        [DataMember(Name = "articles", EmitDefaultValue = false)]
        public List<ArticleInner> Articles { get; set; }

        /// <summary>
        /// Gets or Sets UserInput
        /// </summary>
        [DataMember(Name = "user_input", EmitDefaultValue = false)]
        public LatestHeadlinesUserInput UserInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Model200ResponseLatest {\n");
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
            return this.Equals(input as Model200ResponseLatest);
        }

        /// <summary>
        /// Returns true if Model200ResponseLatest instances are equal
        /// </summary>
        /// <param name="input">Instance of Model200ResponseLatest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model200ResponseLatest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
