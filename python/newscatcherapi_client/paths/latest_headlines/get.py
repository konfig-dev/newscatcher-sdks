# coding: utf-8

"""


    Generated by: https://konfigthis.com
"""

from dataclasses import dataclass
import typing_extensions
import urllib3
from urllib3._collections import HTTPHeaderDict

from newscatcherapi_client import api_client, exceptions
from datetime import date, datetime  # noqa: F401
import decimal  # noqa: F401
import functools  # noqa: F401
import io  # noqa: F401
import re  # noqa: F401
import typing  # noqa: F401
import typing_extensions  # noqa: F401
import uuid  # noqa: F401

import frozendict  # noqa: F401

from newscatcherapi_client import schemas  # noqa: F401

from newscatcherapi_client.model.model200_response_latest import Model200ResponseLatest
from newscatcherapi_client.model.page import Page
from newscatcherapi_client.model.error_response import ErrorResponse
from newscatcherapi_client.model.page_size import PageSize
from newscatcherapi_client.model.topic import Topic

from . import path

# Query params


class LangSchema(
    schemas.EnumBase,
    schemas.StrSchema
):


    class MetaOapg:
        enum_value_to_name = {
            "af": "AF",
            "ar": "AR",
            "bg": "BG",
            "bn": "BN",
            "ca": "CA",
            "cn": "CN",
            "cs": "CS",
            "cy": "CY",
            "da": "DA",
            "de": "DE",
            "el": "EL",
            "en": "EN",
            "es": "ES",
            "et": "ET",
            "fa": "FA",
            "fi": "FI",
            "fr": "FR",
            "gu": "GU",
            "he": "HE",
            "hi": "HI",
            "hr": "HR",
            "hu": "HU",
            "id": "ID",
            "it": "IT",
            "ja": "JA",
            "kn": "KN",
            "ko": "KO",
            "lt": "LT",
            "lv": "LV",
            "mk": "MK",
            "ml": "ML",
            "mr": "MR",
            "ne": "NE",
            "nl": "NL",
            "false": "FALSE",
            "pa": "PA",
            "pl": "PL",
            "pt": "PT",
            "ro": "RO",
            "ru": "RU",
            "sk": "SK",
            "sl": "SL",
            "so": "SO",
            "sq": "SQ",
            "sv": "SV",
            "sw": "SW",
            "ta": "TA",
            "te": "TE",
            "th": "TH",
            "tl": "TL",
            "tr": "TR",
            "tw": "TW",
            "uk": "UK",
            "ur": "UR",
            "vi": "VI",
        }
    
    @schemas.classproperty
    def AF(cls):
        return cls("af")
    
    @schemas.classproperty
    def AR(cls):
        return cls("ar")
    
    @schemas.classproperty
    def BG(cls):
        return cls("bg")
    
    @schemas.classproperty
    def BN(cls):
        return cls("bn")
    
    @schemas.classproperty
    def CA(cls):
        return cls("ca")
    
    @schemas.classproperty
    def CN(cls):
        return cls("cn")
    
    @schemas.classproperty
    def CS(cls):
        return cls("cs")
    
    @schemas.classproperty
    def CY(cls):
        return cls("cy")
    
    @schemas.classproperty
    def DA(cls):
        return cls("da")
    
    @schemas.classproperty
    def DE(cls):
        return cls("de")
    
    @schemas.classproperty
    def EL(cls):
        return cls("el")
    
    @schemas.classproperty
    def EN(cls):
        return cls("en")
    
    @schemas.classproperty
    def ES(cls):
        return cls("es")
    
    @schemas.classproperty
    def ET(cls):
        return cls("et")
    
    @schemas.classproperty
    def FA(cls):
        return cls("fa")
    
    @schemas.classproperty
    def FI(cls):
        return cls("fi")
    
    @schemas.classproperty
    def FR(cls):
        return cls("fr")
    
    @schemas.classproperty
    def GU(cls):
        return cls("gu")
    
    @schemas.classproperty
    def HE(cls):
        return cls("he")
    
    @schemas.classproperty
    def HI(cls):
        return cls("hi")
    
    @schemas.classproperty
    def HR(cls):
        return cls("hr")
    
    @schemas.classproperty
    def HU(cls):
        return cls("hu")
    
    @schemas.classproperty
    def ID(cls):
        return cls("id")
    
    @schemas.classproperty
    def IT(cls):
        return cls("it")
    
    @schemas.classproperty
    def JA(cls):
        return cls("ja")
    
    @schemas.classproperty
    def KN(cls):
        return cls("kn")
    
    @schemas.classproperty
    def KO(cls):
        return cls("ko")
    
    @schemas.classproperty
    def LT(cls):
        return cls("lt")
    
    @schemas.classproperty
    def LV(cls):
        return cls("lv")
    
    @schemas.classproperty
    def MK(cls):
        return cls("mk")
    
    @schemas.classproperty
    def ML(cls):
        return cls("ml")
    
    @schemas.classproperty
    def MR(cls):
        return cls("mr")
    
    @schemas.classproperty
    def NE(cls):
        return cls("ne")
    
    @schemas.classproperty
    def NL(cls):
        return cls("nl")
    
    @schemas.classproperty
    def FALSE(cls):
        return cls("false")
    
    @schemas.classproperty
    def PA(cls):
        return cls("pa")
    
    @schemas.classproperty
    def PL(cls):
        return cls("pl")
    
    @schemas.classproperty
    def PT(cls):
        return cls("pt")
    
    @schemas.classproperty
    def RO(cls):
        return cls("ro")
    
    @schemas.classproperty
    def RU(cls):
        return cls("ru")
    
    @schemas.classproperty
    def SK(cls):
        return cls("sk")
    
    @schemas.classproperty
    def SL(cls):
        return cls("sl")
    
    @schemas.classproperty
    def SO(cls):
        return cls("so")
    
    @schemas.classproperty
    def SQ(cls):
        return cls("sq")
    
    @schemas.classproperty
    def SV(cls):
        return cls("sv")
    
    @schemas.classproperty
    def SW(cls):
        return cls("sw")
    
    @schemas.classproperty
    def TA(cls):
        return cls("ta")
    
    @schemas.classproperty
    def TE(cls):
        return cls("te")
    
    @schemas.classproperty
    def TH(cls):
        return cls("th")
    
    @schemas.classproperty
    def TL(cls):
        return cls("tl")
    
    @schemas.classproperty
    def TR(cls):
        return cls("tr")
    
    @schemas.classproperty
    def TW(cls):
        return cls("tw")
    
    @schemas.classproperty
    def UK(cls):
        return cls("uk")
    
    @schemas.classproperty
    def UR(cls):
        return cls("ur")
    
    @schemas.classproperty
    def VI(cls):
        return cls("vi")


