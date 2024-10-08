/* tslint:disable */
/* eslint-disable */
/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

The version of the OpenAPI document: 3.2.16
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/

import globalAxios, { AxiosPromise, AxiosInstance, AxiosRequestConfig } from 'axios';
import { Configuration } from '../configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import { DUMMY_BASE_URL, assertParamExists, setApiKeyToObject, setBasicAuthToObject, setBearerAuthToObject, setSearchParams, serializeDataIfNeeded, toPathString, createRequestFunction, isBrowser } from '../common';
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from '../base';
// @ts-ignore
import { From } from '../models';
// @ts-ignore
import { HTTPValidationError } from '../models';
// @ts-ignore
import { RankedOnly } from '../models';
// @ts-ignore
import { SearchGetResponse } from '../models';
// @ts-ignore
import { SearchPostResponse } from '../models';
// @ts-ignore
import { SearchRequest } from '../models';
// @ts-ignore
import { To } from '../models';
import { paginate } from "../pagination/paginate";
import type * as buffer from "buffer"
import { requestBeforeHook } from '../requestBeforeHook';
/**
 * SearchApi - axios parameter creator
 * @export
 */
export const SearchApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
         * @summary [Get] Search For Articles Request
         * @param {string} q 
         * @param {string} [searchIn] 
         * @param {any} [predefinedSources] 
         * @param {any} [sources] 
         * @param {any} [notSources] 
         * @param {any} [lang] 
         * @param {any} [notLang] 
         * @param {any} [countries] 
         * @param {any} [notCountries] 
         * @param {any} [notAuthorName] 
         * @param {From} [from] 
         * @param {To} [to] 
         * @param {string} [publishedDatePrecision] 
         * @param {boolean} [byParseDate] 
         * @param {string} [sortBy] 
         * @param {RankedOnly} [rankedOnly] 
         * @param {number} [fromRank] 
         * @param {number} [toRank] 
         * @param {boolean} [isHeadline] 
         * @param {boolean} [isOpinion] 
         * @param {boolean} [isPaidContent] 
         * @param {any} [parentUrl] 
         * @param {any} [allLinks] 
         * @param {any} [allDomainLinks] 
         * @param {number} [wordCountMin] 
         * @param {number} [wordCountMax] 
         * @param {number} [page] 
         * @param {number} [pageSize] 
         * @param {string} [clusteringVariable] 
         * @param {boolean} [clusteringEnabled] 
         * @param {number} [clusteringThreshold] 
         * @param {boolean} [includeNlpData] 
         * @param {boolean} [hasNlp] 
         * @param {string} [theme] 
         * @param {string} [notTheme] 
         * @param {string} [orgEntityName] 
         * @param {string} [perEntityName] 
         * @param {string} [locEntityName] 
         * @param {string} [miscEntityName] 
         * @param {number} [titleSentimentMin] 
         * @param {number} [titleSentimentMax] 
         * @param {number} [contentSentimentMin] 
         * @param {number} [contentSentimentMax] 
         * @param {any} [iptcTags] 
         * @param {any} [notIptcTags] 
         * @param {any} [sourceName] 
         * @param {any} [iabTags] 
         * @param {any} [notIabTags] 
         * @param {boolean} [excludeDuplicates] 
         * @param {boolean} [additionalDomainInfo] 
         * @param {boolean} [isNewsDomain] 
         * @param {any} [newsDomainType] 
         * @param {any} [newsType] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get: async (q: string, searchIn?: string, predefinedSources?: any, sources?: any, notSources?: any, lang?: any, notLang?: any, countries?: any, notCountries?: any, notAuthorName?: any, from?: From, to?: To, publishedDatePrecision?: string, byParseDate?: boolean, sortBy?: string, rankedOnly?: RankedOnly, fromRank?: number, toRank?: number, isHeadline?: boolean, isOpinion?: boolean, isPaidContent?: boolean, parentUrl?: any, allLinks?: any, allDomainLinks?: any, wordCountMin?: number, wordCountMax?: number, page?: number, pageSize?: number, clusteringVariable?: string, clusteringEnabled?: boolean, clusteringThreshold?: number, includeNlpData?: boolean, hasNlp?: boolean, theme?: string, notTheme?: string, orgEntityName?: string, perEntityName?: string, locEntityName?: string, miscEntityName?: string, titleSentimentMin?: number, titleSentimentMax?: number, contentSentimentMin?: number, contentSentimentMax?: number, iptcTags?: any, notIptcTags?: any, sourceName?: any, iabTags?: any, notIabTags?: any, excludeDuplicates?: boolean, additionalDomainInfo?: boolean, isNewsDomain?: boolean, newsDomainType?: any, newsType?: any, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'q' is not null or undefined
            assertParamExists('get', 'q', q)
            const localVarPath = `/api/search`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKey required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "x-api-token", keyParamName: "xApiToken", configuration })
            if (q !== undefined) {
                localVarQueryParameter['q'] = q;
            }

            if (searchIn !== undefined) {
                localVarQueryParameter['search_in'] = searchIn;
            }

            if (predefinedSources !== undefined) {
                localVarQueryParameter['predefined_sources'] = predefinedSources;
            }

            if (sources !== undefined) {
                localVarQueryParameter['sources'] = sources;
            }

            if (notSources !== undefined) {
                localVarQueryParameter['not_sources'] = notSources;
            }

            if (lang !== undefined) {
                localVarQueryParameter['lang'] = lang;
            }

            if (notLang !== undefined) {
                localVarQueryParameter['not_lang'] = notLang;
            }

            if (countries !== undefined) {
                localVarQueryParameter['countries'] = countries;
            }

            if (notCountries !== undefined) {
                localVarQueryParameter['not_countries'] = notCountries;
            }

            if (notAuthorName !== undefined) {
                localVarQueryParameter['not_author_name'] = notAuthorName;
            }

            if (from !== undefined) {
                localVarQueryParameter['from_'] = from;
            }

            if (to !== undefined) {
                localVarQueryParameter['to_'] = to;
            }

            if (publishedDatePrecision !== undefined) {
                localVarQueryParameter['published_date_precision'] = publishedDatePrecision;
            }

            if (byParseDate !== undefined) {
                localVarQueryParameter['by_parse_date'] = byParseDate;
            }

            if (sortBy !== undefined) {
                localVarQueryParameter['sort_by'] = sortBy;
            }

            if (rankedOnly !== undefined) {
                localVarQueryParameter['ranked_only'] = rankedOnly;
            }

            if (fromRank !== undefined) {
                localVarQueryParameter['from_rank'] = fromRank;
            }

            if (toRank !== undefined) {
                localVarQueryParameter['to_rank'] = toRank;
            }

            if (isHeadline !== undefined) {
                localVarQueryParameter['is_headline'] = isHeadline;
            }

            if (isOpinion !== undefined) {
                localVarQueryParameter['is_opinion'] = isOpinion;
            }

            if (isPaidContent !== undefined) {
                localVarQueryParameter['is_paid_content'] = isPaidContent;
            }

            if (parentUrl !== undefined) {
                localVarQueryParameter['parent_url'] = parentUrl;
            }

            if (allLinks !== undefined) {
                localVarQueryParameter['all_links'] = allLinks;
            }

            if (allDomainLinks !== undefined) {
                localVarQueryParameter['all_domain_links'] = allDomainLinks;
            }

            if (wordCountMin !== undefined) {
                localVarQueryParameter['word_count_min'] = wordCountMin;
            }

            if (wordCountMax !== undefined) {
                localVarQueryParameter['word_count_max'] = wordCountMax;
            }

            if (page !== undefined) {
                localVarQueryParameter['page'] = page;
            }

            if (pageSize !== undefined) {
                localVarQueryParameter['page_size'] = pageSize;
            }

            if (clusteringVariable !== undefined) {
                localVarQueryParameter['clustering_variable'] = clusteringVariable;
            }

            if (clusteringEnabled !== undefined) {
                localVarQueryParameter['clustering_enabled'] = clusteringEnabled;
            }

            if (clusteringThreshold !== undefined) {
                localVarQueryParameter['clustering_threshold'] = clusteringThreshold;
            }

            if (includeNlpData !== undefined) {
                localVarQueryParameter['include_nlp_data'] = includeNlpData;
            }

            if (hasNlp !== undefined) {
                localVarQueryParameter['has_nlp'] = hasNlp;
            }

            if (theme !== undefined) {
                localVarQueryParameter['theme'] = theme;
            }

            if (notTheme !== undefined) {
                localVarQueryParameter['not_theme'] = notTheme;
            }

            if (orgEntityName !== undefined) {
                localVarQueryParameter['ORG_entity_name'] = orgEntityName;
            }

            if (perEntityName !== undefined) {
                localVarQueryParameter['PER_entity_name'] = perEntityName;
            }

            if (locEntityName !== undefined) {
                localVarQueryParameter['LOC_entity_name'] = locEntityName;
            }

            if (miscEntityName !== undefined) {
                localVarQueryParameter['MISC_entity_name'] = miscEntityName;
            }

            if (titleSentimentMin !== undefined) {
                localVarQueryParameter['title_sentiment_min'] = titleSentimentMin;
            }

            if (titleSentimentMax !== undefined) {
                localVarQueryParameter['title_sentiment_max'] = titleSentimentMax;
            }

            if (contentSentimentMin !== undefined) {
                localVarQueryParameter['content_sentiment_min'] = contentSentimentMin;
            }

            if (contentSentimentMax !== undefined) {
                localVarQueryParameter['content_sentiment_max'] = contentSentimentMax;
            }

            if (iptcTags !== undefined) {
                localVarQueryParameter['iptc_tags'] = iptcTags;
            }

            if (notIptcTags !== undefined) {
                localVarQueryParameter['not_iptc_tags'] = notIptcTags;
            }

            if (sourceName !== undefined) {
                localVarQueryParameter['source_name'] = sourceName;
            }

            if (iabTags !== undefined) {
                localVarQueryParameter['iab_tags'] = iabTags;
            }

            if (notIabTags !== undefined) {
                localVarQueryParameter['not_iab_tags'] = notIabTags;
            }

            if (excludeDuplicates !== undefined) {
                localVarQueryParameter['exclude_duplicates'] = excludeDuplicates;
            }

            if (additionalDomainInfo !== undefined) {
                localVarQueryParameter['additional_domain_info'] = additionalDomainInfo;
            }

            if (isNewsDomain !== undefined) {
                localVarQueryParameter['is_news_domain'] = isNewsDomain;
            }

            if (newsDomainType !== undefined) {
                localVarQueryParameter['news_domain_type'] = newsDomainType;
            }

            if (newsType !== undefined) {
                localVarQueryParameter['news_type'] = newsType;
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration,
                pathTemplate: '/api/search',
                httpMethod: 'GET'
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
         * @summary [Post] Search For Articles Request
         * @param {SearchRequest} searchRequest 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        post: async (searchRequest: SearchRequest, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'searchRequest' is not null or undefined
            assertParamExists('post', 'searchRequest', searchRequest)
            const localVarPath = `/api/search`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKey required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "x-api-token", keyParamName: "xApiToken", configuration })

    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: searchRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration,
                pathTemplate: '/api/search',
                httpMethod: 'POST'
            });
            localVarRequestOptions.data = serializeDataIfNeeded(searchRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * SearchApi - functional programming interface
 * @export
 */
export const SearchApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = SearchApiAxiosParamCreator(configuration)
    return {
        /**
         * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
         * @summary [Get] Search For Articles Request
         * @param {SearchApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async get(requestParameters: SearchApiGetRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchGetResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.get(requestParameters.q, requestParameters.searchIn, requestParameters.predefinedSources, requestParameters.sources, requestParameters.notSources, requestParameters.lang, requestParameters.notLang, requestParameters.countries, requestParameters.notCountries, requestParameters.notAuthorName, requestParameters.from, requestParameters.to, requestParameters.publishedDatePrecision, requestParameters.byParseDate, requestParameters.sortBy, requestParameters.rankedOnly, requestParameters.fromRank, requestParameters.toRank, requestParameters.isHeadline, requestParameters.isOpinion, requestParameters.isPaidContent, requestParameters.parentUrl, requestParameters.allLinks, requestParameters.allDomainLinks, requestParameters.wordCountMin, requestParameters.wordCountMax, requestParameters.page, requestParameters.pageSize, requestParameters.clusteringVariable, requestParameters.clusteringEnabled, requestParameters.clusteringThreshold, requestParameters.includeNlpData, requestParameters.hasNlp, requestParameters.theme, requestParameters.notTheme, requestParameters.orgEntityName, requestParameters.perEntityName, requestParameters.locEntityName, requestParameters.miscEntityName, requestParameters.titleSentimentMin, requestParameters.titleSentimentMax, requestParameters.contentSentimentMin, requestParameters.contentSentimentMax, requestParameters.iptcTags, requestParameters.notIptcTags, requestParameters.sourceName, requestParameters.iabTags, requestParameters.notIabTags, requestParameters.excludeDuplicates, requestParameters.additionalDomainInfo, requestParameters.isNewsDomain, requestParameters.newsDomainType, requestParameters.newsType, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
         * @summary [Post] Search For Articles Request
         * @param {SearchApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async post(requestParameters: SearchApiPostRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchPostResponse>> {
            const searchRequest: SearchRequest = {
                q: requestParameters.q,
                search_in: requestParameters.search_in,
                predefined_sources: requestParameters.predefined_sources,
                sources: requestParameters.sources,
                not_sources: requestParameters.not_sources,
                lang: requestParameters.lang,
                not_lang: requestParameters.not_lang,
                countries: requestParameters.countries,
                not_countries: requestParameters.not_countries,
                not_author_name: requestParameters.not_author_name,
                from_: requestParameters.from_,
                to_: requestParameters.to_,
                published_date_precision: requestParameters.published_date_precision,
                by_parse_date: requestParameters.by_parse_date,
                sort_by: requestParameters.sort_by,
                ranked_only: requestParameters.ranked_only,
                from_rank: requestParameters.from_rank,
                to_rank: requestParameters.to_rank,
                is_headline: requestParameters.is_headline,
                is_opinion: requestParameters.is_opinion,
                is_paid_content: requestParameters.is_paid_content,
                parent_url: requestParameters.parent_url,
                all_links: requestParameters.all_links,
                all_domain_links: requestParameters.all_domain_links,
                word_count_min: requestParameters.word_count_min,
                word_count_max: requestParameters.word_count_max,
                page: requestParameters.page,
                page_size: requestParameters.page_size,
                clustering_variable: requestParameters.clustering_variable,
                clustering_enabled: requestParameters.clustering_enabled,
                clustering_threshold: requestParameters.clustering_threshold,
                include_nlp_data: requestParameters.include_nlp_data,
                has_nlp: requestParameters.has_nlp,
                theme: requestParameters.theme,
                not_theme: requestParameters.not_theme,
                ORG_entity_name: requestParameters.ORG_entity_name,
                PER_entity_name: requestParameters.PER_entity_name,
                LOC_entity_name: requestParameters.LOC_entity_name,
                MISC_entity_name: requestParameters.MISC_entity_name,
                title_sentiment_min: requestParameters.title_sentiment_min,
                title_sentiment_max: requestParameters.title_sentiment_max,
                content_sentiment_min: requestParameters.content_sentiment_min,
                content_sentiment_max: requestParameters.content_sentiment_max,
                iptc_tags: requestParameters.iptc_tags,
                not_iptc_tags: requestParameters.not_iptc_tags,
                source_name: requestParameters.source_name,
                iab_tags: requestParameters.iab_tags,
                not_iab_tags: requestParameters.not_iab_tags,
                exclude_duplicates: requestParameters.exclude_duplicates,
                additional_domain_info: requestParameters.additional_domain_info,
                is_news_domain: requestParameters.is_news_domain,
                news_domain_type: requestParameters.news_domain_type,
                news_type: requestParameters.news_type
            };
            const localVarAxiosArgs = await localVarAxiosParamCreator.post(searchRequest, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * SearchApi - factory interface
 * @export
 */
export const SearchApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = SearchApiFp(configuration)
    return {
        /**
         * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
         * @summary [Get] Search For Articles Request
         * @param {SearchApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get(requestParameters: SearchApiGetRequest, options?: AxiosRequestConfig): AxiosPromise<SearchGetResponse> {
            return localVarFp.get(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
         * @summary [Post] Search For Articles Request
         * @param {SearchApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        post(requestParameters: SearchApiPostRequest, options?: AxiosRequestConfig): AxiosPromise<SearchPostResponse> {
            return localVarFp.post(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for get operation in SearchApi.
 * @export
 * @interface SearchApiGetRequest
 */
export type SearchApiGetRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly q: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly searchIn?: string
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly predefinedSources?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly sources?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly notSources?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly lang?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly notLang?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly countries?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly notCountries?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly notAuthorName?: any
    
    /**
    * 
    * @type {From}
    * @memberof SearchApiGet
    */
    readonly from?: From
    
    /**
    * 
    * @type {To}
    * @memberof SearchApiGet
    */
    readonly to?: To
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly publishedDatePrecision?: string
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly byParseDate?: boolean
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly sortBy?: string
    
    /**
    * 
    * @type {RankedOnly}
    * @memberof SearchApiGet
    */
    readonly rankedOnly?: RankedOnly
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly fromRank?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly toRank?: number
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly isHeadline?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly isOpinion?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly isPaidContent?: boolean
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly parentUrl?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly allLinks?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly allDomainLinks?: any
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly wordCountMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly wordCountMax?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly page?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly pageSize?: number
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly clusteringVariable?: string
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly clusteringEnabled?: boolean
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly clusteringThreshold?: number
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly includeNlpData?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly hasNlp?: boolean
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly theme?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly notTheme?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly orgEntityName?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly perEntityName?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly locEntityName?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchApiGet
    */
    readonly miscEntityName?: string
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly titleSentimentMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly titleSentimentMax?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly contentSentimentMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchApiGet
    */
    readonly contentSentimentMax?: number
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly iptcTags?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly notIptcTags?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly sourceName?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly iabTags?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly notIabTags?: any
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly excludeDuplicates?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly additionalDomainInfo?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchApiGet
    */
    readonly isNewsDomain?: boolean
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly newsDomainType?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchApiGet
    */
    readonly newsType?: any
    
}

/**
 * Request parameters for post operation in SearchApi.
 * @export
 * @interface SearchApiPostRequest
 */
export type SearchApiPostRequest = {
    
} & SearchRequest

/**
 * SearchApiGenerated - object-oriented interface
 * @export
 * @class SearchApiGenerated
 * @extends {BaseAPI}
 */
export class SearchApiGenerated extends BaseAPI {
    /**
     * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
     * @summary [Get] Search For Articles Request
     * @param {SearchApiGetRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchApiGenerated
     */
    public get(requestParameters: SearchApiGetRequest, options?: AxiosRequestConfig) {
        return SearchApiFp(this.configuration).get(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.
     * @summary [Post] Search For Articles Request
     * @param {SearchApiPostRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchApiGenerated
     */
    public post(requestParameters: SearchApiPostRequest, options?: AxiosRequestConfig) {
        return SearchApiFp(this.configuration).post(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}
