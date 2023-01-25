# newscatcherapi_client.SearchApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get**](SearchApi.md#get) | **GET** /search | Search for specific news articles
[**post**](SearchApi.md#post) | **POST** /search | Search for specific news articles


# **get**
> Model200Response get(q)

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example

* Api Key Authentication (api_key):

```python
import time
import newscatcherapi_client
from newscatcherapi_client.api import search_api
from newscatcherapi_client.model.publish_date_precision import PublishDatePrecision
from newscatcherapi_client.model.sort_by import SortBy
from newscatcherapi_client.model.page import Page
from newscatcherapi_client.model.model200_response import Model200Response
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.rank import Rank
from newscatcherapi_client.model.search_in import SearchIn
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
    api_instance = search_api.SearchApi(api_client)
    q = "Elon Musk" # str | Keyword/keywords you're searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations 
    lang = "en" # str | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional)
    not_lang = "af" # str | Inverse to the `lang` parameter  (optional)
    published_date_precision = PublishDatePrecision("full") # PublishDatePrecision | There are 3 types of date precision we define: `full` — day and time of an article is correctly identified with the appropriate timezone `timezone unknown` — day and time of an article is correctly identified without timezone `date` — only the day is identified without an exact time  (optional)
    _from = "2021/05/06" # str | `YYYY/mm/dd` From which point in time to start the search. The default timezone is UTC. Defaults to the past week.  (optional)
    to = "2021/05/06" # str | `YYYY/mm/dd` Until which point in time to search for. The default timezone is UTC.  (optional)
    search_in = SearchIn("title") # SearchIn | By default, we search what you specified in the `q` parameter in both `title` and `summary` of the article. However, you can limit this to either `title` or `summary`  (optional)
    countries = "US,CA" # str | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional)
    not_countries = "US,CA" # str | The inverse of the `countries` parameter.  (optional)
    topic = Topic("business") # Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional)
    sources = "nytimes.com,theguardian.com" # str | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com`  (optional)
    not_sources = "nytimes.com,theguardian.com" # str | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com`  (optional)
    ranked_only = True # bool | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999`  (optional)
    from_rank = Rank(1000) # Rank | `[0:999999]` The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  (optional)
    to_rank = Rank(1000) # Rank | `[0:999999]` The upper boundary of the rank of a news website to filter by.  (optional)
    sort_by = SortBy("rank") # SortBy | `relevancy` (default value) — the most relevant results first `date` — the most recently published results first `rank` — the results from the highest-ranked sources first  (optional)
    page_size = PageSize(100) # PageSize | `[1:100]` How many articles to return per page.  (optional)
    page = Page(1) # Page | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  (optional)

    # example passing only required values which don't have defaults set
    try:
        # Search for specific news articles
        api_response = api_instance.get(q)
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SearchApi->get: %s\n" % e)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Search for specific news articles
        api_response = api_instance.get(q, lang=lang, not_lang=not_lang, published_date_precision=published_date_precision, _from=_from, to=to, search_in=search_in, countries=countries, not_countries=not_countries, topic=topic, sources=sources, not_sources=not_sources, ranked_only=ranked_only, from_rank=from_rank, to_rank=to_rank, sort_by=sort_by, page_size=page_size, page=page)
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SearchApi->get: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **str**| Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations  |
 **lang** | **str**| Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | [optional]
 **not_lang** | **str**| Inverse to the &#x60;lang&#x60; parameter  | [optional]
 **published_date_precision** | **PublishDatePrecision**| There are 3 types of date precision we define: &#x60;full&#x60; — day and time of an article is correctly identified with the appropriate timezone &#x60;timezone unknown&#x60; — day and time of an article is correctly identified without timezone &#x60;date&#x60; — only the day is identified without an exact time  | [optional]
 **_from** | **str**| &#x60;YYYY/mm/dd&#x60; From which point in time to start the search. The default timezone is UTC. Defaults to the past week.  | [optional]
 **to** | **str**| &#x60;YYYY/mm/dd&#x60; Until which point in time to search for. The default timezone is UTC.  | [optional]
 **search_in** | **SearchIn**| By default, we search what you specified in the &#x60;q&#x60; parameter in both &#x60;title&#x60; and &#x60;summary&#x60; of the article. However, you can limit this to either &#x60;title&#x60; or &#x60;summary&#x60;  | [optional]
 **countries** | **str**| Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | [optional]
 **not_countries** | **str**| The inverse of the &#x60;countries&#x60; parameter.  | [optional]
 **topic** | **Topic**| Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | [optional]
 **sources** | **str**| One or more news resources to filter your search. It should be the normal form of the URL, For example: &#x60;nytimes.com,theguardian.com&#x60;  | [optional]
 **not_sources** | **str**| One or more sources to be excluded from the search. Comma-separated list. For example: &#x60;nytimes.com,cnn.com,wsj.com&#x60;  | [optional]
 **ranked_only** | **bool**| Default: &#x60;True&#x60; Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals &#x60;999999&#x60;  | [optional]
 **from_rank** | **Rank**| &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | [optional]
 **to_rank** | **Rank**| &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | [optional]
 **sort_by** | **SortBy**| &#x60;relevancy&#x60; (default value) — the most relevant results first &#x60;date&#x60; — the most recently published results first &#x60;rank&#x60; — the results from the highest-ranked sources first  | [optional]
 **page_size** | **PageSize**| &#x60;[1:100]&#x60; How many articles to return per page.  | [optional]
 **page** | **Page**| The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | [optional]

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
**200** | OK |  -  |
**400** | API is not put in headers |  -  |
**401** | API Key not found |  -  |
**406** | Wrong parameter has been used |  -  |
**408** | Request Timeout |  -  |
**429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post**
> Model200Response post()

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example

* Api Key Authentication (api_key):

```python
import time
import newscatcherapi_client
from newscatcherapi_client.api import search_api
from newscatcherapi_client.model.search import Search
from newscatcherapi_client.model.model200_response import Model200Response
from newscatcherapi_client.model.error_response import ErrorResponse
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
    api_instance = search_api.SearchApi(api_client)
    search = Search(
        q="Elon Musk",
        lang="en",
        not_lang="af",
        published_date_precision="full",
        _from="2021/05/06",
        to="2021/05/06",
        search_in="title",
        countries="US,CA",
        not_countries="not_countries_example",
        topic="business",
        sources="nytimes.com,theguardian.com",
        not_sources="not_sources_example",
        ranked_only=True,
        sort_by="rank",
        page_size=100,
        page=1,
    ) # Search |  (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Search for specific news articles
        api_response = api_instance.post(search=search)
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SearchApi->post: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | [**Search**](Search.md)|  | [optional]

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
**200** | OK |  -  |
**400** | API is not put in headers |  -  |
**401** | API Key not found |  -  |
**406** | Wrong parameter has been used |  -  |
**408** | Request Timeout |  -  |
**429** | Concurrency violated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