class NotLangSchema(
    schemas.EnumBase,
    schemas.StrSchema
):


    class MetaOapg:
        enum_value_to_name = {
            "af": "AF",
            "ar": "AR",
            "bg": "BG",
            "bn": "BN",
            "ca": "CA",
            "cn": "CN",
            "cs": "CS",
            "cy": "CY",
            "da": "DA",
            "de": "DE",
            "el": "EL",
            "en": "EN",
            "es": "ES",
            "et": "ET",
            "fa": "FA",
            "fi": "FI",
            "fr": "FR",
            "gu": "GU",
            "he": "HE",
            "hi": "HI",
            "hr": "HR",
            "hu": "HU",
            "id": "ID",
            "it": "IT",
            "ja": "JA",
            "kn": "KN",
            "ko": "KO",
            "lt": "LT",
            "lv": "LV",
            "mk": "MK",
            "ml": "ML",
            "mr": "MR",
            "ne": "NE",
            "nl": "NL",
            "false": "FALSE",
            "pa": "PA",
            "pl": "PL",
            "pt": "PT",
            "ro": "RO",
            "ru": "RU",
            "sk": "SK",
            "sl": "SL",
            "so": "SO",
            "sq": "SQ",
            "sv": "SV",
            "sw": "SW",
            "ta": "TA",
            "te": "TE",
            "th": "TH",
            "tl": "TL",
            "tr": "TR",
            "tw": "TW",
            "uk": "UK",
            "ur": "UR",
            "vi": "VI",
        }
    
    @schemas.classproperty
    def AF(cls):
        return cls("af")
    
    @schemas.classproperty
    def AR(cls):
        return cls("ar")
    
    @schemas.classproperty
    def BG(cls):
        return cls("bg")
    
    @schemas.classproperty
    def BN(cls):
        return cls("bn")
    
    @schemas.classproperty
    def CA(cls):
        return cls("ca")
    
    @schemas.classproperty
    def CN(cls):
        return cls("cn")
    
    @schemas.classproperty
    def CS(cls):
        return cls("cs")
    
    @schemas.classproperty
    def CY(cls):
        return cls("cy")
    
    @schemas.classproperty
    def DA(cls):
        return cls("da")
    
    @schemas.classproperty
    def DE(cls):
        return cls("de")
    
    @schemas.classproperty
    def EL(cls):
        return cls("el")
    
    @schemas.classproperty
    def EN(cls):
        return cls("en")
    
    @schemas.classproperty
    def ES(cls):
        return cls("es")
    
    @schemas.classproperty
    def ET(cls):
        return cls("et")
    
    @schemas.classproperty
    def FA(cls):
        return cls("fa")
    
    @schemas.classproperty
    def FI(cls):
        return cls("fi")
    
    @schemas.classproperty
    def FR(cls):
        return cls("fr")
    
    @schemas.classproperty
    def GU(cls):
        return cls("gu")
    
    @schemas.classproperty
    def HE(cls):
        return cls("he")
    
    @schemas.classproperty
    def HI(cls):
        return cls("hi")
    
    @schemas.classproperty
    def HR(cls):
        return cls("hr")
    
    @schemas.classproperty
    def HU(cls):
        return cls("hu")
    
    @schemas.classproperty
    def ID(cls):
        return cls("id")
    
    @schemas.classproperty
    def IT(cls):
        return cls("it")
    
    @schemas.classproperty
    def JA(cls):
        return cls("ja")
    
    @schemas.classproperty
    def KN(cls):
        return cls("kn")
    
    @schemas.classproperty
    def KO(cls):
        return cls("ko")
    
    @schemas.classproperty
    def LT(cls):
        return cls("lt")
    
    @schemas.classproperty
    def LV(cls):
        return cls("lv")
    
    @schemas.classproperty
    def MK(cls):
        return cls("mk")
    
    @schemas.classproperty
    def ML(cls):
        return cls("ml")
    
    @schemas.classproperty
    def MR(cls):
        return cls("mr")
    
    @schemas.classproperty
    def NE(cls):
        return cls("ne")
    
    @schemas.classproperty
    def NL(cls):
        return cls("nl")
    
    @schemas.classproperty
    def FALSE(cls):
        return cls("false")
    
    @schemas.classproperty
    def PA(cls):
        return cls("pa")
    
    @schemas.classproperty
    def PL(cls):
        return cls("pl")
    
    @schemas.classproperty
    def PT(cls):
        return cls("pt")
    
    @schemas.classproperty
    def RO(cls):
        return cls("ro")
    
    @schemas.classproperty
    def RU(cls):
        return cls("ru")
    
    @schemas.classproperty
    def SK(cls):
        return cls("sk")
    
    @schemas.classproperty
    def SL(cls):
        return cls("sl")
    
    @schemas.classproperty
    def SO(cls):
        return cls("so")
    
    @schemas.classproperty
    def SQ(cls):
        return cls("sq")
    
    @schemas.classproperty
    def SV(cls):
        return cls("sv")
    
    @schemas.classproperty
    def SW(cls):
        return cls("sw")
    
    @schemas.classproperty
    def TA(cls):
        return cls("ta")
    
    @schemas.classproperty
    def TE(cls):
        return cls("te")
    
    @schemas.classproperty
    def TH(cls):
        return cls("th")
    
    @schemas.classproperty
    def TL(cls):
        return cls("tl")
    
    @schemas.classproperty
    def TR(cls):
        return cls("tr")
    
    @schemas.classproperty
    def TW(cls):
        return cls("tw")
    
    @schemas.classproperty
    def UK(cls):
        return cls("uk")
    
    @schemas.classproperty
    def UR(cls):
        return cls("ur")
    
    @schemas.classproperty
    def VI(cls):
        return cls("vi")
