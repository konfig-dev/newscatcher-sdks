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
    /// Defines lang
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Lang
    {
        /// <summary>
        /// Enum Af for value: af
        /// </summary>
        [EnumMember(Value = "af")]
        Af = 1,

        /// <summary>
        /// Enum Ar for value: ar
        /// </summary>
        [EnumMember(Value = "ar")]
        Ar = 2,

        /// <summary>
        /// Enum Bg for value: bg
        /// </summary>
        [EnumMember(Value = "bg")]
        Bg = 3,

        /// <summary>
        /// Enum Bn for value: bn
        /// </summary>
        [EnumMember(Value = "bn")]
        Bn = 4,

        /// <summary>
        /// Enum Ca for value: ca
        /// </summary>
        [EnumMember(Value = "ca")]
        Ca = 5,

        /// <summary>
        /// Enum Cn for value: cn
        /// </summary>
        [EnumMember(Value = "cn")]
        Cn = 6,

        /// <summary>
        /// Enum Cs for value: cs
        /// </summary>
        [EnumMember(Value = "cs")]
        Cs = 7,

        /// <summary>
        /// Enum Cy for value: cy
        /// </summary>
        [EnumMember(Value = "cy")]
        Cy = 8,

        /// <summary>
        /// Enum Da for value: da
        /// </summary>
        [EnumMember(Value = "da")]
        Da = 9,

        /// <summary>
        /// Enum De for value: de
        /// </summary>
        [EnumMember(Value = "de")]
        De = 10,

        /// <summary>
        /// Enum El for value: el
        /// </summary>
        [EnumMember(Value = "el")]
        El = 11,

        /// <summary>
        /// Enum En for value: en
        /// </summary>
        [EnumMember(Value = "en")]
        En = 12,

        /// <summary>
        /// Enum Es for value: es
        /// </summary>
        [EnumMember(Value = "es")]
        Es = 13,

        /// <summary>
        /// Enum Et for value: et
        /// </summary>
        [EnumMember(Value = "et")]
        Et = 14,

        /// <summary>
        /// Enum Fa for value: fa
        /// </summary>
        [EnumMember(Value = "fa")]
        Fa = 15,

        /// <summary>
        /// Enum Fi for value: fi
        /// </summary>
        [EnumMember(Value = "fi")]
        Fi = 16,

        /// <summary>
        /// Enum Fr for value: fr
        /// </summary>
        [EnumMember(Value = "fr")]
        Fr = 17,

        /// <summary>
        /// Enum Gu for value: gu
        /// </summary>
        [EnumMember(Value = "gu")]
        Gu = 18,

        /// <summary>
        /// Enum He for value: he
        /// </summary>
        [EnumMember(Value = "he")]
        He = 19,

        /// <summary>
        /// Enum Hi for value: hi
        /// </summary>
        [EnumMember(Value = "hi")]
        Hi = 20,

        /// <summary>
        /// Enum Hr for value: hr
        /// </summary>
        [EnumMember(Value = "hr")]
        Hr = 21,

        /// <summary>
        /// Enum Hu for value: hu
        /// </summary>
        [EnumMember(Value = "hu")]
        Hu = 22,

        /// <summary>
        /// Enum Id for value: id
        /// </summary>
        [EnumMember(Value = "id")]
        Id = 23,

        /// <summary>
        /// Enum It for value: it
        /// </summary>
        [EnumMember(Value = "it")]
        It = 24,

        /// <summary>
        /// Enum Ja for value: ja
        /// </summary>
        [EnumMember(Value = "ja")]
        Ja = 25,

        /// <summary>
        /// Enum Kn for value: kn
        /// </summary>
        [EnumMember(Value = "kn")]
        Kn = 26,

        /// <summary>
        /// Enum Ko for value: ko
        /// </summary>
        [EnumMember(Value = "ko")]
        Ko = 27,

        /// <summary>
        /// Enum Lt for value: lt
        /// </summary>
        [EnumMember(Value = "lt")]
        Lt = 28,

        /// <summary>
        /// Enum Lv for value: lv
        /// </summary>
        [EnumMember(Value = "lv")]
        Lv = 29,

        /// <summary>
        /// Enum Mk for value: mk
        /// </summary>
        [EnumMember(Value = "mk")]
        Mk = 30,

        /// <summary>
        /// Enum Ml for value: ml
        /// </summary>
        [EnumMember(Value = "ml")]
        Ml = 31,

        /// <summary>
        /// Enum Mr for value: mr
        /// </summary>
        [EnumMember(Value = "mr")]
        Mr = 32,

        /// <summary>
        /// Enum Ne for value: ne
        /// </summary>
        [EnumMember(Value = "ne")]
        Ne = 33,

        /// <summary>
        /// Enum Nl for value: nl
        /// </summary>
        [EnumMember(Value = "nl")]
        Nl = 34,

        /// <summary>
        /// Enum False for value: false
        /// </summary>
        [EnumMember(Value = "false")]
        False = 35,

        /// <summary>
        /// Enum Pa for value: pa
        /// </summary>
        [EnumMember(Value = "pa")]
        Pa = 36,

        /// <summary>
        /// Enum Pl for value: pl
        /// </summary>
        [EnumMember(Value = "pl")]
        Pl = 37,

        /// <summary>
        /// Enum Pt for value: pt
        /// </summary>
        [EnumMember(Value = "pt")]
        Pt = 38,

        /// <summary>
        /// Enum Ro for value: ro
        /// </summary>
        [EnumMember(Value = "ro")]
        Ro = 39,

        /// <summary>
        /// Enum Ru for value: ru
        /// </summary>
        [EnumMember(Value = "ru")]
        Ru = 40,

        /// <summary>
        /// Enum Sk for value: sk
        /// </summary>
        [EnumMember(Value = "sk")]
        Sk = 41,

        /// <summary>
        /// Enum Sl for value: sl
        /// </summary>
        [EnumMember(Value = "sl")]
        Sl = 42,

        /// <summary>
        /// Enum So for value: so
        /// </summary>
        [EnumMember(Value = "so")]
        So = 43,

        /// <summary>
        /// Enum Sq for value: sq
        /// </summary>
        [EnumMember(Value = "sq")]
        Sq = 44,

        /// <summary>
        /// Enum Sv for value: sv
        /// </summary>
        [EnumMember(Value = "sv")]
        Sv = 45,

        /// <summary>
        /// Enum Sw for value: sw
        /// </summary>
        [EnumMember(Value = "sw")]
        Sw = 46,

        /// <summary>
        /// Enum Ta for value: ta
        /// </summary>
        [EnumMember(Value = "ta")]
        Ta = 47,

        /// <summary>
        /// Enum Te for value: te
        /// </summary>
        [EnumMember(Value = "te")]
        Te = 48,

        /// <summary>
        /// Enum Th for value: th
        /// </summary>
        [EnumMember(Value = "th")]
        Th = 49,

        /// <summary>
        /// Enum Tl for value: tl
        /// </summary>
        [EnumMember(Value = "tl")]
        Tl = 50,

        /// <summary>
        /// Enum Tr for value: tr
        /// </summary>
        [EnumMember(Value = "tr")]
        Tr = 51,

        /// <summary>
        /// Enum Tw for value: tw
        /// </summary>
        [EnumMember(Value = "tw")]
        Tw = 52,

        /// <summary>
        /// Enum Uk for value: uk
        /// </summary>
        [EnumMember(Value = "uk")]
        Uk = 53,

        /// <summary>
        /// Enum Ur for value: ur
        /// </summary>
        [EnumMember(Value = "ur")]
        Ur = 54,

        /// <summary>
        /// Enum Vi for value: vi
        /// </summary>
        [EnumMember(Value = "vi")]
        Vi = 55

    }

}
