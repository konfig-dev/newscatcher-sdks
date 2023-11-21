# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: Beta-3.0.0
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


class DtoResponsesLatestHeadlinesResponseArticleResult(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        required = {
            "score",
            "extraction_data",
            "domain_url",
            "full_domain_url",
            "link",
            "rank",
            "id",
            "title",
        }
        
        class properties:
            title = schemas.StrSchema
            link = schemas.StrSchema
            domain_url = schemas.StrSchema
            full_domain_url = schemas.StrSchema
            extraction_data = schemas.StrSchema
            rank = schemas.IntSchema
            id = schemas.StrSchema
            score = schemas.NumberSchema
            description = schemas.StrSchema
            author = schemas.StrSchema
            
            
            class authors(
                schemas.ComposedSchema,
            ):
            
            
                class MetaOapg:
                    
                    
                    class any_of_0(
                        schemas.ListSchema
                    ):
                    
                    
                        class MetaOapg:
                            items = schemas.StrSchema
                    
                        def __new__(
                            cls,
                            arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, str, ]], typing.List[typing.Union[MetaOapg.items, str, ]]],
                            _configuration: typing.Optional[schemas.Configuration] = None,
                        ) -> 'any_of_0':
                            return super().__new__(
                                cls,
                                arg,
                                _configuration=_configuration,
                            )
                    
                        def __getitem__(self, i: int) -> MetaOapg.items:
                            return super().__getitem__(i)
                    any_of_1 = schemas.StrSchema
                    
                    @classmethod
                    @functools.lru_cache()
                    def any_of(cls):
                        # we need this here to make our import statements work
                        # we must store _composed_schemas in here so the code is only run
                        # when we invoke this method. If we kept this at the class
                        # level we would get an error because the class level
                        # code would be run when this module is imported, and these composed
                        # classes don't exist yet because their module has not finished
                        # loading
                        return [
                            cls.any_of_0,
                            cls.any_of_1,
                        ]
            
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'authors':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                        **kwargs,
                    )
            
            
            class journalists(
                schemas.ComposedSchema,
            ):
            
            
                class MetaOapg:
                    
                    
                    class any_of_0(
                        schemas.ListSchema
                    ):
                    
                    
                        class MetaOapg:
                            items = schemas.StrSchema
                    
                        def __new__(
                            cls,
                            arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, str, ]], typing.List[typing.Union[MetaOapg.items, str, ]]],
                            _configuration: typing.Optional[schemas.Configuration] = None,
                        ) -> 'any_of_0':
                            return super().__new__(
                                cls,
                                arg,
                                _configuration=_configuration,
                            )
                    
                        def __getitem__(self, i: int) -> MetaOapg.items:
                            return super().__getitem__(i)
                    any_of_1 = schemas.StrSchema
                    
                    @classmethod
                    @functools.lru_cache()
                    def any_of(cls):
                        # we need this here to make our import statements work
                        # we must store _composed_schemas in here so the code is only run
                        # when we invoke this method. If we kept this at the class
                        # level we would get an error because the class level
                        # code would be run when this module is imported, and these composed
                        # classes don't exist yet because their module has not finished
                        # loading
                        return [
                            cls.any_of_0,
                            cls.any_of_1,
                        ]
            
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'journalists':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                        **kwargs,
                    )
            published_date = schemas.StrSchema
            published_date_precision = schemas.StrSchema
            updated_date = schemas.StrSchema
            updated_date_precision = schemas.StrSchema
            parse_date = schemas.StrSchema
            name_source = schemas.StrSchema
            is_headline = schemas.StrSchema
            paid_content = schemas.BoolSchema
            country = schemas.StrSchema
            rights = schemas.StrSchema
            media = schemas.StrSchema
            language = schemas.StrSchema
            content = schemas.StrSchema
            word_count = schemas.IntSchema
            is_opinion = schemas.BoolSchema
            twitter_account = schemas.StrSchema
            
            
            class all_links(
                schemas.ComposedSchema,
            ):
            
            
                class MetaOapg:
                    
                    
                    class any_of_0(
                        schemas.ListSchema
                    ):
                    
                    
                        class MetaOapg:
                            items = schemas.StrSchema
                    
                        def __new__(
                            cls,
                            arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, str, ]], typing.List[typing.Union[MetaOapg.items, str, ]]],
                            _configuration: typing.Optional[schemas.Configuration] = None,
                        ) -> 'any_of_0':
                            return super().__new__(
                                cls,
                                arg,
                                _configuration=_configuration,
                            )
                    
                        def __getitem__(self, i: int) -> MetaOapg.items:
                            return super().__getitem__(i)
                    any_of_1 = schemas.StrSchema
                    
                    @classmethod
                    @functools.lru_cache()
                    def any_of(cls):
                        # we need this here to make our import statements work
                        # we must store _composed_schemas in here so the code is only run
                        # when we invoke this method. If we kept this at the class
                        # level we would get an error because the class level
                        # code would be run when this module is imported, and these composed
                        # classes don't exist yet because their module has not finished
                        # loading
                        return [
                            cls.any_of_0,
                            cls.any_of_1,
                        ]
            
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'all_links':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                        **kwargs,
                    )
            
            
            class all_domain_links(
                schemas.ComposedSchema,
            ):
            
            
                class MetaOapg:
                    
                    
                    class any_of_0(
                        schemas.ListSchema
                    ):
                    
                    
                        class MetaOapg:
                            items = schemas.StrSchema
                    
                        def __new__(
                            cls,
                            arg: typing.Union[typing.Tuple[typing.Union[MetaOapg.items, str, ]], typing.List[typing.Union[MetaOapg.items, str, ]]],
                            _configuration: typing.Optional[schemas.Configuration] = None,
                        ) -> 'any_of_0':
                            return super().__new__(
                                cls,
                                arg,
                                _configuration=_configuration,
                            )
                    
                        def __getitem__(self, i: int) -> MetaOapg.items:
                            return super().__getitem__(i)
                    any_of_1 = schemas.StrSchema
                    
                    @classmethod
                    @functools.lru_cache()
                    def any_of(cls):
                        # we need this here to make our import statements work
                        # we must store _composed_schemas in here so the code is only run
                        # when we invoke this method. If we kept this at the class
                        # level we would get an error because the class level
                        # code would be run when this module is imported, and these composed
                        # classes don't exist yet because their module has not finished
                        # loading
                        return [
                            cls.any_of_0,
                            cls.any_of_1,
                        ]
            
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'all_domain_links':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                        **kwargs,
                    )
            nlp = schemas.DictSchema
            __annotations__ = {
                "title": title,
                "link": link,
                "domain_url": domain_url,
                "full_domain_url": full_domain_url,
                "extraction_data": extraction_data,
                "rank": rank,
                "id": id,
                "score": score,
                "description": description,
                "author": author,
                "authors": authors,
                "journalists": journalists,
                "published_date": published_date,
                "published_date_precision": published_date_precision,
                "updated_date": updated_date,
                "updated_date_precision": updated_date_precision,
                "parse_date": parse_date,
                "name_source": name_source,
                "is_headline": is_headline,
                "paid_content": paid_content,
                "country": country,
                "rights": rights,
                "media": media,
                "language": language,
                "content": content,
                "word_count": word_count,
                "is_opinion": is_opinion,
                "twitter_account": twitter_account,
                "all_links": all_links,
                "all_domain_links": all_domain_links,
                "nlp": nlp,
            }
    
    score: MetaOapg.properties.score
    extraction_data: MetaOapg.properties.extraction_data
    domain_url: MetaOapg.properties.domain_url
    full_domain_url: MetaOapg.properties.full_domain_url
    link: MetaOapg.properties.link
    rank: MetaOapg.properties.rank
    id: MetaOapg.properties.id
    title: MetaOapg.properties.title
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["title"]) -> MetaOapg.properties.title: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["link"]) -> MetaOapg.properties.link: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["domain_url"]) -> MetaOapg.properties.domain_url: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["full_domain_url"]) -> MetaOapg.properties.full_domain_url: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["extraction_data"]) -> MetaOapg.properties.extraction_data: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["rank"]) -> MetaOapg.properties.rank: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["id"]) -> MetaOapg.properties.id: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["score"]) -> MetaOapg.properties.score: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["description"]) -> MetaOapg.properties.description: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["author"]) -> MetaOapg.properties.author: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["authors"]) -> MetaOapg.properties.authors: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["journalists"]) -> MetaOapg.properties.journalists: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["published_date"]) -> MetaOapg.properties.published_date: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["published_date_precision"]) -> MetaOapg.properties.published_date_precision: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["updated_date"]) -> MetaOapg.properties.updated_date: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["updated_date_precision"]) -> MetaOapg.properties.updated_date_precision: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["parse_date"]) -> MetaOapg.properties.parse_date: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["name_source"]) -> MetaOapg.properties.name_source: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["is_headline"]) -> MetaOapg.properties.is_headline: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["paid_content"]) -> MetaOapg.properties.paid_content: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["country"]) -> MetaOapg.properties.country: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["rights"]) -> MetaOapg.properties.rights: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["media"]) -> MetaOapg.properties.media: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["language"]) -> MetaOapg.properties.language: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["content"]) -> MetaOapg.properties.content: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["word_count"]) -> MetaOapg.properties.word_count: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["is_opinion"]) -> MetaOapg.properties.is_opinion: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["twitter_account"]) -> MetaOapg.properties.twitter_account: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["all_links"]) -> MetaOapg.properties.all_links: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["all_domain_links"]) -> MetaOapg.properties.all_domain_links: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nlp"]) -> MetaOapg.properties.nlp: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["title", "link", "domain_url", "full_domain_url", "extraction_data", "rank", "id", "score", "description", "author", "authors", "journalists", "published_date", "published_date_precision", "updated_date", "updated_date_precision", "parse_date", "name_source", "is_headline", "paid_content", "country", "rights", "media", "language", "content", "word_count", "is_opinion", "twitter_account", "all_links", "all_domain_links", "nlp", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["title"]) -> MetaOapg.properties.title: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["link"]) -> MetaOapg.properties.link: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["domain_url"]) -> MetaOapg.properties.domain_url: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["full_domain_url"]) -> MetaOapg.properties.full_domain_url: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["extraction_data"]) -> MetaOapg.properties.extraction_data: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["rank"]) -> MetaOapg.properties.rank: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["id"]) -> MetaOapg.properties.id: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["score"]) -> MetaOapg.properties.score: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["description"]) -> typing.Union[MetaOapg.properties.description, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["author"]) -> typing.Union[MetaOapg.properties.author, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["authors"]) -> typing.Union[MetaOapg.properties.authors, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["journalists"]) -> typing.Union[MetaOapg.properties.journalists, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["published_date"]) -> typing.Union[MetaOapg.properties.published_date, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["published_date_precision"]) -> typing.Union[MetaOapg.properties.published_date_precision, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["updated_date"]) -> typing.Union[MetaOapg.properties.updated_date, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["updated_date_precision"]) -> typing.Union[MetaOapg.properties.updated_date_precision, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["parse_date"]) -> typing.Union[MetaOapg.properties.parse_date, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["name_source"]) -> typing.Union[MetaOapg.properties.name_source, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["is_headline"]) -> typing.Union[MetaOapg.properties.is_headline, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["paid_content"]) -> typing.Union[MetaOapg.properties.paid_content, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["country"]) -> typing.Union[MetaOapg.properties.country, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["rights"]) -> typing.Union[MetaOapg.properties.rights, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["media"]) -> typing.Union[MetaOapg.properties.media, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["language"]) -> typing.Union[MetaOapg.properties.language, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["content"]) -> typing.Union[MetaOapg.properties.content, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["word_count"]) -> typing.Union[MetaOapg.properties.word_count, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["is_opinion"]) -> typing.Union[MetaOapg.properties.is_opinion, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["twitter_account"]) -> typing.Union[MetaOapg.properties.twitter_account, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["all_links"]) -> typing.Union[MetaOapg.properties.all_links, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["all_domain_links"]) -> typing.Union[MetaOapg.properties.all_domain_links, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nlp"]) -> typing.Union[MetaOapg.properties.nlp, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["title", "link", "domain_url", "full_domain_url", "extraction_data", "rank", "id", "score", "description", "author", "authors", "journalists", "published_date", "published_date_precision", "updated_date", "updated_date_precision", "parse_date", "name_source", "is_headline", "paid_content", "country", "rights", "media", "language", "content", "word_count", "is_opinion", "twitter_account", "all_links", "all_domain_links", "nlp", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        score: typing.Union[MetaOapg.properties.score, decimal.Decimal, int, float, ],
        extraction_data: typing.Union[MetaOapg.properties.extraction_data, str, ],
        domain_url: typing.Union[MetaOapg.properties.domain_url, str, ],
        full_domain_url: typing.Union[MetaOapg.properties.full_domain_url, str, ],
        link: typing.Union[MetaOapg.properties.link, str, ],
        rank: typing.Union[MetaOapg.properties.rank, decimal.Decimal, int, ],
        id: typing.Union[MetaOapg.properties.id, str, ],
        title: typing.Union[MetaOapg.properties.title, str, ],
        description: typing.Union[MetaOapg.properties.description, str, schemas.Unset] = schemas.unset,
        author: typing.Union[MetaOapg.properties.author, str, schemas.Unset] = schemas.unset,
        authors: typing.Union[MetaOapg.properties.authors, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        journalists: typing.Union[MetaOapg.properties.journalists, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        published_date: typing.Union[MetaOapg.properties.published_date, str, schemas.Unset] = schemas.unset,
        published_date_precision: typing.Union[MetaOapg.properties.published_date_precision, str, schemas.Unset] = schemas.unset,
        updated_date: typing.Union[MetaOapg.properties.updated_date, str, schemas.Unset] = schemas.unset,
        updated_date_precision: typing.Union[MetaOapg.properties.updated_date_precision, str, schemas.Unset] = schemas.unset,
        parse_date: typing.Union[MetaOapg.properties.parse_date, str, schemas.Unset] = schemas.unset,
        name_source: typing.Union[MetaOapg.properties.name_source, str, schemas.Unset] = schemas.unset,
        is_headline: typing.Union[MetaOapg.properties.is_headline, str, schemas.Unset] = schemas.unset,
        paid_content: typing.Union[MetaOapg.properties.paid_content, bool, schemas.Unset] = schemas.unset,
        country: typing.Union[MetaOapg.properties.country, str, schemas.Unset] = schemas.unset,
        rights: typing.Union[MetaOapg.properties.rights, str, schemas.Unset] = schemas.unset,
        media: typing.Union[MetaOapg.properties.media, str, schemas.Unset] = schemas.unset,
        language: typing.Union[MetaOapg.properties.language, str, schemas.Unset] = schemas.unset,
        content: typing.Union[MetaOapg.properties.content, str, schemas.Unset] = schemas.unset,
        word_count: typing.Union[MetaOapg.properties.word_count, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        is_opinion: typing.Union[MetaOapg.properties.is_opinion, bool, schemas.Unset] = schemas.unset,
        twitter_account: typing.Union[MetaOapg.properties.twitter_account, str, schemas.Unset] = schemas.unset,
        all_links: typing.Union[MetaOapg.properties.all_links, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        all_domain_links: typing.Union[MetaOapg.properties.all_domain_links, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        nlp: typing.Union[MetaOapg.properties.nlp, dict, frozendict.frozendict, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'DtoResponsesLatestHeadlinesResponseArticleResult':
        return super().__new__(
            cls,
            *args,
            score=score,
            extraction_data=extraction_data,
            domain_url=domain_url,
            full_domain_url=full_domain_url,
            link=link,
            rank=rank,
            id=id,
            title=title,
            description=description,
            author=author,
            authors=authors,
            journalists=journalists,
            published_date=published_date,
            published_date_precision=published_date_precision,
            updated_date=updated_date,
            updated_date_precision=updated_date_precision,
            parse_date=parse_date,
            name_source=name_source,
            is_headline=is_headline,
            paid_content=paid_content,
            country=country,
            rights=rights,
            media=media,
            language=language,
            content=content,
            word_count=word_count,
            is_opinion=is_opinion,
            twitter_account=twitter_account,
            all_links=all_links,
            all_domain_links=all_domain_links,
            nlp=nlp,
            _configuration=_configuration,
            **kwargs,
        )
