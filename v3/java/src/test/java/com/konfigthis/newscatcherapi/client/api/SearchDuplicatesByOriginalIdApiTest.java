/*
 * NewsCatcher-V3 Production API
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.newscatcherapi.client.api;

import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.model.CSearchResponse2;
import com.konfigthis.newscatcherapi.client.model.CSearchResponse3;
import com.konfigthis.newscatcherapi.client.model.DuplicatesByOriginalIdRequest;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for SearchDuplicatesByOriginalIdApi
 */
@Disabled
public class SearchDuplicatesByOriginalIdApiTest {

    private static SearchDuplicatesByOriginalIdApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new SearchDuplicatesByOriginalIdApi(apiClient);
    }

    /**
     * [Get] Search Duplicate Articles For Articles Request
     *
     * This endpoint allows you to search for duplicate articles by original article id.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getTest() throws ApiException {
        String originalArticleId = null;
        Integer page = null;
        Integer pageSize = null;
        CSearchResponse2 response = api.get(originalArticleId)
                .page(page)
                .pageSize(pageSize)
                .execute();
        // TODO: test validations
    }

    /**
     * [Post] Search Duplicate Articles For Articles Request
     *
     * This endpoint allows you to search for duplicate articles by original article id.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void postTest() throws ApiException {
        String originalArticleId = null;
        Integer page = null;
        Integer pageSize = null;
        CSearchResponse3 response = api.post(originalArticleId)
                .page(page)
                .pageSize(pageSize)
                .execute();
        // TODO: test validations
    }

}
