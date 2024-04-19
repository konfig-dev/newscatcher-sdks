# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: 3.2.16
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

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


class DtoResponsesMoreLikeThisResponseSearchResponse(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)

    SearchResponse DTO class.
    """


    class MetaOapg:
        required = {
            "total_hits",
            "user_input",
            "page",
            "total_pages",
            "articles",
            "page_size",
        }
        
        class properties:
            total_hits = schemas.IntSchema
            page = schemas.IntSchema
            total_pages = schemas.IntSchema
            page_size = schemas.IntSchema
        
            @staticmethod
            def articles() -> typing.Type['DtoResponsesMoreLikeThisResponseSearchResponseArticles']:
                return DtoResponsesMoreLikeThisResponseSearchResponseArticles
            user_input = schemas.DictSchema
            status = schemas.StrSchema
            __annotations__ = {
                "total_hits": total_hits,
                "page": page,
                "total_pages": total_pages,
                "page_size": page_size,
                "articles": articles,
                "user_input": user_input,
                "status": status,
            }
    
    total_hits: MetaOapg.properties.total_hits
    user_input: MetaOapg.properties.user_input
    page: MetaOapg.properties.page
    total_pages: MetaOapg.properties.total_pages
    articles: 'DtoResponsesMoreLikeThisResponseSearchResponseArticles'
    page_size: MetaOapg.properties.page_size
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["total_hits"]) -> MetaOapg.properties.total_hits: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["page"]) -> MetaOapg.properties.page: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["total_pages"]) -> MetaOapg.properties.total_pages: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["page_size"]) -> MetaOapg.properties.page_size: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["articles"]) -> 'DtoResponsesMoreLikeThisResponseSearchResponseArticles': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["user_input"]) -> MetaOapg.properties.user_input: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["status"]) -> MetaOapg.properties.status: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["total_hits", "page", "total_pages", "page_size", "articles", "user_input", "status", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["total_hits"]) -> MetaOapg.properties.total_hits: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["page"]) -> MetaOapg.properties.page: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["total_pages"]) -> MetaOapg.properties.total_pages: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["page_size"]) -> MetaOapg.properties.page_size: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["articles"]) -> 'DtoResponsesMoreLikeThisResponseSearchResponseArticles': ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["user_input"]) -> MetaOapg.properties.user_input: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["status"]) -> typing.Union[MetaOapg.properties.status, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["total_hits", "page", "total_pages", "page_size", "articles", "user_input", "status", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        total_hits: typing.Union[MetaOapg.properties.total_hits, decimal.Decimal, int, ],
        user_input: typing.Union[MetaOapg.properties.user_input, dict, frozendict.frozendict, ],
        page: typing.Union[MetaOapg.properties.page, decimal.Decimal, int, ],
        total_pages: typing.Union[MetaOapg.properties.total_pages, decimal.Decimal, int, ],
        articles: 'DtoResponsesMoreLikeThisResponseSearchResponseArticles',
        page_size: typing.Union[MetaOapg.properties.page_size, decimal.Decimal, int, ],
        status: typing.Union[MetaOapg.properties.status, str, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'DtoResponsesMoreLikeThisResponseSearchResponse':
        return super().__new__(
            cls,
            *args,
            total_hits=total_hits,
            user_input=user_input,
            page=page,
            total_pages=total_pages,
            articles=articles,
            page_size=page_size,
            status=status,
            _configuration=_configuration,
            **kwargs,
        )

from newscatcherapi_client.model.dto_responses_more_like_this_response_search_response_articles import DtoResponsesMoreLikeThisResponseSearchResponseArticles
