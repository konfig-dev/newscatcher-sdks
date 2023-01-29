# Newscatcherapi.Net.Api.SearchApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](SearchApi.md#get) | **GET** /search | Search for specific news articles |
| [**Post**](SearchApi.md#post) | **POST** /search | Search for specific news articles |

<a name="get"></a>
# **Get**
> Model200Response Get (string q, string lang = null, string notLang = null, PublishDatePrecision? publishedDatePrecision = null, string from = null, string to = null, SearchIn? searchIn = null, string countries = null, string notCountries = null, Topic? topic = null, string sources = null, string notSources = null, bool? rankedOnly = null, int? fromRank = null, int? toRank = null, SortBy? sortBy = null, int? pageSize = null, int? page = null)

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Api;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.newscatcherapi.com/v2";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SearchApi(config);
            var q = "Elon Musk";  // string | Keyword/keywords you're searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations 
            var lang = en;  // string | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional) 
            var notLang = "af";  // string | Inverse to the `lang` parameter  (optional) 
            var publishedDatePrecision = (PublishDatePrecision) "full";  // PublishDatePrecision? | There are 3 types of date precision we define: `full` — day and time of an article is correctly identified with the appropriate timezone `timezone unknown` — day and time of an article is correctly identified without timezone `date` — only the day is identified without an exact time  (optional) 
            var from = "from_example";  // string | `YYYY/mm/dd` From which point in time to start the search. The default timezone is UTC. Defaults to the past week.  (optional) 
            var to = "to_example";  // string | `YYYY/mm/dd` Until which point in time to search for. The default timezone is UTC.  (optional) 
            var searchIn = (SearchIn) "title";  // SearchIn? | By default, we search what you specified in the `q` parameter in both `title` and `summary` of the article. However, you can limit this to either `title` or `summary`  (optional) 
            var countries = "countries_example";  // string | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional) 
            var notCountries = "notCountries_example";  // string | The inverse of the `countries` parameter.  (optional) 
            var topic = (Topic) "news";  // Topic? | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional) 
            var sources = "sources_example";  // string | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com`  (optional) 
            var notSources = "notSources_example";  // string | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com`  (optional) 
            var rankedOnly = true;  // bool? | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999`  (optional) 
            var fromRank = 56;  // int? | `[0:999999]` The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  (optional) 
            var toRank = 56;  // int? | `[0:999999]` The upper boundary of the rank of a news website to filter by.  (optional) 
            var sortBy = (SortBy) "relevancy";  // SortBy? | `relevancy` (default value) — the most relevant results first `date` — the most recently published results first `rank` — the results from the highest-ranked sources first  (optional) 
            var pageSize = 56;  // int? | `[1:100]` How many articles to return per page.  (optional) 
            var page = 56;  // int? | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  (optional) 

            try
            {
                // Search for specific news articles
                Model200Response result = apiInstance.Get(q, lang, notLang, publishedDatePrecision, from, to, searchIn, countries, notCountries, topic, sources, notSources, rankedOnly, fromRank, toRank, sortBy, pageSize, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for specific news articles
    ApiResponse<Model200Response> response = apiInstance.GetWithHttpInfo(q, lang, notLang, publishedDatePrecision, from, to, searchIn, countries, notCountries, topic, sources, notSources, rankedOnly, fromRank, toRank, sortBy, pageSize, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** | Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations  |  |
| **lang** | **string** | Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | [optional]  |
| **notLang** | **string** | Inverse to the &#x60;lang&#x60; parameter  | [optional]  |
| **publishedDatePrecision** | **PublishDatePrecision?** | There are 3 types of date precision we define: &#x60;full&#x60; — day and time of an article is correctly identified with the appropriate timezone &#x60;timezone unknown&#x60; — day and time of an article is correctly identified without timezone &#x60;date&#x60; — only the day is identified without an exact time  | [optional]  |
| **from** | **string** | &#x60;YYYY/mm/dd&#x60; From which point in time to start the search. The default timezone is UTC. Defaults to the past week.  | [optional]  |
| **to** | **string** | &#x60;YYYY/mm/dd&#x60; Until which point in time to search for. The default timezone is UTC.  | [optional]  |
| **searchIn** | **SearchIn?** | By default, we search what you specified in the &#x60;q&#x60; parameter in both &#x60;title&#x60; and &#x60;summary&#x60; of the article. However, you can limit this to either &#x60;title&#x60; or &#x60;summary&#x60;  | [optional]  |
| **countries** | **string** | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | [optional]  |
| **notCountries** | **string** | The inverse of the &#x60;countries&#x60; parameter.  | [optional]  |
| **topic** | **Topic?** | Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | [optional]  |
| **sources** | **string** | One or more news resources to filter your search. It should be the normal form of the URL, For example: &#x60;nytimes.com,theguardian.com&#x60;  | [optional]  |
| **notSources** | **string** | One or more sources to be excluded from the search. Comma-separated list. For example: &#x60;nytimes.com,cnn.com,wsj.com&#x60;  | [optional]  |
| **rankedOnly** | **bool?** | Default: &#x60;True&#x60; Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals &#x60;999999&#x60;  | [optional]  |
| **fromRank** | **int?** | &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | [optional]  |
| **toRank** | **int?** | &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | [optional]  |
| **sortBy** | **SortBy?** | &#x60;relevancy&#x60; (default value) — the most relevant results first &#x60;date&#x60; — the most recently published results first &#x60;rank&#x60; — the results from the highest-ranked sources first  | [optional]  |
| **pageSize** | **int?** | &#x60;[1:100]&#x60; How many articles to return per page.  | [optional]  |
| **page** | **int?** | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | [optional]  |

### Return type

[**Model200Response**](Model200Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | API is not put in headers |  -  |
| **401** | API Key not found |  -  |
| **406** | Wrong parameter has been used |  -  |
| **408** | Request Timeout |  -  |
| **429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> Model200Response Post (Search search = null)

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Api;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.newscatcherapi.com/v2";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SearchApi(config);
            var search = new Search(); // Search |  (optional) 

            try
            {
                // Search for specific news articles
                Model200Response result = apiInstance.Post(search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for specific news articles
    ApiResponse<Model200Response> response = apiInstance.PostWithHttpInfo(search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **search** | [**Search**](Search.md) |  | [optional]  |

### Return type

[**Model200Response**](Model200Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | API is not put in headers |  -  |
| **401** | API Key not found |  -  |
| **406** | Wrong parameter has been used |  -  |
| **408** | Request Timeout |  -  |
| **429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

