# newscatcherapi_client.LatestHeadlinesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get**](LatestHeadlinesApi.md#get) | **GET** /latest_headlines | Get Latest News Articles
[**post**](LatestHeadlinesApi.md#post) | **POST** /latest_headlines | Get Latest News Articles


# **get**
> Model200ResponseLatest get()

Get Latest News Articles

Get the latest headlines given any topic, country, or language.

### Example

* Api Key Authentication (api_key):

```python
import time
import newscatcherapi_client
from newscatcherapi_client.api import latest_headlines_api
from newscatcherapi_client.model.model200_response_latest import Model200ResponseLatest
from newscatcherapi_client.model.page import Page
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.page_size import PageSize
from newscatcherapi_client.model.topic import Topic
from pprint import pprint
# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: api_key
configuration.api_key['api_key'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['api_key'] = 'Bearer'

# Enter a context with an instance of the API client
with newscatcherapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = latest_headlines_api.LatestHeadlinesApi(api_client)
    lang = "en" # str | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional)
    not_lang = "af" # str | Inverse to the `lang` parameter  (optional)
    countries = "US,CA" # str | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional)
    not_countries = "US,CA" # str | The inverse of the `countries` parameter.  (optional)
    topic = Topic("business") # Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional)
    sources = "nytimes.com,theguardian.com" # str | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com`  (optional)
    not_sources = "nytimes.com,theguardian.com" # str | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com`  (optional)
    ranked_only = True # bool | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999`  (optional)
    page_size = PageSize(100) # PageSize | `[1:100]` How many articles to return per page.  (optional)
    page = Page(1) # Page | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get Latest News Articles
        api_response = api_instance.get(lang=lang, not_lang=not_lang, countries=countries, not_countries=not_countries, topic=topic, sources=sources, not_sources=not_sources, ranked_only=ranked_only, page_size=page_size, page=page)
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling LatestHeadlinesApi->get: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lang** | **str**| Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | [optional]
 **not_lang** | **str**| Inverse to the &#x60;lang&#x60; parameter  | [optional]
 **countries** | **str**| Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | [optional]
 **not_countries** | **str**| The inverse of the &#x60;countries&#x60; parameter.  | [optional]
 **topic** | **Topic**| Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | [optional]
 **sources** | **str**| One or more news resources to filter your search. It should be the normal form of the URL, For example: &#x60;nytimes.com,theguardian.com&#x60;  | [optional]
 **not_sources** | **str**| One or more sources to be excluded from the search. Comma-separated list. For example: &#x60;nytimes.com,cnn.com,wsj.com&#x60;  | [optional]
 **ranked_only** | **bool**| Default: &#x60;True&#x60; Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals &#x60;999999&#x60;  | [optional]
 **page_size** | **PageSize**| &#x60;[1:100]&#x60; How many articles to return per page.  | [optional]
 **page** | **Page**| The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | [optional]

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
**200** | OK |  -  |
**400** | API is not put in headers |  -  |
**401** | API Key not found |  -  |
**406** | Wrong parameter has been used |  -  |
**408** | Request Timeout |  -  |
**429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post**
> Model200ResponseLatest post()

Get Latest News Articles

Get the latest headlines given any topic, country, or language.

### Example

* Api Key Authentication (api_key):

```python
import time
import newscatcherapi_client
from newscatcherapi_client.api import latest_headlines_api
from newscatcherapi_client.model.model200_response_latest import Model200ResponseLatest
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.latest_headlines import LatestHeadlines
from pprint import pprint
# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: api_key
configuration.api_key['api_key'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['api_key'] = 'Bearer'

# Enter a context with an instance of the API client
with newscatcherapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = latest_headlines_api.LatestHeadlinesApi(api_client)
    latest_headlines = LatestHeadlines(
        when="24h",
        lang="en",
        countries="US,CA",
        not_countries="not_countries_example",
        topic="business",
        sources="nytimes.com,theguardian.com",
        not_sources="not_sources_example",
        ranked_only=True,
        sort_by="rank",
        page_size=100,
        page=1,
    ) # LatestHeadlines |  (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get Latest News Articles
        api_response = api_instance.post(latest_headlines=latest_headlines)
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling LatestHeadlinesApi->post: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latest_headlines** | [**LatestHeadlines**](LatestHeadlines.md)|  | [optional]

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
**200** | OK |  -  |
**400** | API is not put in headers |  -  |
**401** | API Key not found |  -  |
**406** | Wrong parameter has been used |  -  |
**408** | Request Timeout |  -  |
**429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

