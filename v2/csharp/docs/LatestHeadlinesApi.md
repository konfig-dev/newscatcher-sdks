# Newscatcherapi.Net.Api.LatestHeadlinesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](LatestHeadlinesApi.md#get) | **GET** /latest_headlines | Get Latest News Articles |
| [**Post**](LatestHeadlinesApi.md#post) | **POST** /latest_headlines | Get Latest News Articles |

<a name="get"></a>
# **Get**
> Model200ResponseLatest Get (string lang = null, string notLang = null, string countries = null, string notCountries = null, Topic? topic = null, string sources = null, string notSources = null, bool? rankedOnly = null, int? pageSize = null, int? page = null)

Get Latest News Articles

Get the latest headlines given any topic, country, or language.

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

            var apiInstance = new LatestHeadlinesApi(config);
            var lang = en;  // string | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional) 
            var notLang = "af";  // string | Inverse to the `lang` parameter  (optional) 
            var countries = "countries_example";  // string | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional) 
            var notCountries = "notCountries_example";  // string | The inverse of the `countries` parameter.  (optional) 
            var topic = (Topic) "news";  // Topic? | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional) 
            var sources = "sources_example";  // string | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com`  (optional) 
            var notSources = "notSources_example";  // string | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com`  (optional) 
            var rankedOnly = true;  // bool? | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999`  (optional) 
            var pageSize = 56;  // int? | `[1:100]` How many articles to return per page.  (optional) 
            var page = 56;  // int? | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  (optional) 

            try
            {
                // Get Latest News Articles
                Model200ResponseLatest result = apiInstance.Get(lang, notLang, countries, notCountries, topic, sources, notSources, rankedOnly, pageSize, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LatestHeadlinesApi.Get: " + e.Message);
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
    // Get Latest News Articles
    ApiResponse<Model200ResponseLatest> response = apiInstance.GetWithHttpInfo(lang, notLang, countries, notCountries, topic, sources, notSources, rankedOnly, pageSize, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LatestHeadlinesApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lang** | **string** | Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | [optional]  |
| **notLang** | **string** | Inverse to the &#x60;lang&#x60; parameter  | [optional]  |
| **countries** | **string** | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | [optional]  |
| **notCountries** | **string** | The inverse of the &#x60;countries&#x60; parameter.  | [optional]  |
| **topic** | **Topic?** | Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | [optional]  |
| **sources** | **string** | One or more news resources to filter your search. It should be the normal form of the URL, For example: &#x60;nytimes.com,theguardian.com&#x60;  | [optional]  |
| **notSources** | **string** | One or more sources to be excluded from the search. Comma-separated list. For example: &#x60;nytimes.com,cnn.com,wsj.com&#x60;  | [optional]  |
| **rankedOnly** | **bool?** | Default: &#x60;True&#x60; Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals &#x60;999999&#x60;  | [optional]  |
| **pageSize** | **int?** | &#x60;[1:100]&#x60; How many articles to return per page.  | [optional]  |
| **page** | **int?** | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | [optional]  |

### Return type

[**Model200ResponseLatest**](Model200ResponseLatest.md)

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
> Model200ResponseLatest Post (LatestHeadlines latestHeadlines = null)

Get Latest News Articles

Get the latest headlines given any topic, country, or language.

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

            var apiInstance = new LatestHeadlinesApi(config);
            var latestHeadlines = new LatestHeadlines(); // LatestHeadlines |  (optional) 

            try
            {
                // Get Latest News Articles
                Model200ResponseLatest result = apiInstance.Post(latestHeadlines);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LatestHeadlinesApi.Post: " + e.Message);
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
    // Get Latest News Articles
    ApiResponse<Model200ResponseLatest> response = apiInstance.PostWithHttpInfo(latestHeadlines);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LatestHeadlinesApi.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **latestHeadlines** | [**LatestHeadlines**](LatestHeadlines.md) |  | [optional]  |

### Return type

[**Model200ResponseLatest**](Model200ResponseLatest.md)

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

