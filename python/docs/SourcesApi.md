# newscatcherapi_client.SourcesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get**](SourcesApi.md#get) | **GET** /sources | Get top news sources supported by NewsCatcher.
[**post**](SourcesApi.md#post) | **POST** /sources | Get top news sources supported by NewsCatcher.


# **get**
> Model200ResponseSources get()

Get top news sources supported by NewsCatcher.

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example

* Api Key Authentication (api_key):

```python
import time
import newscatcherapi_client
from newscatcherapi_client.api import sources_api
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.model200_response_sources import Model200ResponseSources
from newscatcherapi_client.model.topic import Topic
from pprint import pprint
# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: api_key
configuration = newscatcherapi_client.Configuration(api_key={'api_key': 'YOUR_API_KEY'})

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['api_key'] = 'Bearer'

# Enter a context with an instance of the API client
with newscatcherapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = sources_api.SourcesApi(api_client)
    lang = "en" # str | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional)
    countries = "US,CA" # str | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional)
    topic = Topic("business") # Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get top news sources supported by NewsCatcher.
        api_response = api_instance.get(lang=lang, countries=countries, topic=topic)
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SourcesApi->get: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lang** | **str**| Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | [optional]
 **countries** | **str**| Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | [optional]
 **topic** | **Topic**| Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | [optional]

### Return type

[**Model200ResponseSources**](Model200ResponseSources.md)

### Authorization

[api_key](../README.md#api_key)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post**
> Model200ResponseSources post()

Get top news sources supported by NewsCatcher.

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example

* Api Key Authentication (api_key):

```python
import time
import newscatcherapi_client
from newscatcherapi_client.api import sources_api
from newscatcherapi_client.model.sources_query import SourcesQuery
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.model200_response_sources import Model200ResponseSources
from pprint import pprint
# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: api_key
configuration = newscatcherapi_client.Configuration(api_key={'api_key': 'YOUR_API_KEY'})

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['api_key'] = 'Bearer'

# Enter a context with an instance of the API client
with newscatcherapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = sources_api.SourcesApi(api_client)
    sources_query = SourcesQuery(
        lang="en",
        countries="US,CA",
        topic="business",
    ) # SourcesQuery |  (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get top news sources supported by NewsCatcher.
        api_response = api_instance.post(sources_query=sources_query)
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SourcesApi->post: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sources_query** | [**SourcesQuery**](SourcesQuery.md)|  | [optional]

### Return type

[**Model200ResponseSources**](Model200ResponseSources.md)

### Authorization

[api_key](../README.md#api_key)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