CountriesSchema = schemas.StrSchema
NotCountriesSchema = schemas.StrSchema
TopicSchema = Topic
SourcesSchema = schemas.StrSchema
NotSourcesSchema = schemas.StrSchema
RankedOnlySchema = schemas.BoolSchema
PageSizeSchema = PageSize
PageSchema = Page
RequestRequiredQueryParams = typing_extensions.TypedDict(
    'RequestRequiredQueryParams',
    {
    }
)
RequestOptionalQueryParams = typing_extensions.TypedDict(
    'RequestOptionalQueryParams',
    {
        'lang': typing.Union[LangSchema, str, ],
        'not_lang': typing.Union[NotLangSchema, str, ],
        'countries': typing.Union[CountriesSchema, str, ],
        'not_countries': typing.Union[NotCountriesSchema, str, ],
        'topic': typing.Union[TopicSchema, ],
        'sources': typing.Union[SourcesSchema, str, ],
        'not_sources': typing.Union[NotSourcesSchema, str, ],
        'ranked_only': typing.Union[RankedOnlySchema, bool, ],
        'page_size': typing.Union[PageSizeSchema, ],
        'page': typing.Union[PageSchema, ],
    },
    total=False
)


class RequestQueryParams(RequestRequiredQueryParams, RequestOptionalQueryParams):
    pass


