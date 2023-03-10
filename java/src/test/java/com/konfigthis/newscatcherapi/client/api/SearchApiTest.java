/*
 * NewsCatcher News API V2
 * NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: team@newscatcherapi.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */

package com.konfigthis.newscatcherapi.client.api;

import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.ApiKeyAuth;
import com.konfigthis.newscatcherapi.client.model.Model200Response;
import com.konfigthis.newscatcherapi.client.model.PublishDatePrecision;
import com.konfigthis.newscatcherapi.client.model.Search;
import com.konfigthis.newscatcherapi.client.model.SearchIn;
import com.konfigthis.newscatcherapi.client.model.SortBy;
import com.konfigthis.newscatcherapi.client.model.Topic;

import static org.junit.jupiter.api.Assertions.assertNotNull;

import org.junit.BeforeClass;
import org.junit.Test;
import org.junit.jupiter.api.Disabled;

/**
 * API tests for SearchApi
 */
public class SearchApiTest {

    private static SearchApi api;

    @BeforeClass
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        ApiKeyAuth apiKey = (ApiKeyAuth) apiClient.getAuthentication("api_key");
        apiKey.setApiKey(System.getenv("NEWSCATCHER_API_KEY"));
        api = new SearchApi(apiClient);
    }

    /**
     * Search for specific news articles
     *
     * Main endpoint that allows you to find news article by keyword, date,
     * language, country, etc.
     *
     * @throws ApiException if the Api call fails
     */
    @Disabled
    @Test
    public void getTest() throws ApiException {
        String q = null;
        String lang = null;
        String notLang = null;
        PublishDatePrecision publishedDatePrecision = null;
        String from = null;
        String to = null;
        SearchIn searchIn = null;
        String countries = null;
        String notCountries = null;
        Topic topic = null;
        String sources = null;
        String notSources = null;
        Boolean rankedOnly = null;
        Integer fromRank = null;
        Integer toRank = null;
        SortBy sortBy = null;
        Integer pageSize = null;
        Integer page = null;
        Model200Response response = api.get(q, lang, notLang, publishedDatePrecision, from, to, searchIn, countries,
                notCountries, topic, sources, notSources, rankedOnly, fromRank, toRank, sortBy, pageSize, page);
        // TODO: test validations
    }

    /**
     * Search for specific news articles
     *
     * Main endpoint that allows you to find news article by keyword, date,
     * language, country, etc.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void postTest() throws ApiException {
        Search search = new Search().q("Apple").from("three months ago");
        Model200Response response = api.post(search);
        assertNotNull(response, "Response is null");
    }

}
