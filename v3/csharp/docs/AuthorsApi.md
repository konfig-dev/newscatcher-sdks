# Newscatcherapi.Net.Api.AuthorsApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](AuthorsApi.md#get) | **GET** /api/authors | [Get] Search By Author Request |
| [**Post**](AuthorsApi.md#post) | **POST** /api/authors | [Post] Search By Author Request |


# **Get**



This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.

### Example
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            NewscatcherClient client = new NewscatcherClient();
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

            var authorName = "authorName_example";
            var notAuthorName = "notAuthorName_example";
            var sources = new Object(
            );
            var predefinedSources = new Object(
            );
            var notSources = new Object(
            );
            var lang = new Object(
            );
            var notLang = new Object(
            );
            var countries = new Object(
            );
            var notCountries = new Object(
            );
            var from = new From(DateTime.Now);
            var to = new To(DateTime.Now);
            var publishedDatePrecision = "publishedDatePrecision_example";
            var byParseDate = false;
            var sortBy = "relevancy";
            var rankedOnly = new RankedOnly("example");
            var fromRank = 56;
            var toRank = 56;
            var isHeadline = true;
            var isOpinion = true;
            var isPaidContent = true;
            var parentUrl = new Object(
            );
            var allLinks = new Object(
            );
            var allDomainLinks = new Object(
            );
            var wordCountMin = 56;
            var wordCountMax = 56;
            var page = 1;
            var pageSize = 100;
            var includeNlpData = true;
            var hasNlp = true;
            var theme = "theme_example";
            var notTheme = "notTheme_example";
            var titleSentimentMin = 8.14D;
            var titleSentimentMax = 8.14D;
            var contentSentimentMin = 8.14D;
            var contentSentimentMax = 8.14D;
            var iptcTags = new Object(
            );
            var notIptcTags = new Object(
            );
            var iabTags = new Object(
            );
            var notIabTags = new Object(
            );
            
            try
            {
                // [Get] Search By Author Request
                AuthorsGetResponse result = client.Authors.Get(authorName, notAuthorName, sources, predefinedSources, notSources, lang, notLang, countries, notCountries, from, to, publishedDatePrecision, byParseDate, sortBy, rankedOnly, fromRank, toRank, isHeadline, isOpinion, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, includeNlpData, hasNlp, theme, notTheme, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax, iptcTags, notIptcTags, iabTags, notIabTags);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuthorsApi.Get: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
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
    // [Get] Search By Author Request
    ApiResponse<AuthorsGetResponse> response = apiInstance.GetWithHttpInfo(authorName, notAuthorName, sources, predefinedSources, notSources, lang, notLang, countries, notCountries, from, to, publishedDatePrecision, byParseDate, sortBy, rankedOnly, fromRank, toRank, isHeadline, isOpinion, isPaidContent, parentUrl, allLinks, allDomainLinks, wordCountMin, wordCountMax, page, pageSize, includeNlpData, hasNlp, theme, notTheme, titleSentimentMin, titleSentimentMax, contentSentimentMin, contentSentimentMax, iptcTags, notIptcTags, iabTags, notIabTags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorsApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorName** | **string** |  |  |
| **notAuthorName** | **string** |  | [optional]  |
| **sources** | [**Object**](Object.md) |  | [optional]  |
| **predefinedSources** | [**Object**](Object.md) |  | [optional]  |
| **notSources** | [**Object**](Object.md) |  | [optional]  |
| **lang** | [**Object**](Object.md) |  | [optional]  |
| **notLang** | [**Object**](Object.md) |  | [optional]  |
| **countries** | [**Object**](Object.md) |  | [optional]  |
| **notCountries** | [**Object**](Object.md) |  | [optional]  |
| **from** | [**From**](From.md) |  | [optional]  |
| **to** | [**To**](To.md) |  | [optional]  |
| **publishedDatePrecision** | **string** |  | [optional]  |
| **byParseDate** | **bool?** |  | [optional] [default to false] |
| **sortBy** | **string** |  | [optional] [default to &quot;relevancy&quot;] |
| **rankedOnly** | [**RankedOnly**](RankedOnly.md) |  | [optional]  |
| **fromRank** | **int?** |  | [optional]  |
| **toRank** | **int?** |  | [optional]  |
| **isHeadline** | **bool?** |  | [optional]  |
| **isOpinion** | **bool?** |  | [optional]  |
| **isPaidContent** | **bool?** |  | [optional]  |
| **parentUrl** | [**Object**](Object.md) |  | [optional]  |
| **allLinks** | [**Object**](Object.md) |  | [optional]  |
| **allDomainLinks** | [**Object**](Object.md) |  | [optional]  |
| **wordCountMin** | **int?** |  | [optional]  |
| **wordCountMax** | **int?** |  | [optional]  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 100] |
| **includeNlpData** | **bool?** |  | [optional]  |
| **hasNlp** | **bool?** |  | [optional]  |
| **theme** | **string** |  | [optional]  |
| **notTheme** | **string** |  | [optional]  |
| **titleSentimentMin** | **double?** |  | [optional]  |
| **titleSentimentMax** | **double?** |  | [optional]  |
| **contentSentimentMin** | **double?** |  | [optional]  |
| **contentSentimentMax** | **double?** |  | [optional]  |
| **iptcTags** | [**Object**](Object.md) |  | [optional]  |
| **notIptcTags** | [**Object**](Object.md) |  | [optional]  |
| **iabTags** | [**Object**](Object.md) |  | [optional]  |
| **notIabTags** | [**Object**](Object.md) |  | [optional]  |

### Return type

[**AuthorsGetResponse**](AuthorsGetResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# **Post**



This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.

### Example
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newscatcherapi.Net.Client;
using Newscatcherapi.Net.Model;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            NewscatcherClient client = new NewscatcherClient();
            // Configure API key authorization: apiKey
            client.SetApiKey("YOUR_API_KEY");

            var authorName = "authorName_example";
            var notAuthorName = "notAuthorName_example";
            var sources = "sources_example";
            var predefinedSources = "predefinedSources_example";
            var notSources = "notSources_example";
            var lang = "lang_example";
            var notLang = "notLang_example";
            var countries = "countries_example";
            var notCountries = "notCountries_example";
            var from = new From(DateTime.Now);
            var to = new To(DateTime.Now);
            var publishedDatePrecision = "publishedDatePrecision_example";
            var byParseDate = false;
            var sortBy = "relevancy";
            var rankedOnly = new RankedOnly("example");
            var fromRank = default(int);
            var toRank = default(int);
            var isHeadline = false;
            var isOpinion = false;
            var isPaidContent = false;
            var parentUrl = "parentUrl_example";
            var allLinks = "allLinks_example";
            var allDomainLinks = "allDomainLinks_example";
            var wordCountMin = default(int);
            var wordCountMax = default(int);
            var page = 1;
            var pageSize = 100;
            var includeNlpData = false;
            var hasNlp = false;
            var theme = "theme_example";
            var notTheme = "notTheme_example";
            var titleSentimentMin = default(double);
            var titleSentimentMax = default(double);
            var contentSentimentMin = default(double);
            var contentSentimentMax = default(double);
            var iptcTags = "iptcTags_example";
            var notIptcTags = "notIptcTags_example";
            var iabTags = "iabTags_example";
            var notIabTags = "notIabTags_example";
            
            var authorSearchRequest = new AuthorSearchRequest(
                authorName,
                notAuthorName,
                sources,
                predefinedSources,
                notSources,
                lang,
                notLang,
                countries,
                notCountries,
                from,
                to,
                publishedDatePrecision,
                byParseDate,
                sortBy,
                rankedOnly,
                fromRank,
                toRank,
                isHeadline,
                isOpinion,
                isPaidContent,
                parentUrl,
                allLinks,
                allDomainLinks,
                wordCountMin,
                wordCountMax,
                page,
                pageSize,
                includeNlpData,
                hasNlp,
                theme,
                notTheme,
                titleSentimentMin,
                titleSentimentMax,
                contentSentimentMin,
                contentSentimentMax,
                iptcTags,
                notIptcTags,
                iabTags,
                notIabTags
            );
            
            try
            {
                // [Post] Search By Author Request
                AuthorsPostResponse result = client.Authors.Post(authorSearchRequest);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuthorsApi.Post: " + e.Message);
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e.Response.StatusCode);
                Console.WriteLine(e.Response.RawContent);
                Console.WriteLine(e.InnerException);
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
    // [Post] Search By Author Request
    ApiResponse<AuthorsPostResponse> response = apiInstance.PostWithHttpInfo(authorSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorsApi.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorSearchRequest** | [**AuthorSearchRequest**](AuthorSearchRequest.md) |  |  |

### Return type

[**AuthorsPostResponse**](AuthorsPostResponse.md)


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

