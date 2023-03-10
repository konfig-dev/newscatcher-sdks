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
    /// ArticleInner
    /// </summary>
    [DataContract(Name = "article_inner")]
    public partial class ArticleInner : IEquatable<ArticleInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleInner" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="author">author.</param>
        /// <param name="publishedDate">publishedDate.</param>
        /// <param name="publishedDatePrecision">publishedDatePrecision.</param>
        /// <param name="link">link.</param>
        /// <param name="cleanUrl">cleanUrl.</param>
        /// <param name="excerpt">excerpt.</param>
        /// <param name="summary">summary.</param>
        /// <param name="rights">rights.</param>
        /// <param name="rank">rank.</param>
        /// <param name="topic">topic.</param>
        /// <param name="country">country.</param>
        /// <param name="language">language.</param>
        /// <param name="authors">authors.</param>
        /// <param name="isOpinion">isOpinion.</param>
        /// <param name="twitterAccount">twitterAccount.</param>
        /// <param name="score">score.</param>
        /// <param name="id">id.</param>
        public ArticleInner(string title = default(string), string author = default(string), string publishedDate = default(string), string publishedDatePrecision = default(string), string link = default(string), string cleanUrl = default(string), string excerpt = default(string), string summary = default(string), string rights = default(string), int rank = default(int), string topic = default(string), string country = default(string), string language = default(string), string authors = default(string), bool isOpinion = default(bool), string twitterAccount = default(string), decimal? score = default(decimal?), string id = default(string))
        {
            this.Title = title;
            this.Author = author;
            this.PublishedDate = publishedDate;
            this.PublishedDatePrecision = publishedDatePrecision;
            this.Link = link;
            this.CleanUrl = cleanUrl;
            this.Excerpt = excerpt;
            this.Summary = summary;
            this.Rights = rights;
            this.Rank = rank;
            this.Topic = topic;
            this.Country = country;
            this.Language = language;
            this.Authors = authors;
            this.IsOpinion = isOpinion;
            this.TwitterAccount = twitterAccount;
            this.Score = score;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets PublishedDate
        /// </summary>
        [DataMember(Name = "published_date", EmitDefaultValue = false)]
        public string PublishedDate { get; set; }

        /// <summary>
        /// Gets or Sets PublishedDatePrecision
        /// </summary>
        [DataMember(Name = "published_date_precision", EmitDefaultValue = false)]
        public string PublishedDatePrecision { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets CleanUrl
        /// </summary>
        [DataMember(Name = "clean_url", EmitDefaultValue = false)]
        public string CleanUrl { get; set; }

        /// <summary>
        /// Gets or Sets Excerpt
        /// </summary>
        [DataMember(Name = "excerpt", EmitDefaultValue = true)]
        public string Excerpt { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Rights
        /// </summary>
        [DataMember(Name = "rights", EmitDefaultValue = true)]
        public string Rights { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int Rank { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name = "topic", EmitDefaultValue = false)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public string Authors { get; set; }

        /// <summary>
        /// Gets or Sets IsOpinion
        /// </summary>
        [DataMember(Name = "is_opinion", EmitDefaultValue = true)]
        public bool IsOpinion { get; set; }

        /// <summary>
        /// Gets or Sets TwitterAccount
        /// </summary>
        [DataMember(Name = "twitter_account", EmitDefaultValue = true)]
        public string TwitterAccount { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "_score", EmitDefaultValue = true)]
        public decimal? Score { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "_id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArticleInner {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  PublishedDatePrecision: ").Append(PublishedDatePrecision).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  CleanUrl: ").Append(CleanUrl).Append("\n");
            sb.Append("  Excerpt: ").Append(Excerpt).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Rights: ").Append(Rights).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  IsOpinion: ").Append(IsOpinion).Append("\n");
            sb.Append("  TwitterAccount: ").Append(TwitterAccount).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ArticleInner);
        }

        /// <summary>
        /// Returns true if ArticleInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ArticleInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.PublishedDate == input.PublishedDate ||
                    (this.PublishedDate != null &&
                    this.PublishedDate.Equals(input.PublishedDate))
                ) && 
                (
                    this.PublishedDatePrecision == input.PublishedDatePrecision ||
                    (this.PublishedDatePrecision != null &&
                    this.PublishedDatePrecision.Equals(input.PublishedDatePrecision))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.CleanUrl == input.CleanUrl ||
                    (this.CleanUrl != null &&
                    this.CleanUrl.Equals(input.CleanUrl))
                ) && 
                (
                    this.Excerpt == input.Excerpt ||
                    (this.Excerpt != null &&
                    this.Excerpt.Equals(input.Excerpt))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Rights == input.Rights ||
                    (this.Rights != null &&
                    this.Rights.Equals(input.Rights))
                ) && 
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Authors == input.Authors ||
                    (this.Authors != null &&
                    this.Authors.Equals(input.Authors))
                ) && 
                (
                    this.IsOpinion == input.IsOpinion ||
                    this.IsOpinion.Equals(input.IsOpinion)
                ) && 
                (
                    this.TwitterAccount == input.TwitterAccount ||
                    (this.TwitterAccount != null &&
                    this.TwitterAccount.Equals(input.TwitterAccount))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Author != null)
                {
                    hashCode = (hashCode * 59) + this.Author.GetHashCode();
                }
                if (this.PublishedDate != null)
                {
                    hashCode = (hashCode * 59) + this.PublishedDate.GetHashCode();
                }
                if (this.PublishedDatePrecision != null)
                {
                    hashCode = (hashCode * 59) + this.PublishedDatePrecision.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                if (this.CleanUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CleanUrl.GetHashCode();
                }
                if (this.Excerpt != null)
                {
                    hashCode = (hashCode * 59) + this.Excerpt.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.Rights != null)
                {
                    hashCode = (hashCode * 59) + this.Rights.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                if (this.Topic != null)
                {
                    hashCode = (hashCode * 59) + this.Topic.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.Authors != null)
                {
                    hashCode = (hashCode * 59) + this.Authors.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsOpinion.GetHashCode();
                if (this.TwitterAccount != null)
                {
                    hashCode = (hashCode * 59) + this.TwitterAccount.GetHashCode();
                }
                if (this.Score != null)
                {
                    hashCode = (hashCode * 59) + this.Score.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
