<a name="__pageTop"></a>
# newscatcherapi_client.apis.tags.sources_api.SourcesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get**](#get) | **get** /sources | Get top news sources supported by NewsCatcher.
[**post**](#post) | **post** /sources | Get top news sources supported by NewsCatcher.

# **get**
<a name="get"></a>
> Model200ResponseSources get()

Get top news sources supported by NewsCatcher.

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example

* Api Key Authentication (api_key):
```python
import newscatcherapi_client
from newscatcherapi_client.apis.tags import sources_api
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.model200_response_sources import Model200ResponseSources
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
    api_instance = sources_api.SourcesApi(api_client)

    # example passing only optional values
    query_params = {
        'lang': "en",
        'countries': "US,CA",
        'topic': Topic("business"),
    }
    try:
        # Get top news sources supported by NewsCatcher.
        api_response = api_instance.get(
            query_params=query_params,
        )
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SourcesApi->get: %s\n" % e)
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
lang | LangSchema | | optional
countries | CountriesSchema | | optional
topic | TopicSchema | | optional


# LangSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | must be one of ["af", "ar", "bg", "bn", "ca", "cn", "cs", "cy", "da", "de", "el", "en", "es", "et", "fa", "fi", "fr", "gu", "he", "hi", "hr", "hu", "id", "it", "ja", "kn", "ko", "lt", "lv", "mk", "ml", "mr", "ne", "nl", "false", "pa", "pl", "pt", "ro", "ru", "sk", "sl", "so", "sq", "sv", "sw", "ta", "te", "th", "tl", "tr", "tw", "uk", "ur", "vi", ] 

# CountriesSchema

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
str,  | str,  |  | 

# TopicSchema
Type | Description  | Notes
------------- | ------------- | -------------
[**Topic**](../../models/Topic.md) |  | 


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
[**Model200ResponseSources**](../../models/Model200ResponseSources.md) |  | 


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
> Model200ResponseSources post()

Get top news sources supported by NewsCatcher.

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example

* Api Key Authentication (api_key):
```python
import newscatcherapi_client
from newscatcherapi_client.apis.tags import sources_api
from newscatcherapi_client.model.sources_query import SourcesQuery
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.model200_response_sources import Model200ResponseSources
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
    api_instance = sources_api.SourcesApi(api_client)

    # example passing only optional values
    body = SourcesQuery(
        lang="en",
        countries="US,CA",
        topic="business",
    )
    try:
        # Get top news sources supported by NewsCatcher.
        api_response = api_instance.post(
            body=body,
        )
        pprint(api_response)
    except newscatcherapi_client.ApiException as e:
        print("Exception when calling SourcesApi->post: %s\n" % e)
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
[**SourcesQuery**](../../models/SourcesQuery.md) |  | 


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
[**Model200ResponseSources**](../../models/Model200ResponseSources.md) |  | 


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

