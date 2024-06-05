# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: 3.2.16
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from datetime import datetime, date
import typing
from enum import Enum
from typing_extensions import TypedDict, Literal, TYPE_CHECKING
from pydantic import BaseModel, Field, RootModel, ConfigDict


class AuthorSearchRequest(BaseModel):
    author_name: str = Field(alias='author_name')

    not_author_name: typing.Optional[str] = Field(None, alias='not_author_name')

    sources: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='sources')

    predefined_sources: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='predefined_sources')

    not_sources: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_sources')

    lang: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='lang')

    not_lang: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_lang')

    countries: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='countries')

    not_countries: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_countries')

    from_: typing.Optional[typing.Union[str, datetime]] = Field(None, alias='from_')

    to_: typing.Optional[typing.Union[str, datetime]] = Field(None, alias='to_')

    published_date_precision: typing.Optional[str] = Field(None, alias='published_date_precision')

    by_parse_date: typing.Optional[bool] = Field(None, alias='by_parse_date')

    sort_by: typing.Optional[str] = Field(None, alias='sort_by')

    ranked_only: typing.Optional[str] = Field(None, alias='ranked_only')

    from_rank: typing.Optional[int] = Field(None, alias='from_rank')

    to_rank: typing.Optional[int] = Field(None, alias='to_rank')

    is_headline: typing.Optional[bool] = Field(None, alias='is_headline')

    is_opinion: typing.Optional[bool] = Field(None, alias='is_opinion')

    is_paid_content: typing.Optional[bool] = Field(None, alias='is_paid_content')

    parent_url: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='parent_url')

    all_links: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='all_links')

    all_domain_links: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='all_domain_links')

    word_count_min: typing.Optional[int] = Field(None, alias='word_count_min')

    word_count_max: typing.Optional[int] = Field(None, alias='word_count_max')

    page: typing.Optional[int] = Field(None, alias='page')

    page_size: typing.Optional[int] = Field(None, alias='page_size')

    include_nlp_data: typing.Optional[bool] = Field(None, alias='include_nlp_data')

    has_nlp: typing.Optional[bool] = Field(None, alias='has_nlp')

    theme: typing.Optional[str] = Field(None, alias='theme')

    not_theme: typing.Optional[str] = Field(None, alias='not_theme')

    ner_name: typing.Optional[str] = Field(None, alias='ner_name')

    title_sentiment_min: typing.Optional[typing.Union[int, float]] = Field(None, alias='title_sentiment_min')

    title_sentiment_max: typing.Optional[typing.Union[int, float]] = Field(None, alias='title_sentiment_max')

    content_sentiment_min: typing.Optional[typing.Union[int, float]] = Field(None, alias='content_sentiment_min')

    content_sentiment_max: typing.Optional[typing.Union[int, float]] = Field(None, alias='content_sentiment_max')

    iptc_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='iptc_tags')

    not_iptc_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_iptc_tags')

    iab_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='iab_tags')

    not_iab_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_iab_tags')

    model_config = ConfigDict(
        protected_namespaces=(),
        arbitrary_types_allowed=True
    )
