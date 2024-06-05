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
    /// Latest headlines request DTO.
    /// </summary>
    [DataContract(Name = "LatestHeadlinesRequest")]
    public partial class LatestHeadlinesRequest : IEquatable<LatestHeadlinesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestHeadlinesRequest" /> class.
        /// </summary>
        /// <param name="when">when (default to &quot;7d&quot;).</param>
        /// <param name="byParseDate">byParseDate (default to false).</param>
        /// <param name="lang">lang.</param>
        /// <param name="notLang">notLang.</param>
        /// <param name="countries">countries.</param>
        /// <param name="notCountries">notCountries.</param>
        /// <param name="sources">sources.</param>
        /// <param name="predefinedSources">predefinedSources.</param>
        /// <param name="notSources">notSources.</param>
        /// <param name="notAuthorName">notAuthorName.</param>
        /// <param name="rankedOnly">rankedOnly.</param>
        /// <param name="isHeadline">isHeadline.</param>
        /// <param name="isOpinion">isOpinion.</param>
        /// <param name="isPaidContent">isPaidContent.</param>
        /// <param name="parentUrl">parentUrl.</param>
        /// <param name="allLinks">allLinks.</param>
        /// <param name="allDomainLinks">allDomainLinks.</param>
        /// <param name="wordCountMin">wordCountMin.</param>
        /// <param name="wordCountMax">wordCountMax.</param>
        /// <param name="page">page (default to 1).</param>
        /// <param name="pageSize">pageSize (default to 100).</param>
        /// <param name="clusteringVariable">clusteringVariable.</param>
        /// <param name="clusteringEnabled">clusteringEnabled.</param>
        /// <param name="clusteringThreshold">clusteringThreshold.</param>
        /// <param name="includeNlpData">includeNlpData.</param>
        /// <param name="hasNlp">hasNlp.</param>
        /// <param name="theme">theme.</param>
        /// <param name="notTheme">notTheme.</param>
        /// <param name="oRGEntityName">oRGEntityName.</param>
        /// <param name="pEREntityName">pEREntityName.</param>
        /// <param name="lOCEntityName">lOCEntityName.</param>
        /// <param name="mISCEntityName">mISCEntityName.</param>
        /// <param name="titleSentimentMin">titleSentimentMin.</param>
        /// <param name="titleSentimentMax">titleSentimentMax.</param>
        /// <param name="contentSentimentMin">contentSentimentMin.</param>
        /// <param name="contentSentimentMax">contentSentimentMax.</param>
        /// <param name="iptcTags">iptcTags.</param>
        /// <param name="notIptcTags">notIptcTags.</param>
        /// <param name="iabTags">iabTags.</param>
        /// <param name="notIabTags">notIabTags.</param>
        public LatestHeadlinesRequest(string when = "7d", bool byParseDate = false, Object lang = default(Object), Object notLang = default(Object), Object countries = default(Object), Object notCountries = default(Object), Object sources = default(Object), Object predefinedSources = default(Object), Object notSources = default(Object), Object notAuthorName = default(Object), string rankedOnly = default(string), bool isHeadline = default(bool), bool isOpinion = default(bool), bool isPaidContent = default(bool), Object parentUrl = default(Object), Object allLinks = default(Object), Object allDomainLinks = default(Object), int wordCountMin = default(int), int wordCountMax = default(int), int page = 1, int pageSize = 100, string clusteringVariable = default(string), bool clusteringEnabled = default(bool), double clusteringThreshold = default(double), bool includeNlpData = default(bool), bool hasNlp = default(bool), string theme = default(string), string notTheme = default(string), string oRGEntityName = default(string), string pEREntityName = default(string), string lOCEntityName = default(string), string mISCEntityName = default(string), double titleSentimentMin = default(double), double titleSentimentMax = default(double), double contentSentimentMin = default(double), double contentSentimentMax = default(double), Object iptcTags = default(Object), Object notIptcTags = default(Object), Object iabTags = default(Object), Object notIabTags = default(Object))
        {
            // use default value if no "when" provided
            this.When = when ?? "7d";
            this.ByParseDate = byParseDate;
            this.Lang = lang;
            this.NotLang = notLang;
            this.Countries = countries;
            this.NotCountries = notCountries;
            this.Sources = sources;
            this.PredefinedSources = predefinedSources;
            this.NotSources = notSources;
            this.NotAuthorName = notAuthorName;
            this.RankedOnly = rankedOnly;
            this.IsHeadline = isHeadline;
            this.IsOpinion = isOpinion;
            this.IsPaidContent = isPaidContent;
            this.ParentUrl = parentUrl;
            this.AllLinks = allLinks;
            this.AllDomainLinks = allDomainLinks;
            this.WordCountMin = wordCountMin;
            this.WordCountMax = wordCountMax;
            this.Page = page;
            this.PageSize = pageSize;
            this.ClusteringVariable = clusteringVariable;
            this.ClusteringEnabled = clusteringEnabled;
            this.ClusteringThreshold = clusteringThreshold;
            this.IncludeNlpData = includeNlpData;
            this.HasNlp = hasNlp;
            this.Theme = theme;
            this.NotTheme = notTheme;
            this.ORGEntityName = oRGEntityName;
            this.PEREntityName = pEREntityName;
            this.LOCEntityName = lOCEntityName;
            this.MISCEntityName = mISCEntityName;
            this.TitleSentimentMin = titleSentimentMin;
            this.TitleSentimentMax = titleSentimentMax;
            this.ContentSentimentMin = contentSentimentMin;
            this.ContentSentimentMax = contentSentimentMax;
            this.IptcTags = iptcTags;
            this.NotIptcTags = notIptcTags;
            this.IabTags = iabTags;
            this.NotIabTags = notIabTags;
        }

        /// <summary>
        /// Gets or Sets When
        /// </summary>
        [DataMember(Name = "when", EmitDefaultValue = false)]
        public string When { get; set; }

        /// <summary>
        /// Gets or Sets ByParseDate
        /// </summary>
        [DataMember(Name = "by_parse_date", EmitDefaultValue = true)]
        public bool ByParseDate { get; set; }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [DataMember(Name = "lang", EmitDefaultValue = true)]
        public Object Lang { get; set; }

        /// <summary>
        /// Gets or Sets NotLang
        /// </summary>
        [DataMember(Name = "not_lang", EmitDefaultValue = true)]
        public Object NotLang { get; set; }

        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name = "countries", EmitDefaultValue = true)]
        public Object Countries { get; set; }

        /// <summary>
        /// Gets or Sets NotCountries
        /// </summary>
        [DataMember(Name = "not_countries", EmitDefaultValue = true)]
        public Object NotCountries { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name = "sources", EmitDefaultValue = true)]
        public Object Sources { get; set; }

        /// <summary>
        /// Gets or Sets PredefinedSources
        /// </summary>
        [DataMember(Name = "predefined_sources", EmitDefaultValue = true)]
        public Object PredefinedSources { get; set; }

        /// <summary>
        /// Gets or Sets NotSources
        /// </summary>
        [DataMember(Name = "not_sources", EmitDefaultValue = true)]
        public Object NotSources { get; set; }

        /// <summary>
        /// Gets or Sets NotAuthorName
        /// </summary>
        [DataMember(Name = "not_author_name", EmitDefaultValue = true)]
        public Object NotAuthorName { get; set; }

        /// <summary>
        /// Gets or Sets RankedOnly
        /// </summary>
        [DataMember(Name = "ranked_only", EmitDefaultValue = false)]
        public string RankedOnly { get; set; }

        /// <summary>
        /// Gets or Sets IsHeadline
        /// </summary>
        [DataMember(Name = "is_headline", EmitDefaultValue = true)]
        public bool IsHeadline { get; set; }

        /// <summary>
        /// Gets or Sets IsOpinion
        /// </summary>
        [DataMember(Name = "is_opinion", EmitDefaultValue = true)]
        public bool IsOpinion { get; set; }

        /// <summary>
        /// Gets or Sets IsPaidContent
        /// </summary>
        [DataMember(Name = "is_paid_content", EmitDefaultValue = true)]
        public bool IsPaidContent { get; set; }

        /// <summary>
        /// Gets or Sets ParentUrl
        /// </summary>
        [DataMember(Name = "parent_url", EmitDefaultValue = true)]
        public Object ParentUrl { get; set; }

        /// <summary>
        /// Gets or Sets AllLinks
        /// </summary>
        [DataMember(Name = "all_links", EmitDefaultValue = true)]
        public Object AllLinks { get; set; }

        /// <summary>
        /// Gets or Sets AllDomainLinks
        /// </summary>
        [DataMember(Name = "all_domain_links", EmitDefaultValue = true)]
        public Object AllDomainLinks { get; set; }

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
        /// Gets or Sets ClusteringVariable
        /// </summary>
        [DataMember(Name = "clustering_variable", EmitDefaultValue = false)]
        public string ClusteringVariable { get; set; }

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
        /// Gets or Sets NotTheme
        /// </summary>
        [DataMember(Name = "not_theme", EmitDefaultValue = false)]
        public string NotTheme { get; set; }

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
        /// Gets or Sets IptcTags
        /// </summary>
        [DataMember(Name = "iptc_tags", EmitDefaultValue = true)]
        public Object IptcTags { get; set; }

        /// <summary>
        /// Gets or Sets NotIptcTags
        /// </summary>
        [DataMember(Name = "not_iptc_tags", EmitDefaultValue = true)]
        public Object NotIptcTags { get; set; }

        /// <summary>
        /// Gets or Sets IabTags
        /// </summary>
        [DataMember(Name = "iab_tags", EmitDefaultValue = true)]
        public Object IabTags { get; set; }

        /// <summary>
        /// Gets or Sets NotIabTags
        /// </summary>
        [DataMember(Name = "not_iab_tags", EmitDefaultValue = true)]
        public Object NotIabTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LatestHeadlinesRequest {\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  ByParseDate: ").Append(ByParseDate).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  NotLang: ").Append(NotLang).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  NotCountries: ").Append(NotCountries).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  PredefinedSources: ").Append(PredefinedSources).Append("\n");
            sb.Append("  NotSources: ").Append(NotSources).Append("\n");
            sb.Append("  NotAuthorName: ").Append(NotAuthorName).Append("\n");
            sb.Append("  RankedOnly: ").Append(RankedOnly).Append("\n");
            sb.Append("  IsHeadline: ").Append(IsHeadline).Append("\n");
            sb.Append("  IsOpinion: ").Append(IsOpinion).Append("\n");
            sb.Append("  IsPaidContent: ").Append(IsPaidContent).Append("\n");
            sb.Append("  ParentUrl: ").Append(ParentUrl).Append("\n");
            sb.Append("  AllLinks: ").Append(AllLinks).Append("\n");
            sb.Append("  AllDomainLinks: ").Append(AllDomainLinks).Append("\n");
            sb.Append("  WordCountMin: ").Append(WordCountMin).Append("\n");
            sb.Append("  WordCountMax: ").Append(WordCountMax).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ClusteringVariable: ").Append(ClusteringVariable).Append("\n");
            sb.Append("  ClusteringEnabled: ").Append(ClusteringEnabled).Append("\n");
            sb.Append("  ClusteringThreshold: ").Append(ClusteringThreshold).Append("\n");
            sb.Append("  IncludeNlpData: ").Append(IncludeNlpData).Append("\n");
            sb.Append("  HasNlp: ").Append(HasNlp).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  NotTheme: ").Append(NotTheme).Append("\n");
            sb.Append("  ORGEntityName: ").Append(ORGEntityName).Append("\n");
            sb.Append("  PEREntityName: ").Append(PEREntityName).Append("\n");
            sb.Append("  LOCEntityName: ").Append(LOCEntityName).Append("\n");
            sb.Append("  MISCEntityName: ").Append(MISCEntityName).Append("\n");
            sb.Append("  TitleSentimentMin: ").Append(TitleSentimentMin).Append("\n");
            sb.Append("  TitleSentimentMax: ").Append(TitleSentimentMax).Append("\n");
            sb.Append("  ContentSentimentMin: ").Append(ContentSentimentMin).Append("\n");
            sb.Append("  ContentSentimentMax: ").Append(ContentSentimentMax).Append("\n");
            sb.Append("  IptcTags: ").Append(IptcTags).Append("\n");
            sb.Append("  NotIptcTags: ").Append(NotIptcTags).Append("\n");
            sb.Append("  IabTags: ").Append(IabTags).Append("\n");
            sb.Append("  NotIabTags: ").Append(NotIabTags).Append("\n");
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
            return this.Equals(input as LatestHeadlinesRequest);
        }

        /// <summary>
        /// Returns true if LatestHeadlinesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LatestHeadlinesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatestHeadlinesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
                ) && 
                (
                    this.ByParseDate == input.ByParseDate ||
                    this.ByParseDate.Equals(input.ByParseDate)
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
                    this.Sources == input.Sources ||
                    (this.Sources != null &&
                    this.Sources.Equals(input.Sources))
                ) && 
                (
                    this.PredefinedSources == input.PredefinedSources ||
                    (this.PredefinedSources != null &&
                    this.PredefinedSources.Equals(input.PredefinedSources))
                ) && 
                (
                    this.NotSources == input.NotSources ||
                    (this.NotSources != null &&
                    this.NotSources.Equals(input.NotSources))
                ) && 
                (
                    this.NotAuthorName == input.NotAuthorName ||
                    (this.NotAuthorName != null &&
                    this.NotAuthorName.Equals(input.NotAuthorName))
                ) && 
                (
                    this.RankedOnly == input.RankedOnly ||
                    (this.RankedOnly != null &&
                    this.RankedOnly.Equals(input.RankedOnly))
                ) && 
                (
                    this.IsHeadline == input.IsHeadline ||
                    this.IsHeadline.Equals(input.IsHeadline)
                ) && 
                (
                    this.IsOpinion == input.IsOpinion ||
                    this.IsOpinion.Equals(input.IsOpinion)
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
                    this.ClusteringVariable == input.ClusteringVariable ||
                    (this.ClusteringVariable != null &&
                    this.ClusteringVariable.Equals(input.ClusteringVariable))
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
                    this.NotTheme == input.NotTheme ||
                    (this.NotTheme != null &&
                    this.NotTheme.Equals(input.NotTheme))
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
                ) && 
                (
                    this.IptcTags == input.IptcTags ||
                    (this.IptcTags != null &&
                    this.IptcTags.Equals(input.IptcTags))
                ) && 
                (
                    this.NotIptcTags == input.NotIptcTags ||
                    (this.NotIptcTags != null &&
                    this.NotIptcTags.Equals(input.NotIptcTags))
                ) && 
                (
                    this.IabTags == input.IabTags ||
                    (this.IabTags != null &&
                    this.IabTags.Equals(input.IabTags))
                ) && 
                (
                    this.NotIabTags == input.NotIabTags ||
                    (this.NotIabTags != null &&
                    this.NotIabTags.Equals(input.NotIabTags))
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
                if (this.When != null)
                {
                    hashCode = (hashCode * 59) + this.When.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ByParseDate.GetHashCode();
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
                if (this.Sources != null)
                {
                    hashCode = (hashCode * 59) + this.Sources.GetHashCode();
                }
                if (this.PredefinedSources != null)
                {
                    hashCode = (hashCode * 59) + this.PredefinedSources.GetHashCode();
                }
                if (this.NotSources != null)
                {
                    hashCode = (hashCode * 59) + this.NotSources.GetHashCode();
                }
                if (this.NotAuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.NotAuthorName.GetHashCode();
                }
                if (this.RankedOnly != null)
                {
                    hashCode = (hashCode * 59) + this.RankedOnly.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsHeadline.GetHashCode();
                hashCode = (hashCode * 59) + this.IsOpinion.GetHashCode();
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
                if (this.ClusteringVariable != null)
                {
                    hashCode = (hashCode * 59) + this.ClusteringVariable.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ClusteringEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ClusteringThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeNlpData.GetHashCode();
                hashCode = (hashCode * 59) + this.HasNlp.GetHashCode();
                if (this.Theme != null)
                {
                    hashCode = (hashCode * 59) + this.Theme.GetHashCode();
                }
                if (this.NotTheme != null)
                {
                    hashCode = (hashCode * 59) + this.NotTheme.GetHashCode();
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
                if (this.IptcTags != null)
                {
                    hashCode = (hashCode * 59) + this.IptcTags.GetHashCode();
                }
                if (this.NotIptcTags != null)
                {
                    hashCode = (hashCode * 59) + this.NotIptcTags.GetHashCode();
                }
                if (this.IabTags != null)
                {
                    hashCode = (hashCode * 59) + this.IabTags.GetHashCode();
                }
                if (this.NotIabTags != null)
                {
                    hashCode = (hashCode * 59) + this.NotIabTags.GetHashCode();
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
