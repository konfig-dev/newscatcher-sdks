# coding: utf-8

"""
    NewsCatcher News API V2

    NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python)   # noqa: E501

    The version of the OpenAPI document: 1.0.1
    Contact: team@newscatcherapi.com
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


class SearchUserInput(
    schemas.DictSchema
):
    """NOTE: This class is auto generated by Konfig.
    Ref: https://konfigthis.com

    Do not edit the class manually.
    """


    class MetaOapg:
        
        class properties:
            q = schemas.StrSchema
        
            @staticmethod
            def search_in() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def lang() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def not_lang() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def countries() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def not_countries() -> typing.Type['ModelList']:
                return ModelList
            _from = schemas.StrSchema
            
            
            class to(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'to':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            ranked_only = schemas.StrSchema
            
            
            class from_rank(
                schemas.IntBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneDecimalMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, decimal.Decimal, int, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'from_rank':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            
            
            class to_rank(
                schemas.IntBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneDecimalMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, decimal.Decimal, int, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'to_rank':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            sort_by = schemas.StrSchema
            page = schemas.IntSchema
            size = schemas.IntSchema
        
            @staticmethod
            def sources() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def not_sources() -> typing.Type['ModelList']:
                return ModelList
            
            
            class topic(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'topic':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            
            
            class published_date_precision(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'published_date_precision':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            __annotations__ = {
                "q": q,
                "search_in": search_in,
                "lang": lang,
                "not_lang": not_lang,
                "countries": countries,
                "not_countries": not_countries,
                "from": _from,
                "to": to,
                "ranked_only": ranked_only,
                "from_rank": from_rank,
                "to_rank": to_rank,
                "sort_by": sort_by,
                "page": page,
                "size": size,
                "sources": sources,
                "not_sources": not_sources,
                "topic": topic,
                "published_date_precision": published_date_precision,
            }
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["q"]) -> MetaOapg.properties.q: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["search_in"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["lang"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_lang"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["countries"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_countries"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["from"]) -> MetaOapg.properties._from: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["to"]) -> MetaOapg.properties.to: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["ranked_only"]) -> MetaOapg.properties.ranked_only: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["from_rank"]) -> MetaOapg.properties.from_rank: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["to_rank"]) -> MetaOapg.properties.to_rank: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["sort_by"]) -> MetaOapg.properties.sort_by: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["page"]) -> MetaOapg.properties.page: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["size"]) -> MetaOapg.properties.size: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["sources"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_sources"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["topic"]) -> MetaOapg.properties.topic: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["published_date_precision"]) -> MetaOapg.properties.published_date_precision: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["q", "search_in", "lang", "not_lang", "countries", "not_countries", "from", "to", "ranked_only", "from_rank", "to_rank", "sort_by", "page", "size", "sources", "not_sources", "topic", "published_date_precision", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["q"]) -> typing.Union[MetaOapg.properties.q, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["search_in"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["lang"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_lang"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["countries"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_countries"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["from"]) -> typing.Union[MetaOapg.properties._from, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["to"]) -> typing.Union[MetaOapg.properties.to, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["ranked_only"]) -> typing.Union[MetaOapg.properties.ranked_only, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["from_rank"]) -> typing.Union[MetaOapg.properties.from_rank, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["to_rank"]) -> typing.Union[MetaOapg.properties.to_rank, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["sort_by"]) -> typing.Union[MetaOapg.properties.sort_by, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["page"]) -> typing.Union[MetaOapg.properties.page, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["size"]) -> typing.Union[MetaOapg.properties.size, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["sources"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_sources"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["topic"]) -> typing.Union[MetaOapg.properties.topic, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["published_date_precision"]) -> typing.Union[MetaOapg.properties.published_date_precision, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["q", "search_in", "lang", "not_lang", "countries", "not_countries", "from", "to", "ranked_only", "from_rank", "to_rank", "sort_by", "page", "size", "sources", "not_sources", "topic", "published_date_precision", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        q: typing.Union[MetaOapg.properties.q, str, schemas.Unset] = schemas.unset,
        search_in: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        lang: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        not_lang: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        countries: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        not_countries: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        to: typing.Union[MetaOapg.properties.to, None, str, schemas.Unset] = schemas.unset,
        ranked_only: typing.Union[MetaOapg.properties.ranked_only, str, schemas.Unset] = schemas.unset,
        from_rank: typing.Union[MetaOapg.properties.from_rank, None, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        to_rank: typing.Union[MetaOapg.properties.to_rank, None, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        sort_by: typing.Union[MetaOapg.properties.sort_by, str, schemas.Unset] = schemas.unset,
        page: typing.Union[MetaOapg.properties.page, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        size: typing.Union[MetaOapg.properties.size, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        sources: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        not_sources: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        topic: typing.Union[MetaOapg.properties.topic, None, str, schemas.Unset] = schemas.unset,
        published_date_precision: typing.Union[MetaOapg.properties.published_date_precision, None, str, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'SearchUserInput':
        return super().__new__(
            cls,
            *args,
            q=q,
            search_in=search_in,
            lang=lang,
            not_lang=not_lang,
            countries=countries,
            not_countries=not_countries,
            to=to,
            ranked_only=ranked_only,
            from_rank=from_rank,
            to_rank=to_rank,
            sort_by=sort_by,
            page=page,
            size=size,
            sources=sources,
            not_sources=not_sources,
            topic=topic,
            published_date_precision=published_date_precision,
            _configuration=_configuration,
            **kwargs,
        )

from newscatcherapi_client.model.model_list import ModelList