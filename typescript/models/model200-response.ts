/* tslint:disable */
/* eslint-disable */
/**
 * NewsCatcher News API V2
 * NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we\'re like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: team@newscatcherapi.com
 *
 * NOTE: This file is auto generated by Konfig (https://konfigthis.com).
 * https://konfigthis.com
 * Do not edit the class manually.
 */

// May contain unused imports in some cases
// @ts-ignore
import { ArticleInner } from './article-inner';
// May contain unused imports in some cases
// @ts-ignore
import { SearchUserInput } from './search-user-input';
// May contain unused imports in some cases
// @ts-ignore
import { SuccessStatus } from './success-status';

/**
 * 
 * @export
 * @interface Model200Response
 */
export interface Model200Response {
    /**
     * 
     * @type {SuccessStatus}
     * @memberof Model200Response
     */
    'status'?: SuccessStatus;
    /**
     * 
     * @type {number}
     * @memberof Model200Response
     */
    'total_hits'?: number;
    /**
     * 
     * @type {number}
     * @memberof Model200Response
     */
    'page'?: number;
    /**
     * 
     * @type {number}
     * @memberof Model200Response
     */
    'total_pages'?: number;
    /**
     * 
     * @type {number}
     * @memberof Model200Response
     */
    'page_size'?: number;
    /**
     * 
     * @type {Array<ArticleInner>}
     * @memberof Model200Response
     */
    'articles'?: Array<ArticleInner>;
    /**
     * 
     * @type {SearchUserInput}
     * @memberof Model200Response
     */
    'user_input'?: SearchUserInput;
}

