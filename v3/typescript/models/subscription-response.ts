/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

The version of the OpenAPI document: 3.2.16
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/
import type * as buffer from "buffer"


/**
 * SubscriptionResponse DTO class.
 * @export
 * @interface SubscriptionResponse
 */
export interface SubscriptionResponse {
    /**
     * 
     * @type {boolean}
     * @memberof SubscriptionResponse
     */
    'active': boolean;
    /**
     * 
     * @type {number}
     * @memberof SubscriptionResponse
     */
    'calls_per_seconds'?: number;
    /**
     * 
     * @type {string}
     * @memberof SubscriptionResponse
     */
    'plan_name': string;
    /**
     * 
     * @type {number}
     * @memberof SubscriptionResponse
     */
    'usage_assigned_calls'?: number;
    /**
     * 
     * @type {number}
     * @memberof SubscriptionResponse
     */
    'usage_remaining_calls'?: number;
    /**
     * 
     * @type {number}
     * @memberof SubscriptionResponse
     */
    'historical_days'?: number;
}