request_query_lang = api_client.QueryParameter(
    name="lang",
    style=api_client.ParameterStyle.FORM,
    schema=LangSchema,
    explode=True,
)
request_query_not_lang = api_client.QueryParameter(
    name="not_lang",
    style=api_client.ParameterStyle.FORM,
    schema=NotLangSchema,
    explode=True,
)
request_query_countries = api_client.QueryParameter(
    name="countries",
    style=api_client.ParameterStyle.FORM,
    schema=CountriesSchema,
    explode=True,
)
request_query_not_countries = api_client.QueryParameter(
    name="not_countries",
    style=api_client.ParameterStyle.FORM,
    schema=NotCountriesSchema,
    explode=True,
)
request_query_topic = api_client.QueryParameter(
    name="topic",
    style=api_client.ParameterStyle.FORM,
    schema=TopicSchema,
    explode=True,
)
request_query_sources = api_client.QueryParameter(
    name="sources",
    style=api_client.ParameterStyle.FORM,
    schema=SourcesSchema,
    explode=True,
)
request_query_not_sources = api_client.QueryParameter(
    name="not_sources",
    style=api_client.ParameterStyle.FORM,
    schema=NotSourcesSchema,
    explode=True,
)
request_query_ranked_only = api_client.QueryParameter(
    name="ranked_only",
    style=api_client.ParameterStyle.FORM,
    schema=RankedOnlySchema,
    explode=True,
)
request_query_page_size = api_client.QueryParameter(
    name="page_size",
    style=api_client.ParameterStyle.FORM,
    schema=PageSizeSchema,
    explode=True,
)
request_query_page = api_client.QueryParameter(
    name="page",
    style=api_client.ParameterStyle.FORM,
    schema=PageSchema,
    explode=True,
)
_auth = [
    'api_key',
]
SchemaFor200ResponseBodyApplicationJson = Model200ResponseLatest


@dataclass
class ApiResponseFor200(api_client.ApiResponse):
    response: urllib3.HTTPResponse
    body: typing.Union[
        SchemaFor200ResponseBodyApplicationJson,
    ]
    headers: schemas.Unset = schemas.unset


_response_for_200 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor200,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor200ResponseBodyApplicationJson),
    },
)
SchemaFor400ResponseBodyApplicationJson = ErrorResponse


@dataclass
class ApiResponseFor400(api_client.ApiResponse):
    response: urllib3.HTTPResponse
    body: typing.Union[
        SchemaFor400ResponseBodyApplicationJson,
    ]
    headers: schemas.Unset = schemas.unset


_response_for_400 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor400,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor400ResponseBodyApplicationJson),
    },
)
SchemaFor401ResponseBodyApplicationJson = ErrorResponse


@dataclass
class ApiResponseFor401(api_client.ApiResponse):
    response: urllib3.HTTPResponse
    body: typing.Union[
        SchemaFor401ResponseBodyApplicationJson,
    ]
    headers: schemas.Unset = schemas.unset


_response_for_401 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor401,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor401ResponseBodyApplicationJson),
    },
)
SchemaFor406ResponseBodyApplicationJson = ErrorResponse


@dataclass
class ApiResponseFor406(api_client.ApiResponse):
    response: urllib3.HTTPResponse
    body: typing.Union[
        SchemaFor406ResponseBodyApplicationJson,
    ]
    headers: schemas.Unset = schemas.unset


_response_for_406 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor406,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor406ResponseBodyApplicationJson),
    },
)
SchemaFor408ResponseBodyApplicationJson = ErrorResponse


