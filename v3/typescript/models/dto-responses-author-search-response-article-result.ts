/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

The version of the OpenAPI document: 3.2.16
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/
import type * as buffer from "buffer"

import { AllDomainLinksProperty } from './all-domain-links-property';
import { AllLinksProperty } from './all-links-property';
import { AuthorsProperty } from './authors-property';
import { JournalistsProperty } from './journalists-property';

/**
 * Article result data model
 * @export
 * @interface DtoResponsesAuthorSearchResponseArticleResult
 */
export interface DtoResponsesAuthorSearchResponseArticleResult {
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'title': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'description'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'author'?: string;
    /**
     * 
     * @type {AuthorsProperty}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'authors'?: AuthorsProperty;
    /**
     * 
     * @type {JournalistsProperty}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'journalists'?: JournalistsProperty;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'published_date'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'published_date_precision'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'updated_date'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'updated_date_precision'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'parse_date'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'link': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'domain_url': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'full_domain_url': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'name_source'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'is_headline'?: string;
    /**
     * 
     * @type {boolean}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'paid_content'?: boolean;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'extraction_data': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'country'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'rights'?: string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'rank': number;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'media'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'language'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'content': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'title_translated_en'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'content_translated_en'?: string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'word_count'?: number;
    /**
     * 
     * @type {boolean}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'is_opinion'?: boolean;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'twitter_account'?: string;
    /**
     * 
     * @type {AllLinksProperty}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'all_links'?: AllLinksProperty;
    /**
     * 
     * @type {AllDomainLinksProperty}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'all_domain_links'?: AllDomainLinksProperty;
    /**
     * 
     * @type {object}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'nlp'?: object;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'id': string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'score': number;
    /**
     * 
     * @type {object}
     * @memberof DtoResponsesAuthorSearchResponseArticleResult
     */
    'custom_tags'?: object;
}

