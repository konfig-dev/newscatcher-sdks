package com.konfigthis.newscatcherapi.client;

import com.konfigthis.newscatcherapi.client.api.AuthorsApiGenerated;
import org.junit.Before;
import org.junit.Test;

import java.util.Map;

import static org.junit.Assert.assertNotNull;

public class AllOperationsTest {
    final String MOCK_SERVER_URL = "http://localhost:4010";
    Newscatcher client;

    @Before
    public void setUp() throws Exception {
        Configuration configuration = new Configuration();
        configuration.host = MOCK_SERVER_URL;
        configuration.apiKey = "YOUR API KEY";
        client = new Newscatcher(configuration);
    }

    @Test
    public void authorsGetOnlyRequired() throws ApiException {
        Map test = (Map) client.authors.get("test").execute();
        assertNotNull(test);
        assertNotNull(test.get("user_input"));
    }

    @Test
    public void authorsPostOnlyRequired() throws ApiException {
        Map test = (Map) client.authors.post("test").execute();
        assertNotNull(test);
        assertNotNull(test.get("user_input"));
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
        Map test = (Map) client.latestHeadlines.get()
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
        assertNotNull(test);
        assertNotNull(test.get("user_input"));
    }

}
