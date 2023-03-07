# LatestHeadlinesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get**](LatestHeadlinesApi.md#get) | **GET** /latest_headlines | Get Latest News Articles
[**post**](LatestHeadlinesApi.md#post) | **POST** /latest_headlines | Get Latest News Articles


# **get**
> Model200ResponseLatest get()

Get the latest headlines given any topic, country, or language.

### Example


```typescript
import { Newscatcher } from "newscatcherapi-typescript-sdk"

const newscatcher = new Newscatcher({
    // Defining the base path is optional and defaults to https://api.newscatcherapi.com/v2
    // basePath: "https://api.newscatcherapi.com/v2",
    apiKey: 'API_KEY',
})

let page = await newscatcher.latestHeadlines.get({
    'lang': "en",
    'notLang': "af",
    'countries': "US,CA",
    'notCountries': "US,CA",
    'topic': "business",
    'sources': "nytimes.com,theguardian.com",
    'notSources': "wsj.com",
    'rankedOnly': true,
    'pageSize': 100,
    'page': 1,
})
// Use .next() and .hasNext() to paginate forward
while (page.hasNext()) {
    page = await page.next();
    console.log(page.data);
}
// Use .previous() and .hasPrevious() to paginate backwards
while (page.hasPrevious()) {
    page = await page.previous();
    console.log(page.data);
}

```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lang** | 'af', 'ar', 'bg', 'bn', 'ca', 'cn', 'cs', 'cy', 'da', 'de', 'el', 'en', 'es', 'et', 'fa', 'fi', 'fr', 'gu', 'he', 'hi', 'hr', 'hu', 'id', 'it', 'ja', 'kn', 'ko', 'lt', 'lv', 'mk', 'ml', 'mr', 'ne', 'nl', 'false', 'pa', 'pl', 'pt', 'ro', 'ru', 'sk', 'sl', 'so', 'sq', 'sv', 'sw', 'ta', 'te', 'th', 'tl', 'tr', 'tw', 'uk', 'ur', 'vi' | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | (optional) defaults to undefined
 **notLang** | 'af', 'ar', 'bg', 'bn', 'ca', 'cn', 'cs', 'cy', 'da', 'de', 'el', 'en', 'es', 'et', 'fa', 'fi', 'fr', 'gu', 'he', 'hi', 'hr', 'hu', 'id', 'it', 'ja', 'kn', 'ko', 'lt', 'lv', 'mk', 'ml', 'mr', 'ne', 'nl', 'false', 'pa', 'pl', 'pt', 'ro', 'ru', 'sk', 'sl', 'so', 'sq', 'sv', 'sw', 'ta', 'te', 'th', 'tl', 'tr', 'tw', 'uk', 'ur', 'vi' | Inverse to the `lang` parameter  | (optional) defaults to undefined
 **countries** | [**string**] | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  | (optional) defaults to undefined
 **notCountries** | [**string**] | The inverse of the `countries` parameter.  | (optional) defaults to undefined
 **topic** | **Topic** | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | (optional) defaults to undefined
 **sources** | [**string**] | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com`  | (optional) defaults to undefined
 **notSources** | [**string**] | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com`  | (optional) defaults to undefined
 **rankedOnly** | [**boolean**] | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999`  | (optional) defaults to undefined
 **pageSize** | [**number**] | `[1:100]` How many articles to return per page.  | (optional) defaults to undefined
 **page** | [**number**] | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | (optional) defaults to undefined


### Return type

**Model200ResponseLatest**

### Authorization

[api_key](README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | API is not put in headers |  -  |
**401** | API Key not found |  -  |
**406** | Wrong parameter has been used |  -  |
**408** | Request Timeout |  -  |
**429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

# **post**
> Model200ResponseLatest post()

Get the latest headlines given any topic, country, or language.

### Example


```typescript
import { Newscatcher } from "newscatcherapi-typescript-sdk"

const newscatcher = new Newscatcher({
    // Defining the base path is optional and defaults to https://api.newscatcherapi.com/v2
    // basePath: "https://api.newscatcherapi.com/v2",
    apiKey: 'API_KEY',
})

let page = await newscatcher.latestHeadlines.post({
    'requestBody': {
        "when": "12h",
        "lang": "en",
        "countries": "US,CA",
        "topic": "business",
        "sources": "nytimes.com,theguardian.com",
        "not_sources": "wsj.com",
        "ranked_only": true,
        "page_size": 100,
        "page": 1,
    },
})
// Use .next() and .hasNext() to paginate forward
while (page.hasNext()) {
    page = await page.next();
    console.log(page.data);
}
// Use .previous() and .hasPrevious() to paginate backwards
while (page.hasPrevious()) {
    page = await page.previous();
    console.log(page.data);
}

```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latestHeadlines** | **LatestHeadlines**|  |


### Return type

**Model200ResponseLatest**

### Authorization

[api_key](README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | API is not put in headers |  -  |
**401** | API Key not found |  -  |
**406** | Wrong parameter has been used |  -  |
**408** | Request Timeout |  -  |
**429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


