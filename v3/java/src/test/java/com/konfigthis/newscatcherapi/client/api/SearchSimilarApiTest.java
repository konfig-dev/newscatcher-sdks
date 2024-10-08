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
import com.konfigthis.newscatcherapi.client.model.FSearchResponse2;
import com.konfigthis.newscatcherapi.client.model.FSearchResponse3;
import com.konfigthis.newscatcherapi.client.model.MoreLikeThisRequest;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for SearchSimilarApi
 */
@Disabled
public class SearchSimilarApiTest {

    private static SearchSimilarApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new SearchSimilarApi(apiClient);
    }

    /**
     * [Get] Search For Similar Articles Request
     *
     * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getTest() throws ApiException {
        String q = null;
        String searchIn = null;
        Boolean includeSimilarDocuments = null;
        Integer similarDocumentsNumber = null;
        String similarDocumentsFields = null;
        Object predefinedSources = null;
        Object sources = null;
        Object notSources = null;
        Object lang = null;
        Object notLang = null;
        Object countries = null;
        Object notCountries = null;
        String from = null;
        String to = null;
        Boolean byParseDate = null;
        String publishedDatePrecision = null;
        String sortBy = null;
        Object rankedOnly = null;
        Integer fromRank = null;
        Integer toRank = null;
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
        Boolean includeNlpData = null;
        Boolean hasNlp = null;
        String theme = null;
        String notTheme = null;
        Double titleSentimentMin = null;
        Double titleSentimentMax = null;
        Double contentSentimentMin = null;
        Double contentSentimentMax = null;
        Object iptcTags = null;
        Object notIptcTags = null;
        FSearchResponse2 response = api.get(q)
                .searchIn(searchIn)
                .includeSimilarDocuments(includeSimilarDocuments)
                .similarDocumentsNumber(similarDocumentsNumber)
                .similarDocumentsFields(similarDocumentsFields)
                .predefinedSources(predefinedSources)
                .sources(sources)
                .notSources(notSources)
                .lang(lang)
                .notLang(notLang)
                .countries(countries)
                .notCountries(notCountries)
                .from(from)
                .to(to)
                .byParseDate(byParseDate)
                .publishedDatePrecision(publishedDatePrecision)
                .sortBy(sortBy)
                .rankedOnly(rankedOnly)
                .fromRank(fromRank)
                .toRank(toRank)
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
                .includeNlpData(includeNlpData)
                .hasNlp(hasNlp)
                .theme(theme)
                .notTheme(notTheme)
                .titleSentimentMin(titleSentimentMin)
                .titleSentimentMax(titleSentimentMax)
                .contentSentimentMin(contentSentimentMin)
                .contentSentimentMax(contentSentimentMax)
                .iptcTags(iptcTags)
                .notIptcTags(notIptcTags)
                .execute();
        // TODO: test validations
    }

    /**
     * [Post] Search For Similar Articles Request
     *
     * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void postTest() throws ApiException {
        String q = null;
        String searchIn = null;
        Boolean includeSimilarDocuments = null;
        Integer similarDocumentsNumber = null;
        String similarDocumentsFields = null;
        Object predefinedSources = null;
        Object sources = null;
        Object notSources = null;
        Object lang = null;
        Object notLang = null;
        Object countries = null;
        Object notCountries = null;
        String from = null;
        String to = null;
        Boolean byParseDate = null;
        String publishedDatePrecision = null;
        String sortBy = null;
        Object rankedOnly = null;
        Integer fromRank = null;
        Integer toRank = null;
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
        Boolean includeNlpData = null;
        Boolean hasNlp = null;
        String theme = null;
        String notTheme = null;
        Double titleSentimentMin = null;
        Double titleSentimentMax = null;
        Double contentSentimentMin = null;
        Double contentSentimentMax = null;
        Object iptcTags = null;
        Object notIptcTags = null;
        FSearchResponse3 response = api.post(q)
                .searchIn(searchIn)
                .includeSimilarDocuments(includeSimilarDocuments)
                .similarDocumentsNumber(similarDocumentsNumber)
                .similarDocumentsFields(similarDocumentsFields)
                .predefinedSources(predefinedSources)
                .sources(sources)
                .notSources(notSources)
                .lang(lang)
                .notLang(notLang)
                .countries(countries)
                .notCountries(notCountries)
                .from(from)
                .to(to)
                .byParseDate(byParseDate)
                .publishedDatePrecision(publishedDatePrecision)
                .sortBy(sortBy)
                .rankedOnly(rankedOnly)
                .fromRank(fromRank)
                .toRank(toRank)
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
                .includeNlpData(includeNlpData)
                .hasNlp(hasNlp)
                .theme(theme)
                .notTheme(notTheme)
                .titleSentimentMin(titleSentimentMin)
                .titleSentimentMax(titleSentimentMax)
                .contentSentimentMin(contentSentimentMin)
                .contentSentimentMax(contentSentimentMax)
                .iptcTags(iptcTags)
                .notIptcTags(notIptcTags)
                .execute();
        // TODO: test validations
    }

}
