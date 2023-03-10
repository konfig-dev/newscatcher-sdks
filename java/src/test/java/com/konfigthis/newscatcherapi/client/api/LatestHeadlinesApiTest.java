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
import com.konfigthis.newscatcherapi.client.model.LatestHeadlines;
import com.konfigthis.newscatcherapi.client.model.Model200ResponseLatest;
import com.konfigthis.newscatcherapi.client.model.Topic;
import com.konfigthis.newscatcherapi.client.model.LatestHeadlines.LangEnum;

import org.junit.BeforeClass;
import org.junit.Test;
import org.junit.jupiter.api.Disabled;

import static org.junit.jupiter.api.Assertions.assertNotNull;

/**
 * API tests for LatestHeadlinesApi
 */
public class LatestHeadlinesApiTest {

    private static LatestHeadlinesApi api;

    @BeforeClass
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        ApiKeyAuth apiKey = (ApiKeyAuth) apiClient.getAuthentication("api_key");
        apiKey.setApiKey(System.getenv("NEWSCATCHER_API_KEY"));
        api = new LatestHeadlinesApi(apiClient);
    }

    /**
     * Get Latest News Articles
     *
     * Get the latest headlines given any topic, country, or language.
     *
     * @throws ApiException if the Api call fails
     */
    @Disabled
    @Test
    public void getTest() throws ApiException {
        String lang = null;
        String notLang = null;
        String countries = null;
        String notCountries = null;
        Topic topic = null;
        String sources = null;
        String notSources = null;
        Boolean rankedOnly = null;
        Integer pageSize = null;
        Integer page = null;
        Model200ResponseLatest response = api.get(lang, notLang, countries, notCountries, topic, sources, notSources,
                rankedOnly, pageSize, page);
        // TODO: test validations
    }

    /**
     * Get Latest News Articles
     *
     * Get the latest headlines given any topic, country, or language.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void postTest() throws ApiException {
        LatestHeadlines latestHeadlines = new LatestHeadlines().lang(LangEnum.EN);
        Model200ResponseLatest response = api.post(latestHeadlines);
        assertNotNull(response, "Response is null");
    }

}
