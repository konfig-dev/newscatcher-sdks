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
import com.konfigthis.newscatcherapi.client.model.CSLHResponse;
import com.konfigthis.newscatcherapi.client.model.CSLHResponse1;
import com.konfigthis.newscatcherapi.client.model.LatestHeadlinesRequest;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for LatestHeadlinesApi
 */
@Disabled
public class LatestHeadlinesApiTest {

    private static LatestHeadlinesApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new LatestHeadlinesApi(apiClient);
    }

    /**
     * [Get] Search For Latest Headlines Request
     *
     * This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getTest() throws ApiException {
        String when = null;
        Boolean byParseDate = null;
        String sortBy = null;
        Object lang = null;
        Object notLang = null;
        Object countries = null;
        Object notCountries = null;
        Object sources = null;
        Object predefinedSources = null;
        Object notSources = null;
        Object notAuthorName = null;
        Object rankedOnly = null;
        Boolean isHeadline = null;
        Boolean isOpinion = null;
        Boolean isPaidContent = null;
        Object parentUrl = null;
        Object allLinks = null;
        Object allDomainLinks = null;
        Integer wordCountMin = null;
        Integer wordCountMax = null;
        Integer page = null;
        Integer pageSize = null;
        String clusteringVariable = null;
        Boolean clusteringEnabled = null;
        Double clusteringThreshold = null;
        Boolean includeNlpData = null;
        Boolean hasNlp = null;
        String theme = null;
        String notTheme = null;
        String orGEntityName = null;
        String peREntityName = null;
        String loCEntityName = null;
        String miSCEntityName = null;
        Double titleSentimentMin = null;
        Double titleSentimentMax = null;
        Double contentSentimentMin = null;
        Double contentSentimentMax = null;
        Object iptcTags = null;
        Object notIptcTags = null;
        Object iabTags = null;
        Object notIabTags = null;
        CSLHResponse response = api.get()
                .when(when)
                .byParseDate(byParseDate)
                .sortBy(sortBy)
                .lang(lang)
                .notLang(notLang)
                .countries(countries)
                .notCountries(notCountries)
                .sources(sources)
                .predefinedSources(predefinedSources)
                .notSources(notSources)
                .notAuthorName(notAuthorName)
                .rankedOnly(rankedOnly)
                .isHeadline(isHeadline)
                .isOpinion(isOpinion)
                .isPaidContent(isPaidContent)
                .parentUrl(parentUrl)
                .allLinks(allLinks)
                .allDomainLinks(allDomainLinks)
                .wordCountMin(wordCountMin)
                .wordCountMax(wordCountMax)
                .page(page)
                .pageSize(pageSize)
                .clusteringVariable(clusteringVariable)
                .clusteringEnabled(clusteringEnabled)
                .clusteringThreshold(clusteringThreshold)
                .includeNlpData(includeNlpData)
                .hasNlp(hasNlp)
                .theme(theme)
                .notTheme(notTheme)
                .orGEntityName(orGEntityName)
                .peREntityName(peREntityName)
                .loCEntityName(loCEntityName)
                .miSCEntityName(miSCEntityName)
                .titleSentimentMin(titleSentimentMin)
                .titleSentimentMax(titleSentimentMax)
                .contentSentimentMin(contentSentimentMin)
                .contentSentimentMax(contentSentimentMax)
                .iptcTags(iptcTags)
                .notIptcTags(notIptcTags)
                .iabTags(iabTags)
                .notIabTags(notIabTags)
                .execute();
        // TODO: test validations
    }

    /**
     * [Post] Search For Latest Headlines Request
     *
     * This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void postTest() throws ApiException {
        String when = null;
        Boolean byParseDate = null;
        String sortBy = null;
        Object lang = null;
        Object notLang = null;
        Object countries = null;
        Object notCountries = null;
        Object sources = null;
        Object predefinedSources = null;
        Object notSources = null;
        Object notAuthorName = null;
        Object rankedOnly = null;
        Boolean isHeadline = null;
        Boolean isOpinion = null;
        Boolean isPaidContent = null;
        Object parentUrl = null;
        Object allLinks = null;
        Object allDomainLinks = null;
        Integer wordCountMin = null;
        Integer wordCountMax = null;
        Integer page = null;
        Integer pageSize = null;
        String clusteringVariable = null;
        Boolean clusteringEnabled = null;
        Double clusteringThreshold = null;
        Boolean includeNlpData = null;
        Boolean hasNlp = null;
        String theme = null;
        String notTheme = null;
        String orGEntityName = null;
        String peREntityName = null;
        String loCEntityName = null;
        String miSCEntityName = null;
        Double titleSentimentMin = null;
        Double titleSentimentMax = null;
        Double contentSentimentMin = null;
        Double contentSentimentMax = null;
        Object iptcTags = null;
        Object notIptcTags = null;
        Object iabTags = null;
        Object notIabTags = null;
        CSLHResponse1 response = api.post()
                .when(when)
                .byParseDate(byParseDate)
                .sortBy(sortBy)
                .lang(lang)
                .notLang(notLang)
                .countries(countries)
                .notCountries(notCountries)
                .sources(sources)
                .predefinedSources(predefinedSources)
                .notSources(notSources)
                .notAuthorName(notAuthorName)
                .rankedOnly(rankedOnly)
                .isHeadline(isHeadline)
                .isOpinion(isOpinion)
                .isPaidContent(isPaidContent)
                .parentUrl(parentUrl)
                .allLinks(allLinks)
                .allDomainLinks(allDomainLinks)
                .wordCountMin(wordCountMin)
                .wordCountMax(wordCountMax)
                .page(page)
                .pageSize(pageSize)
                .clusteringVariable(clusteringVariable)
                .clusteringEnabled(clusteringEnabled)
                .clusteringThreshold(clusteringThreshold)
                .includeNlpData(includeNlpData)
                .hasNlp(hasNlp)
                .theme(theme)
                .notTheme(notTheme)
                .orGEntityName(orGEntityName)
                .peREntityName(peREntityName)
                .loCEntityName(loCEntityName)
                .miSCEntityName(miSCEntityName)
                .titleSentimentMin(titleSentimentMin)
                .titleSentimentMax(titleSentimentMax)
                .contentSentimentMin(contentSentimentMin)
                .contentSentimentMax(contentSentimentMax)
                .iptcTags(iptcTags)
                .notIptcTags(notIptcTags)
                .iabTags(iabTags)
                .notIabTags(notIabTags)
                .execute();
        // TODO: test validations
    }

}
