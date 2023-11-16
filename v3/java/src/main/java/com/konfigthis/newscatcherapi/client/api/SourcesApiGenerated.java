/*
 * NewsCatcher-V3 Production API
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: Beta-3.0.0
 * Contact: maksym@newscatcherapi.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.newscatcherapi.client.api;

import com.konfigthis.newscatcherapi.client.ApiCallback;
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.Pair;
import com.konfigthis.newscatcherapi.client.ProgressRequestBody;
import com.konfigthis.newscatcherapi.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import com.konfigthis.newscatcherapi.client.model.SourceResponse;
import com.konfigthis.newscatcherapi.client.model.SourcesRequest;
import com.konfigthis.newscatcherapi.client.model.UserInput;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.ws.rs.core.GenericType;

public class SourcesApiGenerated {
    private ApiClient localVarApiClient;
    private int localHostIndex;
    private String localCustomBaseUrl;

    public SourcesApiGenerated() throws IllegalArgumentException {
        this(Configuration.getDefaultApiClient());
    }

    public SourcesApiGenerated(ApiClient apiClient) throws IllegalArgumentException {
        if (apiClient.getApiKey() == null) {
            throw new IllegalArgumentException("\"x-api-token\" is required but no API key was provided. Please set \"x-api-token\" with ApiClient#setApiKey(String).");
        }
        this.localVarApiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return localVarApiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    public int getHostIndex() {
        return localHostIndex;
    }

    public void setHostIndex(int hostIndex) {
        this.localHostIndex = hostIndex;
    }

    public String getCustomBaseUrl() {
        return localCustomBaseUrl;
    }

    public void setCustomBaseUrl(String customBaseUrl) {
        this.localCustomBaseUrl = customBaseUrl;
    }

    private okhttp3.Call getCall(String lang, String countries, final ApiCallback _callback) throws ApiException {
        String basePath = null;
        // Operation Servers
        String[] localBasePaths = new String[] {  };

        // Determine Base Path to Use
        if (localCustomBaseUrl != null){
            basePath = localCustomBaseUrl;
        } else if ( localBasePaths.length > 0 ) {
            basePath = localBasePaths[localHostIndex];
        } else {
            basePath = null;
        }

        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/api/sources";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        if (lang != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("lang", lang));
        }

        if (countries != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("countries", countries));
        }

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "apiKey" };
        return localVarApiClient.buildCall(basePath, localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call getValidateBeforeCall(String lang, String countries, final ApiCallback _callback) throws ApiException {
        return getCall(lang, countries, _callback);

    }


    private ApiResponse<SourceResponse> getWithHttpInfo(String lang, String countries) throws ApiException {
        okhttp3.Call localVarCall = getValidateBeforeCall(lang, countries, null);
        Type localVarReturnType = new TypeToken<SourceResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    private okhttp3.Call getAsync(String lang, String countries, final ApiCallback<SourceResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = getValidateBeforeCall(lang, countries, _callback);
        Type localVarReturnType = new TypeToken<SourceResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }

    public class GetRequestBuilder {
        private String lang;
        private String countries;

        private GetRequestBuilder() {
        }

        /**
         * Set lang
         * @param lang  (optional)
         * @return GetRequestBuilder
         */
        public GetRequestBuilder lang(String lang) {
            this.lang = lang;
            return this;
        }
        
        /**
         * Set countries
         * @param countries  (optional)
         * @return GetRequestBuilder
         */
        public GetRequestBuilder countries(String countries) {
            this.countries = countries;
            return this;
        }
        
        /**
         * Build call for get
         * @param _callback ApiCallback API callback
         * @return Call to execute
         * @throws ApiException If fail to serialize the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public okhttp3.Call buildCall(final ApiCallback _callback) throws ApiException {
            return getCall(lang, countries, _callback);
        }


        /**
         * Execute get request
         * @return SourceResponse
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public SourceResponse execute() throws ApiException {
            ApiResponse<SourceResponse> localVarResp = getWithHttpInfo(lang, countries);
            return localVarResp.getResponseBody();
        }

        /**
         * Execute get request with HTTP info returned
         * @return ApiResponse&lt;SourceResponse&gt;
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public ApiResponse<SourceResponse> executeWithHttpInfo() throws ApiException {
            return getWithHttpInfo(lang, countries);
        }

        /**
         * Execute get request (asynchronously)
         * @param _callback The callback to be executed when the API call finishes
         * @return The request call
         * @throws ApiException If fail to process the API call, e.g. serializing the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public okhttp3.Call executeAsync(final ApiCallback<SourceResponse> _callback) throws ApiException {
            return getAsync(lang, countries, _callback);
        }
    }

    /**
     * [Get] Search For Sources Request
     * This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
     * @return GetRequestBuilder
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
     </table>
     */
    public GetRequestBuilder get() throws IllegalArgumentException {
        return new GetRequestBuilder();
    }
    private okhttp3.Call postCall(SourcesRequest sourcesRequest, final ApiCallback _callback) throws ApiException {
        String basePath = null;
        // Operation Servers
        String[] localBasePaths = new String[] {  };

        // Determine Base Path to Use
        if (localCustomBaseUrl != null){
            basePath = localCustomBaseUrl;
        } else if ( localBasePaths.length > 0 ) {
            basePath = localBasePaths[localHostIndex];
        } else {
            basePath = null;
        }

        Object localVarPostBody = sourcesRequest;

        // create path and map variables
        String localVarPath = "/api/sources";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "apiKey" };
        return localVarApiClient.buildCall(basePath, localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call postValidateBeforeCall(SourcesRequest sourcesRequest, final ApiCallback _callback) throws ApiException {
        // verify the required parameter 'sourcesRequest' is set
        if (sourcesRequest == null) {
            throw new ApiException("Missing the required parameter 'sourcesRequest' when calling post(Async)");
        }

        return postCall(sourcesRequest, _callback);

    }


    private ApiResponse<SourceResponse> postWithHttpInfo(SourcesRequest sourcesRequest) throws ApiException {
        okhttp3.Call localVarCall = postValidateBeforeCall(sourcesRequest, null);
        Type localVarReturnType = new TypeToken<SourceResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    private okhttp3.Call postAsync(SourcesRequest sourcesRequest, final ApiCallback<SourceResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = postValidateBeforeCall(sourcesRequest, _callback);
        Type localVarReturnType = new TypeToken<SourceResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }

    public class PostRequestBuilder {
        private String lang;
        private String countries;

        private PostRequestBuilder() {
        }

        /**
         * Set lang
         * @param lang  (optional)
         * @return PostRequestBuilder
         */
        public PostRequestBuilder lang(String lang) {
            this.lang = lang;
            return this;
        }
        
        /**
         * Set countries
         * @param countries  (optional)
         * @return PostRequestBuilder
         */
        public PostRequestBuilder countries(String countries) {
            this.countries = countries;
            return this;
        }
        
        /**
         * Build call for post
         * @param _callback ApiCallback API callback
         * @return Call to execute
         * @throws ApiException If fail to serialize the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public okhttp3.Call buildCall(final ApiCallback _callback) throws ApiException {
            SourcesRequest sourcesRequest = buildBodyParams();
            return postCall(sourcesRequest, _callback);
        }

        private SourcesRequest buildBodyParams() {
            SourcesRequest sourcesRequest = new SourcesRequest();
            sourcesRequest.lang(this.lang);
            sourcesRequest.countries(this.countries);
            return sourcesRequest;
        }

        /**
         * Execute post request
         * @return SourceResponse
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public SourceResponse execute() throws ApiException {
            SourcesRequest sourcesRequest = buildBodyParams();
            ApiResponse<SourceResponse> localVarResp = postWithHttpInfo(sourcesRequest);
            return localVarResp.getResponseBody();
        }

        /**
         * Execute post request with HTTP info returned
         * @return ApiResponse&lt;SourceResponse&gt;
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public ApiResponse<SourceResponse> executeWithHttpInfo() throws ApiException {
            SourcesRequest sourcesRequest = buildBodyParams();
            return postWithHttpInfo(sourcesRequest);
        }

        /**
         * Execute post request (asynchronously)
         * @param _callback The callback to be executed when the API call finishes
         * @return The request call
         * @throws ApiException If fail to process the API call, e.g. serializing the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
         </table>
         */
        public okhttp3.Call executeAsync(final ApiCallback<SourceResponse> _callback) throws ApiException {
            SourcesRequest sourcesRequest = buildBodyParams();
            return postAsync(sourcesRequest, _callback);
        }
    }

    /**
     * [Post] Search For Sources Request
     * This endpoint allows you to get the list of sources that are available in the database. You can filter the sources by language and country. The maximum number of sources displayed is set according to your plan. You can find the list of plans and their features here: https://newscatcherapi.com/news-api#news-api-pricing
     * @param sourcesRequest  (required)
     * @return PostRequestBuilder
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> Successful Response </td><td>  -  </td></tr>
     </table>
     */
    public PostRequestBuilder post() throws IllegalArgumentException {
        return new PostRequestBuilder();
    }
}
