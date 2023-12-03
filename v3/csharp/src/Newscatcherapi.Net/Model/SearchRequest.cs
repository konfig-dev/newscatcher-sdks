/*
 * NewsCatcher-V3 Production API
 *
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: Beta-3.0.0
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
    /// SearchRequest
    /// </summary>
    [DataContract(Name = "SearchRequest")]
    public partial class SearchRequest : IEquatable<SearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="q">q (required).</param>
        /// <param name="searchIn">searchIn (default to &quot;title_content&quot;).</param>
        /// <param name="predefinedSources">predefinedSources.</param>
        /// <param name="sources">sources.</param>
        /// <param name="notSources">notSources.</param>
        /// <param name="lang">lang.</param>
        /// <param name="notLang">notLang.</param>
        /// <param name="countries">countries.</param>
        /// <param name="notCountries">notCountries.</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="publishedDatePrecision">publishedDatePrecision.</param>
        /// <param name="byParseDate">byParseDate (default to false).</param>
        /// <param name="sortBy">sortBy (default to &quot;relevancy&quot;).</param>
        /// <param name="rankedOnly">rankedOnly.</param>
        /// <param name="fromRank">fromRank.</param>
        /// <param name="toRank">toRank.</param>
        /// <param name="isHeadline">isHeadline.</param>
        /// <param name="isPaidContent">isPaidContent.</param>
        /// <param name="parentUrl">parentUrl.</param>
        /// <param name="allLinks">allLinks.</param>
        /// <param name="allDomainLinks">allDomainLinks.</param>
        /// <param name="wordCountMin">wordCountMin.</param>
        /// <param name="wordCountMax">wordCountMax.</param>
        /// <param name="page">page (default to 1).</param>
        /// <param name="pageSize">pageSize (default to 100).</param>
        /// <param name="clusteringEnabled">clusteringEnabled.</param>
        /// <param name="clusteringThreshold">clusteringThreshold.</param>
        /// <param name="clusteringVariable">clusteringVariable.</param>
        /// <param name="includeNlpData">includeNlpData.</param>
        /// <param name="hasNlp">hasNlp.</param>
        /// <param name="theme">theme.</param>
        /// <param name="oRGEntityName">oRGEntityName.</param>
        /// <param name="pEREntityName">pEREntityName.</param>
        /// <param name="lOCEntityName">lOCEntityName.</param>
        /// <param name="mISCEntityName">mISCEntityName.</param>
        /// <param name="titleSentimentMin">titleSentimentMin.</param>
        /// <param name="titleSentimentMax">titleSentimentMax.</param>
        /// <param name="contentSentimentMin">contentSentimentMin.</param>
        /// <param name="contentSentimentMax">contentSentimentMax.</param>
        public SearchRequest(string q = default(string), string searchIn = "title_content", string predefinedSources = default(string), string sources = default(string), string notSources = default(string), string lang = default(string), string notLang = default(string), string countries = default(string), string notCountries = default(string), From from = default(From), To to = default(To), string publishedDatePrecision = default(string), bool byParseDate = false, string sortBy = "relevancy", string rankedOnly = default(string), int fromRank = default(int), int toRank = default(int), bool isHeadline = default(bool), bool isPaidContent = default(bool), string parentUrl = default(string), string allLinks = default(string), string allDomainLinks = default(string), int wordCountMin = default(int), int wordCountMax = default(int), int page = 1, int pageSize = 100, bool clusteringEnabled = default(bool), double clusteringThreshold = default(double), string clusteringVariable = default(string), bool includeNlpData = default(bool), bool hasNlp = default(bool), string theme = default(string), string oRGEntityName = default(string), string pEREntityName = default(string), string lOCEntityName = default(string), string mISCEntityName = default(string), double titleSentimentMin = default(double), double titleSentimentMax = default(double), double contentSentimentMin = default(double), double contentSentimentMax = default(double))
        {
            // to ensure "q" is required (not null)
            if (q == null)
            {
                throw new ArgumentNullException("q is a required property for SearchRequest and cannot be null");
            }
            this.Q = q;
            // use default value if no "searchIn" provided
            this.SearchIn = searchIn ?? "title_content";
            this.PredefinedSources = predefinedSources;
            this.Sources = sources;
            this.NotSources = notSources;
            this.Lang = lang;
            this.NotLang = notLang;
            this.Countries = countries;
            this.NotCountries = notCountries;
            this.From = from;
            this.To = to;
            this.PublishedDatePrecision = publishedDatePrecision;
            this.ByParseDate = byParseDate;
            // use default value if no "sortBy" provided
            this.SortBy = sortBy ?? "relevancy";
            this.RankedOnly = rankedOnly;
            this.FromRank = fromRank;
            this.ToRank = toRank;
            this.IsHeadline = isHeadline;
            this.IsPaidContent = isPaidContent;
            this.ParentUrl = parentUrl;
            this.AllLinks = allLinks;
            this.AllDomainLinks = allDomainLinks;
            this.WordCountMin = wordCountMin;
            this.WordCountMax = wordCountMax;
            this.Page = page;
            this.PageSize = pageSize;
            this.ClusteringEnabled = clusteringEnabled;
            this.ClusteringThreshold = clusteringThreshold;
            this.ClusteringVariable = clusteringVariable;
            this.IncludeNlpData = includeNlpData;
            this.HasNlp = hasNlp;
            this.Theme = theme;
            this.ORGEntityName = oRGEntityName;
            this.PEREntityName = pEREntityName;
            this.LOCEntityName = lOCEntityName;
            this.MISCEntityName = mISCEntityName;
            this.TitleSentimentMin = titleSentimentMin;
            this.TitleSentimentMax = titleSentimentMax;
            this.ContentSentimentMin = contentSentimentMin;
            this.ContentSentimentMax = contentSentimentMax;
        }

        /// <summary>
        /// Gets or Sets Q
        /// </summary>
        [DataMember(Name = "q", IsRequired = true, EmitDefaultValue = true)]
        public string Q { get; set; }

        /// <summary>
        /// Gets or Sets SearchIn
        /// </summary>
        [DataMember(Name = "search_in", EmitDefaultValue = false)]
        public string SearchIn { get; set; }

        /// <summary>
        /// Gets or Sets PredefinedSources
        /// </summary>
        [DataMember(Name = "predefined_sources", EmitDefaultValue = false)]
        public string PredefinedSources { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name = "sources", EmitDefaultValue = false)]
        public string Sources { get; set; }

        /// <summary>
        /// Gets or Sets NotSources
        /// </summary>
        [DataMember(Name = "not_sources", EmitDefaultValue = false)]
        public string NotSources { get; set; }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [DataMember(Name = "lang", EmitDefaultValue = false)]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or Sets NotLang
        /// </summary>
        [DataMember(Name = "not_lang", EmitDefaultValue = false)]
        public string NotLang { get; set; }

        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public string Countries { get; set; }

        /// <summary>
        /// Gets or Sets NotCountries
        /// </summary>
        [DataMember(Name = "not_countries", EmitDefaultValue = false)]
        public string NotCountries { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from_", EmitDefaultValue = false)]
        public From From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to_", EmitDefaultValue = false)]
        public To To { get; set; }

        /// <summary>
        /// Gets or Sets PublishedDatePrecision
        /// </summary>
        [DataMember(Name = "published_date_precision", EmitDefaultValue = false)]
        public string PublishedDatePrecision { get; set; }

        /// <summary>
        /// Gets or Sets ByParseDate
        /// </summary>
        [DataMember(Name = "by_parse_date", EmitDefaultValue = true)]
        public bool ByParseDate { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name = "sort_by", EmitDefaultValue = false)]
        public string SortBy { get; set; }

        /// <summary>
        /// Gets or Sets RankedOnly
        /// </summary>
        [DataMember(Name = "ranked_only", EmitDefaultValue = false)]
        public string RankedOnly { get; set; }

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
        /// Gets or Sets IsHeadline
        /// </summary>
        [DataMember(Name = "is_headline", EmitDefaultValue = true)]
        public bool IsHeadline { get; set; }

        /// <summary>
        /// Gets or Sets IsPaidContent
        /// </summary>
        [DataMember(Name = "is_paid_content", EmitDefaultValue = true)]
        public bool IsPaidContent { get; set; }

        /// <summary>
        /// Gets or Sets ParentUrl
        /// </summary>
        [DataMember(Name = "parent_url", EmitDefaultValue = false)]
        public string ParentUrl { get; set; }

        /// <summary>
        /// Gets or Sets AllLinks
        /// </summary>
        [DataMember(Name = "all_links", EmitDefaultValue = false)]
        public string AllLinks { get; set; }

        /// <summary>
        /// Gets or Sets AllDomainLinks
        /// </summary>
        [DataMember(Name = "all_domain_links", EmitDefaultValue = false)]
        public string AllDomainLinks { get; set; }

        /// <summary>
        /// Gets or Sets WordCountMin
        /// </summary>
        [DataMember(Name = "word_count_min", EmitDefaultValue = false)]
        public int WordCountMin { get; set; }

        /// <summary>
        /// Gets or Sets WordCountMax
        /// </summary>
        [DataMember(Name = "word_count_max", EmitDefaultValue = false)]
        public int WordCountMax { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets ClusteringEnabled
        /// </summary>
        [DataMember(Name = "clustering_enabled", EmitDefaultValue = true)]
        public bool ClusteringEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ClusteringThreshold
        /// </summary>
        [DataMember(Name = "clustering_threshold", EmitDefaultValue = false)]
        public double ClusteringThreshold { get; set; }

        /// <summary>
        /// Gets or Sets ClusteringVariable
        /// </summary>
        [DataMember(Name = "clustering_variable", EmitDefaultValue = false)]
        public string ClusteringVariable { get; set; }

        /// <summary>
        /// Gets or Sets IncludeNlpData
        /// </summary>
        [DataMember(Name = "include_nlp_data", EmitDefaultValue = true)]
        public bool IncludeNlpData { get; set; }

        /// <summary>
        /// Gets or Sets HasNlp
        /// </summary>
        [DataMember(Name = "has_nlp", EmitDefaultValue = true)]
        public bool HasNlp { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public string Theme { get; set; }

        /// <summary>
        /// Gets or Sets ORGEntityName
        /// </summary>
        [DataMember(Name = "ORG_entity_name", EmitDefaultValue = false)]
        public string ORGEntityName { get; set; }

        /// <summary>
        /// Gets or Sets PEREntityName
        /// </summary>
        [DataMember(Name = "PER_entity_name", EmitDefaultValue = false)]
        public string PEREntityName { get; set; }

        /// <summary>
        /// Gets or Sets LOCEntityName
        /// </summary>
        [DataMember(Name = "LOC_entity_name", EmitDefaultValue = false)]
        public string LOCEntityName { get; set; }

        /// <summary>
        /// Gets or Sets MISCEntityName
        /// </summary>
        [DataMember(Name = "MISC_entity_name", EmitDefaultValue = false)]
        public string MISCEntityName { get; set; }

        /// <summary>
        /// Gets or Sets TitleSentimentMin
        /// </summary>
        [DataMember(Name = "title_sentiment_min", EmitDefaultValue = false)]
        public double TitleSentimentMin { get; set; }

        /// <summary>
        /// Gets or Sets TitleSentimentMax
        /// </summary>
        [DataMember(Name = "title_sentiment_max", EmitDefaultValue = false)]
        public double TitleSentimentMax { get; set; }

        /// <summary>
        /// Gets or Sets ContentSentimentMin
        /// </summary>
        [DataMember(Name = "content_sentiment_min", EmitDefaultValue = false)]
        public double ContentSentimentMin { get; set; }

        /// <summary>
        /// Gets or Sets ContentSentimentMax
        /// </summary>
        [DataMember(Name = "content_sentiment_max", EmitDefaultValue = false)]
        public double ContentSentimentMax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchRequest {\n");
            sb.Append("  Q: ").Append(Q).Append("\n");
            sb.Append("  SearchIn: ").Append(SearchIn).Append("\n");
            sb.Append("  PredefinedSources: ").Append(PredefinedSources).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  NotSources: ").Append(NotSources).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  NotLang: ").Append(NotLang).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  NotCountries: ").Append(NotCountries).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  PublishedDatePrecision: ").Append(PublishedDatePrecision).Append("\n");
            sb.Append("  ByParseDate: ").Append(ByParseDate).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  RankedOnly: ").Append(RankedOnly).Append("\n");
            sb.Append("  FromRank: ").Append(FromRank).Append("\n");
            sb.Append("  ToRank: ").Append(ToRank).Append("\n");
            sb.Append("  IsHeadline: ").Append(IsHeadline).Append("\n");
            sb.Append("  IsPaidContent: ").Append(IsPaidContent).Append("\n");
            sb.Append("  ParentUrl: ").Append(ParentUrl).Append("\n");
            sb.Append("  AllLinks: ").Append(AllLinks).Append("\n");
            sb.Append("  AllDomainLinks: ").Append(AllDomainLinks).Append("\n");
            sb.Append("  WordCountMin: ").Append(WordCountMin).Append("\n");
            sb.Append("  WordCountMax: ").Append(WordCountMax).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ClusteringEnabled: ").Append(ClusteringEnabled).Append("\n");
            sb.Append("  ClusteringThreshold: ").Append(ClusteringThreshold).Append("\n");
            sb.Append("  ClusteringVariable: ").Append(ClusteringVariable).Append("\n");
            sb.Append("  IncludeNlpData: ").Append(IncludeNlpData).Append("\n");
            sb.Append("  HasNlp: ").Append(HasNlp).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  ORGEntityName: ").Append(ORGEntityName).Append("\n");
            sb.Append("  PEREntityName: ").Append(PEREntityName).Append("\n");
            sb.Append("  LOCEntityName: ").Append(LOCEntityName).Append("\n");
            sb.Append("  MISCEntityName: ").Append(MISCEntityName).Append("\n");
            sb.Append("  TitleSentimentMin: ").Append(TitleSentimentMin).Append("\n");
            sb.Append("  TitleSentimentMax: ").Append(TitleSentimentMax).Append("\n");
            sb.Append("  ContentSentimentMin: ").Append(ContentSentimentMin).Append("\n");
            sb.Append("  ContentSentimentMax: ").Append(ContentSentimentMax).Append("\n");
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
            return this.Equals(input as SearchRequest);
        }

        /// <summary>
        /// Returns true if SearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Q == input.Q ||
                    (this.Q != null &&
                    this.Q.Equals(input.Q))
                ) && 
                (
                    this.SearchIn == input.SearchIn ||
                    (this.SearchIn != null &&
                    this.SearchIn.Equals(input.SearchIn))
                ) && 
                (
                    this.PredefinedSources == input.PredefinedSources ||
                    (this.PredefinedSources != null &&
                    this.PredefinedSources.Equals(input.PredefinedSources))
                ) && 
                (
                    this.Sources == input.Sources ||
                    (this.Sources != null &&
                    this.Sources.Equals(input.Sources))
                ) && 
                (
                    this.NotSources == input.NotSources ||
                    (this.NotSources != null &&
                    this.NotSources.Equals(input.NotSources))
                ) && 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                ) && 
                (
                    this.NotLang == input.NotLang ||
                    (this.NotLang != null &&
                    this.NotLang.Equals(input.NotLang))
                ) && 
                (
                    this.Countries == input.Countries ||
                    (this.Countries != null &&
                    this.Countries.Equals(input.Countries))
                ) && 
                (
                    this.NotCountries == input.NotCountries ||
                    (this.NotCountries != null &&
                    this.NotCountries.Equals(input.NotCountries))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.PublishedDatePrecision == input.PublishedDatePrecision ||
                    (this.PublishedDatePrecision != null &&
                    this.PublishedDatePrecision.Equals(input.PublishedDatePrecision))
                ) && 
                (
                    this.ByParseDate == input.ByParseDate ||
                    this.ByParseDate.Equals(input.ByParseDate)
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.RankedOnly == input.RankedOnly ||
                    (this.RankedOnly != null &&
                    this.RankedOnly.Equals(input.RankedOnly))
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
                    this.IsHeadline == input.IsHeadline ||
                    this.IsHeadline.Equals(input.IsHeadline)
                ) && 
                (
                    this.IsPaidContent == input.IsPaidContent ||
                    this.IsPaidContent.Equals(input.IsPaidContent)
                ) && 
                (
                    this.ParentUrl == input.ParentUrl ||
                    (this.ParentUrl != null &&
                    this.ParentUrl.Equals(input.ParentUrl))
                ) && 
                (
                    this.AllLinks == input.AllLinks ||
                    (this.AllLinks != null &&
                    this.AllLinks.Equals(input.AllLinks))
                ) && 
                (
                    this.AllDomainLinks == input.AllDomainLinks ||
                    (this.AllDomainLinks != null &&
                    this.AllDomainLinks.Equals(input.AllDomainLinks))
                ) && 
                (
                    this.WordCountMin == input.WordCountMin ||
                    this.WordCountMin.Equals(input.WordCountMin)
                ) && 
                (
                    this.WordCountMax == input.WordCountMax ||
                    this.WordCountMax.Equals(input.WordCountMax)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.ClusteringEnabled == input.ClusteringEnabled ||
                    this.ClusteringEnabled.Equals(input.ClusteringEnabled)
                ) && 
                (
                    this.ClusteringThreshold == input.ClusteringThreshold ||
                    this.ClusteringThreshold.Equals(input.ClusteringThreshold)
                ) && 
                (
                    this.ClusteringVariable == input.ClusteringVariable ||
                    (this.ClusteringVariable != null &&
                    this.ClusteringVariable.Equals(input.ClusteringVariable))
                ) && 
                (
                    this.IncludeNlpData == input.IncludeNlpData ||
                    this.IncludeNlpData.Equals(input.IncludeNlpData)
                ) && 
                (
                    this.HasNlp == input.HasNlp ||
                    this.HasNlp.Equals(input.HasNlp)
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
                ) && 
                (
                    this.ORGEntityName == input.ORGEntityName ||
                    (this.ORGEntityName != null &&
                    this.ORGEntityName.Equals(input.ORGEntityName))
                ) && 
                (
                    this.PEREntityName == input.PEREntityName ||
                    (this.PEREntityName != null &&
                    this.PEREntityName.Equals(input.PEREntityName))
                ) && 
                (
                    this.LOCEntityName == input.LOCEntityName ||
                    (this.LOCEntityName != null &&
                    this.LOCEntityName.Equals(input.LOCEntityName))
                ) && 
                (
                    this.MISCEntityName == input.MISCEntityName ||
                    (this.MISCEntityName != null &&
                    this.MISCEntityName.Equals(input.MISCEntityName))
                ) && 
                (
                    this.TitleSentimentMin == input.TitleSentimentMin ||
                    this.TitleSentimentMin.Equals(input.TitleSentimentMin)
                ) && 
                (
                    this.TitleSentimentMax == input.TitleSentimentMax ||
                    this.TitleSentimentMax.Equals(input.TitleSentimentMax)
                ) && 
                (
                    this.ContentSentimentMin == input.ContentSentimentMin ||
                    this.ContentSentimentMin.Equals(input.ContentSentimentMin)
                ) && 
                (
                    this.ContentSentimentMax == input.ContentSentimentMax ||
                    this.ContentSentimentMax.Equals(input.ContentSentimentMax)
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
                if (this.Q != null)
                {
                    hashCode = (hashCode * 59) + this.Q.GetHashCode();
                }
                if (this.SearchIn != null)
                {
                    hashCode = (hashCode * 59) + this.SearchIn.GetHashCode();
                }
                if (this.PredefinedSources != null)
                {
                    hashCode = (hashCode * 59) + this.PredefinedSources.GetHashCode();
                }
                if (this.Sources != null)
                {
                    hashCode = (hashCode * 59) + this.Sources.GetHashCode();
                }
                if (this.NotSources != null)
                {
                    hashCode = (hashCode * 59) + this.NotSources.GetHashCode();
                }
                if (this.Lang != null)
                {
                    hashCode = (hashCode * 59) + this.Lang.GetHashCode();
                }
                if (this.NotLang != null)
                {
                    hashCode = (hashCode * 59) + this.NotLang.GetHashCode();
                }
                if (this.Countries != null)
                {
                    hashCode = (hashCode * 59) + this.Countries.GetHashCode();
                }
                if (this.NotCountries != null)
                {
                    hashCode = (hashCode * 59) + this.NotCountries.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.PublishedDatePrecision != null)
                {
                    hashCode = (hashCode * 59) + this.PublishedDatePrecision.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ByParseDate.GetHashCode();
                if (this.SortBy != null)
                {
                    hashCode = (hashCode * 59) + this.SortBy.GetHashCode();
                }
                if (this.RankedOnly != null)
                {
                    hashCode = (hashCode * 59) + this.RankedOnly.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FromRank.GetHashCode();
                hashCode = (hashCode * 59) + this.ToRank.GetHashCode();
                hashCode = (hashCode * 59) + this.IsHeadline.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPaidContent.GetHashCode();
                if (this.ParentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ParentUrl.GetHashCode();
                }
                if (this.AllLinks != null)
                {
                    hashCode = (hashCode * 59) + this.AllLinks.GetHashCode();
                }
                if (this.AllDomainLinks != null)
                {
                    hashCode = (hashCode * 59) + this.AllDomainLinks.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WordCountMin.GetHashCode();
                hashCode = (hashCode * 59) + this.WordCountMax.GetHashCode();
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.ClusteringEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ClusteringThreshold.GetHashCode();
                if (this.ClusteringVariable != null)
                {
                    hashCode = (hashCode * 59) + this.ClusteringVariable.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeNlpData.GetHashCode();
                hashCode = (hashCode * 59) + this.HasNlp.GetHashCode();
                if (this.Theme != null)
                {
                    hashCode = (hashCode * 59) + this.Theme.GetHashCode();
                }
                if (this.ORGEntityName != null)
                {
                    hashCode = (hashCode * 59) + this.ORGEntityName.GetHashCode();
                }
                if (this.PEREntityName != null)
                {
                    hashCode = (hashCode * 59) + this.PEREntityName.GetHashCode();
                }
                if (this.LOCEntityName != null)
                {
                    hashCode = (hashCode * 59) + this.LOCEntityName.GetHashCode();
                }
                if (this.MISCEntityName != null)
                {
                    hashCode = (hashCode * 59) + this.MISCEntityName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TitleSentimentMin.GetHashCode();
                hashCode = (hashCode * 59) + this.TitleSentimentMax.GetHashCode();
                hashCode = (hashCode * 59) + this.ContentSentimentMin.GetHashCode();
                hashCode = (hashCode * 59) + this.ContentSentimentMax.GetHashCode();
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
            // WordCountMin (int) minimum
            if (this.WordCountMin < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WordCountMin, must be a value greater than or equal to 0.", new [] { "WordCountMin" });
            }

            // WordCountMax (int) minimum
            if (this.WordCountMax < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WordCountMax, must be a value greater than or equal to 0.", new [] { "WordCountMax" });
            }

            // Page (int) minimum
            if (this.Page < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Page, must be a value greater than or equal to 0.", new [] { "Page" });
            }

            // PageSize (int) minimum
            if (this.PageSize < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageSize, must be a value greater than or equal to 0.", new [] { "PageSize" });
            }

            yield break;
        }
    }

}
