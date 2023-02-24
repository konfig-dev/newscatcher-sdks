# SourcesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get**](SourcesApi.md#get) | **GET** /sources | Get top news sources supported by NewsCatcher.
[**post**](SourcesApi.md#post) | **POST** /sources | Get top news sources supported by NewsCatcher.


# **get**
> Model200ResponseSources get()

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example


```typescript
import { Newscatcher } from "newscatcherapi-typescript-sdk"

const newscatcher = new Newscatcher({
    apiKey: 'API_KEY',
})

const response = await newscatcher.sources.get({
        'lang': "en",
        'countries': "US,CA",
        'topic': "business",
})
console.log(response)

```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lang** | 'af', 'ar', 'bg', 'bn', 'ca', 'cn', 'cs', 'cy', 'da', 'de', 'el', 'en', 'es', 'et', 'fa', 'fi', 'fr', 'gu', 'he', 'hi', 'hr', 'hu', 'id', 'it', 'ja', 'kn', 'ko', 'lt', 'lv', 'mk', 'ml', 'mr', 'ne', 'nl', 'false', 'pa', 'pl', 'pt', 'ro', 'ru', 'sk', 'sl', 'so', 'sq', 'sv', 'sw', 'ta', 'te', 'th', 'tl', 'tr', 'tw', 'uk', 'ur', 'vi' | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | (optional) defaults to undefined
 **countries** | [**string**] | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  | (optional) defaults to undefined
 **topic** | **Topic** | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | (optional) defaults to undefined


### Return type

**Model200ResponseSources**

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
> Model200ResponseSources post()

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example


```typescript
import { Newscatcher } from "newscatcherapi-typescript-sdk"

const newscatcher = new Newscatcher({
    apiKey: 'API_KEY',
})

const response = await newscatcher.sources.post({
        'requestBody': {
        'lang': "en",
        'countries': "US,CA",
        'topic': "business",
    },
})
console.log(response)

```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourcesQuery** | **SourcesQuery**|  |


### Return type

**Model200ResponseSources**

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


