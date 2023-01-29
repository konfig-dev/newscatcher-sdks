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
    /// Defines topic
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Topic
    {
        /// <summary>
        /// Enum News for value: news
        /// </summary>
        [EnumMember(Value = "news")]
        News = 1,

        /// <summary>
        /// Enum Sport for value: sport
        /// </summary>
        [EnumMember(Value = "sport")]
        Sport = 2,

        /// <summary>
        /// Enum Tech for value: tech
        /// </summary>
        [EnumMember(Value = "tech")]
        Tech = 3,

        /// <summary>
        /// Enum World for value: world
        /// </summary>
        [EnumMember(Value = "world")]
        World = 4,

        /// <summary>
        /// Enum Finance for value: finance
        /// </summary>
        [EnumMember(Value = "finance")]
        Finance = 5,

        /// <summary>
        /// Enum Politics for value: politics
        /// </summary>
        [EnumMember(Value = "politics")]
        Politics = 6,

        /// <summary>
        /// Enum Business for value: business
        /// </summary>
        [EnumMember(Value = "business")]
        Business = 7,

        /// <summary>
        /// Enum Economics for value: economics
        /// </summary>
        [EnumMember(Value = "economics")]
        Economics = 8,

        /// <summary>
        /// Enum Entertainment for value: entertainment
        /// </summary>
        [EnumMember(Value = "entertainment")]
        Entertainment = 9,

        /// <summary>
        /// Enum Beauty for value: beauty
        /// </summary>
        [EnumMember(Value = "beauty")]
        Beauty = 10,

        /// <summary>
        /// Enum Travel for value: travel
        /// </summary>
        [EnumMember(Value = "travel")]
        Travel = 11,

        /// <summary>
        /// Enum Music for value: music
        /// </summary>
        [EnumMember(Value = "music")]
        Music = 12,

        /// <summary>
        /// Enum Food for value: food
        /// </summary>
        [EnumMember(Value = "food")]
        Food = 13,

        /// <summary>
        /// Enum Science for value: science
        /// </summary>
        [EnumMember(Value = "science")]
        Science = 14,

        /// <summary>
        /// Enum Gaming for value: gaming
        /// </summary>
        [EnumMember(Value = "gaming")]
        Gaming = 15

    }

}