@dataclass
class ApiResponseFor408(api_client.ApiResponse):
    response: urllib3.HTTPResponse
    body: typing.Union[
        SchemaFor408ResponseBodyApplicationJson,
    ]
    headers: schemas.Unset = schemas.unset


_response_for_408 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor408,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor408ResponseBodyApplicationJson),
    },
)
SchemaFor429ResponseBodyApplicationJson = ErrorResponse


@dataclass
class ApiResponseFor429(api_client.ApiResponse):
    response: urllib3.HTTPResponse
    body: typing.Union[
        SchemaFor429ResponseBodyApplicationJson,
    ]
    headers: schemas.Unset = schemas.unset


_response_for_429 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor429,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor429ResponseBodyApplicationJson),
    },
)
_status_code_to_response = {
    '200': _response_for_200,
    '400': _response_for_400,
    '401': _response_for_401,
    '406': _response_for_406,
    '408': _response_for_408,
    '429': _response_for_429,
}
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):
    @typing.overload
    def _get_oapg(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: typing_extensions.Literal[False] = ...,
    ) -> typing.Union[
        ApiResponseFor200,
    ]: ...

    @typing.overload
    def _get_oapg(
        self,
        skip_deserialization: typing_extensions.Literal[True],
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
    ) -> api_client.ApiResponseWithoutDeserialization: ...

    @typing.overload
    def _get_oapg(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: bool = ...,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]: ...

    def _get_oapg(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: bool = False,
    ):
        """
        Get Latest News Articles
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestQueryParams, query_params)
        used_path = path.value

        prefix_separator_iterator = None
        for parameter in (
            request_query_lang,
            request_query_not_lang,
            request_query_countries,
            request_query_not_countries,
            request_query_topic,
            request_query_sources,
            request_query_not_sources,
            request_query_ranked_only,
            request_query_page_size,
            request_query_page,
        ):
            parameter_data = query_params.get(parameter.name, schemas.unset)
            if parameter_data is schemas.unset:
                continue
            if prefix_separator_iterator is None:
                prefix_separator_iterator = parameter.get_prefix_separator_iterator()
            serialized_data = parameter.serialize(parameter_data, prefix_separator_iterator)
            for serialized_value in serialized_data.values():
                used_path += serialized_value

        _headers = HTTPHeaderDict()
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)

        response = self.api_client.call_api(
            resource_path=used_path,
            method='get'.upper(),
            headers=_headers,
            auth_settings=_auth,
            stream=stream,
            timeout=timeout,
        )

        if skip_deserialization:
            api_response = api_client.ApiResponseWithoutDeserialization(response=response)
        else:
            response_for_status = _status_code_to_response.get(str(response.status))
            if response_for_status:
                api_response = response_for_status.deserialize(response, self.api_client.configuration)
            else:
                api_response = api_client.ApiResponseWithoutDeserialization(response=response)

        if not 200 <= response.status <= 299:
            raise exceptions.ApiException(api_response=api_response)

        return api_response


class Get(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    @typing.overload
    def get(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: typing_extensions.Literal[False] = ...,
    ) -> typing.Union[
        ApiResponseFor200,
    ]: ...

    @typing.overload
    def get(
        self,
        skip_deserialization: typing_extensions.Literal[True],
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
    ) -> api_client.ApiResponseWithoutDeserialization: ...

    @typing.overload
    def get(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: bool = ...,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]: ...

    def get(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: bool = False,
    ):
        return self._get_oapg(
            query_params=query_params,
            accept_content_types=accept_content_types,
            stream=stream,
            timeout=timeout,
            skip_deserialization=skip_deserialization
        )


class ApiForget(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    @typing.overload
    def get(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: typing_extensions.Literal[False] = ...,
    ) -> typing.Union[
        ApiResponseFor200,
    ]: ...

    @typing.overload
    def get(
        self,
        skip_deserialization: typing_extensions.Literal[True],
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
    ) -> api_client.ApiResponseWithoutDeserialization: ...

    @typing.overload
    def get(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: bool = ...,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]: ...

    def get(
        self,
        query_params: RequestQueryParams = frozendict.frozendict(),
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        skip_deserialization: bool = False,
    ):
        return self._get_oapg(
            query_params=query_params,
            accept_content_types=accept_content_types,
            stream=stream,
            timeout=timeout,
            skip_deserialization=skip_deserialization
        )


