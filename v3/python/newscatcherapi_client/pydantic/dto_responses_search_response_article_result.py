# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: Beta-3.0.0
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from datetime import datetime, date
import typing
from enum import Enum
from typing_extensions import TypedDict, Literal, TYPE_CHECKING
from pydantic import BaseModel, Field, RootModel


class DtoResponsesSearchResponseArticleResult(BaseModel):
    title: str = Field(alias='title')

    link: str = Field(alias='link')

    domain_url: str = Field(alias='domain_url')

    full_domain_url: str = Field(alias='full_domain_url')

    extraction_data: str = Field(alias='extraction_data')

    rank: int = Field(alias='rank')

    id: str = Field(alias='id')

    score: typing.Union[int, float] = Field(alias='score')

    description: typing.Optional[str] = Field(None, alias='description')

    author: typing.Optional[str] = Field(None, alias='author')

    authors: typing.Optional[typing.Union[typing.List[str], str]] = Field(None, alias='authors')

    journalists: typing.Optional[typing.Union[typing.List[str], str]] = Field(None, alias='journalists')

    published_date: typing.Optional[str] = Field(None, alias='published_date')

    published_date_precision: typing.Optional[str] = Field(None, alias='published_date_precision')

    updated_date: typing.Optional[str] = Field(None, alias='updated_date')

    updated_date_precision: typing.Optional[str] = Field(None, alias='updated_date_precision')

    parse_date: typing.Optional[str] = Field(None, alias='parse_date')

    name_source: typing.Optional[str] = Field(None, alias='name_source')

    is_headline: typing.Optional[str] = Field(None, alias='is_headline')

    paid_content: typing.Optional[bool] = Field(None, alias='paid_content')

    country: typing.Optional[str] = Field(None, alias='country')

    rights: typing.Optional[str] = Field(None, alias='rights')

    media: typing.Optional[str] = Field(None, alias='media')

    language: typing.Optional[str] = Field(None, alias='language')

    content: typing.Optional[str] = Field(None, alias='content')

    word_count: typing.Optional[int] = Field(None, alias='word_count')

    is_opinion: typing.Optional[bool] = Field(None, alias='is_opinion')

    twitter_account: typing.Optional[str] = Field(None, alias='twitter_account')

    all_links: typing.Optional[typing.Union[typing.List[str], str]] = Field(None, alias='all_links')

    all_domain_links: typing.Optional[typing.Union[typing.List[str], str]] = Field(None, alias='all_domain_links')

    nlp: typing.Optional[typing.Dict[str, typing.Union[bool, date, datetime, dict, float, int, list, str, None]]] = Field(None, alias='nlp')
