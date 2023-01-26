"""
    NewsCatcher News API V2

    NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python)   # noqa: E501

    The version of the OpenAPI document: 1.0.1
    Contact: team@newscatcherapi.com
    Generated by: https://konfigthis.com
"""


import re  # noqa: F401
import sys  # noqa: F401

from newscatcherapi_client.api_client import ApiClient, Endpoint as _Endpoint
from newscatcherapi_client.model_utils import (  # noqa: F401
    check_allowed_values,
    check_validations,
    date,
    datetime,
    file_type,
    none_type,
    validate_and_convert_types
)
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.latest_headlines import LatestHeadlines
from newscatcherapi_client.model.model200_response_latest import Model200ResponseLatest
from newscatcherapi_client.model.page import Page
from newscatcherapi_client.model.page_size import PageSize
from newscatcherapi_client.model.topic import Topic


class LatestHeadlinesApi(object):
    """NOTE: This class is auto generated by Konfig
    Ref: https://konfigthis.com

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client
        self.headlines_get_endpoint = _Endpoint(
            settings={
                'response_type': (Model200ResponseLatest,),
                'auth': [
                    'api_key'
                ],
                'endpoint_path': '/latest_headlines',
                'operation_id': 'headlines_get',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'lang',
                    'not_lang',
                    'countries',
                    'not_countries',
                    'topic',
                    'sources',
                    'not_sources',
                    'ranked_only',
                    'page_size',
                    'page',
                ],
                'required': [],
                'nullable': [
                ],
                'enum': [
                    'lang',
                    'not_lang',
                ],
                'validation': [
                    'page_size',
                    'page',
                ]
            },
            root_map={
                'validations': {
                    ('page_size',): {

                        'inclusive_maximum': 100,
                        'inclusive_minimum': 1,
                    },
                    ('page',): {

                        'inclusive_minimum': 1,
                    },
                },
                'allowed_values': {
                    ('lang',): {

                        "AF": "af",
                        "AR": "ar",
                        "BG": "bg",
                        "BN": "bn",
                        "CA": "ca",
                        "CN": "cn",
                        "CS": "cs",
                        "CY": "cy",
                        "DA": "da",
                        "DE": "de",
                        "EL": "el",
                        "EN": "en",
                        "ES": "es",
                        "ET": "et",
                        "FA": "fa",
                        "FI": "fi",
                        "FR": "fr",
                        "GU": "gu",
                        "HE": "he",
                        "HI": "hi",
                        "HR": "hr",
                        "HU": "hu",
                        "ID": "id",
                        "IT": "it",
                        "JA": "ja",
                        "KN": "kn",
                        "KO": "ko",
                        "LT": "lt",
                        "LV": "lv",
                        "MK": "mk",
                        "ML": "ml",
                        "MR": "mr",
                        "NE": "ne",
                        "NL": "nl",
                        "FALSE": "false",
                        "PA": "pa",
                        "PL": "pl",
                        "PT": "pt",
                        "RO": "ro",
                        "RU": "ru",
                        "SK": "sk",
                        "SL": "sl",
                        "SO": "so",
                        "SQ": "sq",
                        "SV": "sv",
                        "SW": "sw",
                        "TA": "ta",
                        "TE": "te",
                        "TH": "th",
                        "TL": "tl",
                        "TR": "tr",
                        "TW": "tw",
                        "UK": "uk",
                        "UR": "ur",
                        "VI": "vi"
                    },
                    ('not_lang',): {

                        "AF": "af",
                        "AR": "ar",
                        "BG": "bg",
                        "BN": "bn",
                        "CA": "ca",
                        "CN": "cn",
                        "CS": "cs",
                        "CY": "cy",
                        "DA": "da",
                        "DE": "de",
                        "EL": "el",
                        "EN": "en",
                        "ES": "es",
                        "ET": "et",
                        "FA": "fa",
                        "FI": "fi",
                        "FR": "fr",
                        "GU": "gu",
                        "HE": "he",
                        "HI": "hi",
                        "HR": "hr",
                        "HU": "hu",
                        "ID": "id",
                        "IT": "it",
                        "JA": "ja",
                        "KN": "kn",
                        "KO": "ko",
                        "LT": "lt",
                        "LV": "lv",
                        "MK": "mk",
                        "ML": "ml",
                        "MR": "mr",
                        "NE": "ne",
                        "NL": "nl",
                        "FALSE": "false",
                        "PA": "pa",
                        "PL": "pl",
                        "PT": "pt",
                        "RO": "ro",
                        "RU": "ru",
                        "SK": "sk",
                        "SL": "sl",
                        "SO": "so",
                        "SQ": "sq",
                        "SV": "sv",
                        "SW": "sw",
                        "TA": "ta",
                        "TE": "te",
                        "TH": "th",
                        "TL": "tl",
                        "TR": "tr",
                        "TW": "tw",
                        "UK": "uk",
                        "UR": "ur",
                        "VI": "vi"
                    },
                },
                'openapi_types': {
                    'lang':
                        (str,),
                    'not_lang':
                        (str,),
                    'countries':
                        (str,),
                    'not_countries':
                        (str,),
                    'topic':
                        (Topic,),
                    'sources':
                        (str,),
                    'not_sources':
                        (str,),
                    'ranked_only':
                        (bool,),
                    'page_size':
                        (PageSize,),
                    'page':
                        (Page,),
                },
                'attribute_map': {
                    'lang': 'lang',
                    'not_lang': 'not_lang',
                    'countries': 'countries',
                    'not_countries': 'not_countries',
                    'topic': 'topic',
                    'sources': 'sources',
                    'not_sources': 'not_sources',
                    'ranked_only': 'ranked_only',
                    'page_size': 'page_size',
                    'page': 'page',
                },
                'location_map': {
                    'lang': 'query',
                    'not_lang': 'query',
                    'countries': 'query',
                    'not_countries': 'query',
                    'topic': 'query',
                    'sources': 'query',
                    'not_sources': 'query',
                    'ranked_only': 'query',
                    'page_size': 'query',
                    'page': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [],
            },
            api_client=api_client
        )
        self.headlines_post_endpoint = _Endpoint(
            settings={
                'response_type': (Model200ResponseLatest,),
                'auth': [
                    'api_key'
                ],
                'endpoint_path': '/latest_headlines',
                'operation_id': 'headlines_post',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'latest_headlines',
                ],
                'required': [],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'latest_headlines':
                        (LatestHeadlines,),
                },
                'attribute_map': {
                },
                'location_map': {
                    'latest_headlines': 'body',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [
                    'application/json'
                ]
            },
            api_client=api_client
        )

    def headlines_get(
        self,
        **kwargs
    ):
        """Get Latest News Articles  # noqa: E501

        Get the latest headlines given any topic, country, or language.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.headlines_get(async_req=True)
        >>> result = thread.get()


        Keyword Args:
            lang (str): Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code. . [optional]
            not_lang (str): Inverse to the `lang` parameter . [optional]
            countries (str): Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US` . [optional]
            not_countries (str): The inverse of the `countries` parameter. . [optional]
            topic (Topic): Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label. . [optional]
            sources (str): One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com` . [optional]
            not_sources (str): One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com` . [optional]
            ranked_only (bool): Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999` . [optional]
            page_size (PageSize): `[1:100]` How many articles to return per page. . [optional]
            page (Page): The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles. . [optional]
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _spec_property_naming (bool): True if the variable names in the input data
                are serialized names, as specified in the OpenAPI document.
                False if the variable names in the input data
                are pythonic names, e.g. snake case (default)
            _content_type (str/None): force body content-type.
                Default is None and content-type will be predicted by allowed
                content-types and body.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            _request_auths (list): set to override the auth_settings for an a single
                request; this effectively ignores the authentication
                in the spec for a single request.
                Default is None
            async_req (bool): execute request asynchronously

        Returns:
            Model200ResponseLatest
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_spec_property_naming'] = kwargs.get(
            '_spec_property_naming', False
        )
        kwargs['_content_type'] = kwargs.get(
            '_content_type')
        kwargs['_host_index'] = kwargs.get('_host_index')
        kwargs['_request_auths'] = kwargs.get('_request_auths', None)
        return self.headlines_get_endpoint.call_with_http_info(**kwargs)

    def headlines_post(
        self,
        **kwargs
    ):
        """Get Latest News Articles  # noqa: E501

        Get the latest headlines given any topic, country, or language.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.headlines_post(async_req=True)
        >>> result = thread.get()


        Keyword Args:
            latest_headlines (LatestHeadlines): [optional]
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _spec_property_naming (bool): True if the variable names in the input data
                are serialized names, as specified in the OpenAPI document.
                False if the variable names in the input data
                are pythonic names, e.g. snake case (default)
            _content_type (str/None): force body content-type.
                Default is None and content-type will be predicted by allowed
                content-types and body.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            _request_auths (list): set to override the auth_settings for an a single
                request; this effectively ignores the authentication
                in the spec for a single request.
                Default is None
            async_req (bool): execute request asynchronously

        Returns:
            Model200ResponseLatest
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_spec_property_naming'] = kwargs.get(
            '_spec_property_naming', False
        )
        kwargs['_content_type'] = kwargs.get(
            '_content_type')
        kwargs['_host_index'] = kwargs.get('_host_index')
        kwargs['_request_auths'] = kwargs.get('_request_auths', None)
        return self.headlines_post_endpoint.call_with_http_info(**kwargs)
