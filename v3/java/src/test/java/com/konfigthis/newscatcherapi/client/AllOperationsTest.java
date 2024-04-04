package com.konfigthis.newscatcherapi.client;

import com.konfigthis.newscatcherapi.client.model.*;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertNotNull;

public class AllOperationsTest {
    static final String MOCK_SERVER_URL = "http://localhost:4010";
    static Newscatcher client;

    @BeforeAll
    public static void setUp() throws Exception {
        Configuration configuration = new Configuration();
        configuration.host = MOCK_SERVER_URL;
        configuration.apiKey = "YOUR API KEY";
        client = new Newscatcher(configuration);
    }

    @Test
    public void authorsGetOnlyRequired() throws ApiException {
        FSearchResponse test =
                client.authors.get("test").execute();
        assertNotNull(test);
        assertNotNull(test.getUserInput());
    }

    @Test
    public void authorsPostOnlyRequired() throws ApiException {
        FSearchResponse1 test = client.authors.post("test").execute();
        assertNotNull(test);
        assertNotNull(test.getUserInput());
    }

    @Test
    public void latestHeadlinesGet() throws ApiException {
        String when = "7d";
        Boolean byParseDate = false;
        String lang = "lang_example";
        String notLang = "notLang_example";
        String countries = "countries_example";
        String notCountries = "notCountries_example";
        String sources = "sources_example";
        String predefinedSources = "predefinedSources_example";
        String notSources = "notSources_example";
        String rankedOnly = "rankedOnly_example";
        Boolean isHeadline = true;
        Boolean isPaidContent = true;
        String parentUrl = "parentUrl_example";
        String theme = "theme_example";
        String allLinks = "allLinks_example";
        String allDomainLinks = "allDomainLinks_example";
        Integer wordCountMin = 56;
        Integer wordCountMax = 56;
        Integer page = 1;
        Integer pageSize = 100;
        Boolean clusteringEnabled = true;
        Double clusteringThreshold = 3.4D;
        String clusteringVariable = "clusteringVariable_example";
        Boolean includeNlpData = true;
        Boolean hasNlp = true;
        String orGEntityName = "orGEntityName_example";
        String peREntityName = "peREntityName_example";
        String loCEntityName = "loCEntityName_example";
        String miSCEntityName = "miSCEntityName_example";
        Double titleSentimentMin = 3.4D;
        Double titleSentimentMax = 3.4D;
        Double contentSentimentMin = 3.4D;
        Double contentSentimentMax = 3.4D;
        CSLHResponse response = client.latestHeadlines.get()
                .when(when)
                .byParseDate(byParseDate)
                .lang(lang)
                .notLang(notLang)
                .countries(countries)
                .notCountries(notCountries)
                .sources(sources)
                .predefinedSources(predefinedSources)
                .notSources(notSources)
                .rankedOnly(rankedOnly)
                .isHeadline(isHeadline)
                .isPaidContent(isPaidContent)
                .parentUrl(parentUrl)
                .theme(theme)
                .allLinks(allLinks)
                .allDomainLinks(allDomainLinks)
                .wordCountMin(wordCountMin)
                .wordCountMax(wordCountMax)
                .page(page)
                .pageSize(pageSize)
                .clusteringEnabled(clusteringEnabled)
                .clusteringThreshold(clusteringThreshold)
                .clusteringVariable(clusteringVariable)
                .includeNlpData(includeNlpData)
                .hasNlp(hasNlp)
                .orGEntityName(orGEntityName)
                .peREntityName(peREntityName)
                .loCEntityName(loCEntityName)
                .miSCEntityName(miSCEntityName)
                .titleSentimentMin(titleSentimentMin)
                .titleSentimentMax(titleSentimentMax)
                .contentSentimentMin(contentSentimentMin)
                .contentSentimentMax(contentSentimentMax)
                .execute();
        assertNotNull(response);
        assertNotNull(response.getUserInput());
    }

    @Test
    public void testSearchSimilarGet() throws ApiException {
        FSearchResponse2 response = client.searchSimilar.get("test").execute();
        assertNotNull(response.getUserInput());
    }

    @Test
    public void testSearchSimilarPost() throws ApiException {
        FSearchResponse3 response = client.searchSimilar.post("test").searchIn("test").execute();
        assertNotNull(response.getUserInput());
    }

    @Test
    public void testSubscriptionsPost() throws ApiException {
        SubscriptionResponse response = client.subscription.post().execute();
        assertNotNull(response.getActive());
        assertNotNull(response.getPlanName());
    }

}
