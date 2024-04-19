/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

The version of the OpenAPI document: 3.2.16
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/
import type * as buffer from "buffer"


/**
 * Search response data model
 * @export
 * @interface DtoResponsesAuthorSearchResponseSearchResponse
 */
export interface DtoResponsesAuthorSearchResponseSearchResponse {
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesAuthorSearchResponseSearchResponse
     */
    'status'?: string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesAuthorSearchResponseSearchResponse
     */
    'total_hits': number;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesAuthorSearchResponseSearchResponse
     */
    'page': number;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesAuthorSearchResponseSearchResponse
     */
    'total_pages': number;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesAuthorSearchResponseSearchResponse
     */
    'page_size': number;
    /**
     * 
     * @type {Array<object>}
     * @memberof DtoResponsesAuthorSearchResponseSearchResponse
     */
    'articles': Array<object>;
    /**
     * 
     * @type {object}
     * @memberof DtoResponsesAuthorSearchResponseSearchResponse
     */
    'user_input': object;
}

