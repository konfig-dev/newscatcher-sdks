<a name="__pageTop"></a>
# newscatcherapi_client.apis.tags.search_api.SearchApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get**](#get) | **get** /search | Search for specific news articles
[**post**](#post) | **post** /search | Search for specific news articles

# **get**
<a name="get"></a>
> Model200Response get(q)

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example

* Api Key Authentication (api_key):
```python
import newscatcherapi_client
from newscatcherapi_client.apis.tags import search_api
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
# Defining the host is optional and defaults to https://api.newscatcherapi.com/v2
# See configuration.py for a list of all supported configuration parameters.
configuration = newscatcherapi_client.Configuration(
    host = "https://api.newscatcherapi.com/v2"
)

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

    # example passing only required values which don't have defaults set
    query_params = {
        'q': "\"Elon Musk\"",
    }
    try:
        # Search for specific news articles
        api_response = api_instance.get(
            query_params=query_params,
        )
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SearchApi->get: %s\n" % e)

    # example passing only optional values
    query_params = {
        'q': "\"Elon Musk\"",
        'lang': "en",
        'not_lang': "af",
        'published_date_precision': PublishDatePrecision("full"),
        'from': "2021/05/06",
        'to': "2021/05/06",
        'search_in': SearchIn("title"),
        'countries': "US,CA",
        'not_countries': "US,CA",
        'topic': Topic("business"),
        'sources': "nytimes.com,theguardian.com",
        'not_sources': "wsj.com",
        'ranked_only': True,
        'from_rank': Rank(1000),
        'to_rank': Rank(1000),
        'sort_by': SortBy("rank"),
        'page_size': PageSize(100),
        'page': Page(1),
    }
    try:
        # Search for specific news articles
        api_response = api_instance.get(
            query_params=query_params,
        )
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SearchApi->get: %s\n" % e)
```
### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
query_params | RequestQueryParams | |
accept_content_types | typing.Tuple[str] | default is ('application/json', ) | Tells the server the content type(s) that are accepted by the client
stream | bool | default is False | if True then the response.content will be streamed and loaded from a file like object. When downloading a file, set this to True to force the code to deserialize the content to a FileSchema file
timeout | typing.Optional[typing.Union[int, typing.Tuple]] | default is None | the timeout used by the rest client
skip_deserialization | bool | default is False | when True, headers and body will be unset and an instance of api_client.ApiResponseWithoutDeserialization will be returned

### query_params
#### RequestQueryParams

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
q | QSchema | | 
lang | LangSchema | | optional
not_lang | NotLangSchema | | optional
published_date_precision | PublishedDatePrecisionSchema | | optional
from | ModelFromSchema | | optional
to | ToSchema | | optional
search_in | SearchInSchema | | optional
countries | CountriesSchema | | optional
not_countries | NotCountriesSchema | | optional
topic | TopicSchema | | optional
sources | SourcesSchema | | optional
not_sources | NotSourcesSchema | | optional
ranked_only | RankedOnlySchema | | optional
from_rank | FromRankSchema | | optional
to_rank | ToRankSchema | | optional
sort_by | SortBySchema | | optional
page_size | PageSizeSchema | | optional
page | PageSchema | | optional


# QSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# LangSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | must be one of ["af", "ar", "bg", "bn", "ca", "cn", "cs", "cy", "da", "de", "el", "en", "es", "et", "fa", "fi", "fr", "gu", "he", "hi", "hr", "hu", "id", "it", "ja", "kn", "ko", "lt", "lv", "mk", "ml", "mr", "ne", "nl", "false", "pa", "pl", "pt", "ro", "ru", "sk", "sl", "so", "sq", "sv", "sw", "ta", "te", "th", "tl", "tr", "tw", "uk", "ur", "vi", ] 

# NotLangSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | must be one of ["af", "ar", "bg", "bn", "ca", "cn", "cs", "cy", "da", "de", "el", "en", "es", "et", "fa", "fi", "fr", "gu", "he", "hi", "hr", "hu", "id", "it", "ja", "kn", "ko", "lt", "lv", "mk", "ml", "mr", "ne", "nl", "false", "pa", "pl", "pt", "ro", "ru", "sk", "sl", "so", "sq", "sv", "sw", "ta", "te", "th", "tl", "tr", "tw", "uk", "ur", "vi", ] 

# PublishedDatePrecisionSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**PublishDatePrecision**](../../models/PublishDatePrecision.md) |  | 


# ModelFromSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# ToSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# SearchInSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**SearchIn**](../../models/SearchIn.md) |  | 


# CountriesSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# NotCountriesSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# TopicSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**Topic**](../../models/Topic.md) |  | 


# SourcesSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# NotSourcesSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# RankedOnlySchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
bool,  | BoolClass,  |  | 

# FromRankSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**Rank**](../../models/Rank.md) |  | 


# ToRankSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**Rank**](../../models/Rank.md) |  | 


# SortBySchema
Type | Description  | Notes
------------- | ------------- | -------------
[**SortBy**](../../models/SortBy.md) |  | 


# PageSizeSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**PageSize**](../../models/PageSize.md) |  | 


# PageSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**Page**](../../models/Page.md) |  | 


### Return Types, Responses

Code | Class | Description
------------- | ------------- | -------------
n/a | api_client.ApiResponseWithoutDeserialization | When skip_deserialization is True this response is returned
200 | [ApiResponseFor200](#get.ApiResponseFor200) | OK
400 | [ApiResponseFor400](#get.ApiResponseFor400) | API is not put in headers
401 | [ApiResponseFor401](#get.ApiResponseFor401) | API Key not found
406 | [ApiResponseFor406](#get.ApiResponseFor406) | Wrong parameter has been used
408 | [ApiResponseFor408](#get.ApiResponseFor408) | Request Timeout
429 | [ApiResponseFor429](#get.ApiResponseFor429) | Concurrency violated

#### get.ApiResponseFor200
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor200ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor200ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**Model200Response**](../../models/Model200Response.md) |  | 


#### get.ApiResponseFor400
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor400ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor400ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### get.ApiResponseFor401
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor401ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor401ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### get.ApiResponseFor406
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor406ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor406ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### get.ApiResponseFor408
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor408ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor408ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### get.ApiResponseFor429
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor429ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor429ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


### Authorization

[api_key](../../../README.md#api_key)

[[Back to top]](#__pageTop) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **post**
<a name="post"></a>
> Model200Response post()

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example

* Api Key Authentication (api_key):
```python
import newscatcherapi_client
from newscatcherapi_client.apis.tags import search_api
from newscatcherapi_client.model.search import Search
from newscatcherapi_client.model.model200_response import Model200Response
from newscatcherapi_client.model.error_response import ErrorResponse
from pprint import pprint
# Defining the host is optional and defaults to https://api.newscatcherapi.com/v2
# See configuration.py for a list of all supported configuration parameters.
configuration = newscatcherapi_client.Configuration(
    host = "https://api.newscatcherapi.com/v2"
)

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

    # example passing only optional values
    body = Search(
        q="\"Elon Musk\"",
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
        from_rank=0,
        to_rank=0,
        sort_by="rank",
        page_size=100,
        page=1,
    )
    try:
        # Search for specific news articles
        api_response = api_instance.post(
            body=body,
        )
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SearchApi->post: %s\n" % e)
```
### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
body | typing.Union[SchemaForRequestBodyApplicationJson, Unset] | optional, default is unset |
content_type | str | optional, default is 'application/json' | Selects the schema and serialization of the request body
accept_content_types | typing.Tuple[str] | default is ('application/json', ) | Tells the server the content type(s) that are accepted by the client
stream | bool | default is False | if True then the response.content will be streamed and loaded from a file like object. When downloading a file, set this to True to force the code to deserialize the content to a FileSchema file
timeout | typing.Optional[typing.Union[int, typing.Tuple]] | default is None | the timeout used by the rest client
skip_deserialization | bool | default is False | when True, headers and body will be unset and an instance of api_client.ApiResponseWithoutDeserialization will be returned

### body

# SchemaForRequestBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**Search**](../../models/Search.md) |  | 


### Return Types, Responses

Code | Class | Description
------------- | ------------- | -------------
n/a | api_client.ApiResponseWithoutDeserialization | When skip_deserialization is True this response is returned
200 | [ApiResponseFor200](#post.ApiResponseFor200) | OK
400 | [ApiResponseFor400](#post.ApiResponseFor400) | API is not put in headers
401 | [ApiResponseFor401](#post.ApiResponseFor401) | API Key not found
406 | [ApiResponseFor406](#post.ApiResponseFor406) | Wrong parameter has been used
408 | [ApiResponseFor408](#post.ApiResponseFor408) | Request Timeout
429 | [ApiResponseFor429](#post.ApiResponseFor429) | Concurrency violated

#### post.ApiResponseFor200
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor200ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor200ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**Model200Response**](../../models/Model200Response.md) |  | 


#### post.ApiResponseFor400
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor400ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor400ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### post.ApiResponseFor401
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor401ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor401ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### post.ApiResponseFor406
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor406ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor406ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### post.ApiResponseFor408
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor408ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor408ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


#### post.ApiResponseFor429
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
response | urllib3.HTTPResponse | Raw response |
body | typing.Union[SchemaFor429ResponseBodyApplicationJson, ] |  |
headers | Unset | headers were not defined |

# SchemaFor429ResponseBodyApplicationJson
Type | Description  | Notes
------------- | ------------- | -------------
[**ErrorResponse**](../../models/ErrorResponse.md) |  | 


### Authorization

[api_key](../../../README.md#api_key)

[[Back to top]](#__pageTop) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

