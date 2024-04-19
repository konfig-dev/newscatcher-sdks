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


class Cluster(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)

    Cluster DTO class.
    """


    class MetaOapg:
        required = {
            "cluster_id",
            "cluster_size",
            "articles",
        }
        
        class properties:
            cluster_id = schemas.StrSchema
            cluster_size = schemas.IntSchema
        
            @staticmethod
            def articles() -> typing.Type['ClusterArticles']:
                return ClusterArticles
            __annotations__ = {
                "cluster_id": cluster_id,
                "cluster_size": cluster_size,
                "articles": articles,
            }
    
    cluster_id: MetaOapg.properties.cluster_id
    cluster_size: MetaOapg.properties.cluster_size
    articles: 'ClusterArticles'
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["cluster_id"]) -> MetaOapg.properties.cluster_id: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["cluster_size"]) -> MetaOapg.properties.cluster_size: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["articles"]) -> 'ClusterArticles': ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["cluster_id", "cluster_size", "articles", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["cluster_id"]) -> MetaOapg.properties.cluster_id: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["cluster_size"]) -> MetaOapg.properties.cluster_size: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["articles"]) -> 'ClusterArticles': ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["cluster_id", "cluster_size", "articles", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        cluster_id: typing.Union[MetaOapg.properties.cluster_id, str, ],
        cluster_size: typing.Union[MetaOapg.properties.cluster_size, decimal.Decimal, int, ],
        articles: 'ClusterArticles',
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'Cluster':
        return super().__new__(
            cls,
            *args,
            cluster_id=cluster_id,
            cluster_size=cluster_size,
            articles=articles,
            _configuration=_configuration,
            **kwargs,
        )

from newscatcherapi_client.model.cluster_articles import ClusterArticles
