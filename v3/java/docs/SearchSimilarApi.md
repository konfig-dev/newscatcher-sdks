# SearchSimilarApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get**](SearchSimilarApi.md#get) | **GET** /api/search_similar | [Get] Search For Similar Articles Request |
| [**post**](SearchSimilarApi.md#post) | **POST** /api/search_similar | [Post] Search For Similar Articles Request |


<a name="get"></a>
# **get**
> FSearchResponse2 get(q).searchIn(searchIn).includeSimilarDocuments(includeSimilarDocuments).similarDocumentsNumber(similarDocumentsNumber).similarDocumentsFields(similarDocumentsFields).predefinedSources(predefinedSources).sources(sources).notSources(notSources).lang(lang).notLang(notLang).countries(countries).notCountries(notCountries).from(from).to(to).byParseDate(byParseDate).publishedDatePrecision(publishedDatePrecision).sortBy(sortBy).rankedOnly(rankedOnly).fromRank(fromRank).toRank(toRank).isHeadline(isHeadline).isPaidContent(isPaidContent).parentUrl(parentUrl).allLinks(allLinks).allDomainLinks(allDomainLinks).wordCountMin(wordCountMin).wordCountMax(wordCountMax).page(page).pageSize(pageSize).includeNlpData(includeNlpData).hasNlp(hasNlp).theme(theme).nerName(nerName).titleSentimentMin(titleSentimentMin).titleSentimentMax(titleSentimentMax).contentSentimentMin(contentSentimentMin).contentSentimentMax(contentSentimentMax).execute();

[Get] Search For Similar Articles Request

This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchSimilarApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
    String q = "q_example";
    String searchIn = "title_content";
    Boolean includeSimilarDocuments = false;
    Integer similarDocumentsNumber = 5;
    String similarDocumentsFields = "title,content";
    String predefinedSources = "predefinedSources_example";
    String sources = "sources_example";
    String notSources = "notSources_example";
    String lang = "lang_example";
    String notLang = "notLang_example";
    String countries = "countries_example";
    String notCountries = "notCountries_example";
    String from = "from_example";
    String to = "to_example";
    Boolean byParseDate = false;
    String publishedDatePrecision = "publishedDatePrecision_example";
    String sortBy = "relevancy";
    String rankedOnly = "rankedOnly_example";
    Integer fromRank = 56;
    Integer toRank = 56;
    Boolean isHeadline = true;
    Boolean isPaidContent = true;
    String parentUrl = "parentUrl_example";
    String allLinks = "allLinks_example";
    String allDomainLinks = "allDomainLinks_example";
    Integer wordCountMin = 56;
    Integer wordCountMax = 56;
    Integer page = 1;
    Integer pageSize = 100;
    Boolean includeNlpData = true;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String nerName = "nerName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    try {
      FSearchResponse2 result = client
              .searchSimilar
              .get(q)
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
              .nerName(nerName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .execute();
      System.out.println(result);
      System.out.println(result.getStatus());
      System.out.println(result.getTotalHits());
      System.out.println(result.getPage());
      System.out.println(result.getTotalPages());
      System.out.println(result.getPageSize());
      System.out.println(result.getArticles());
      System.out.println(result.getUserInput());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchSimilarApi#get");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<FSearchResponse2> response = client
              .searchSimilar
              .get(q)
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
              .nerName(nerName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .executeWithHttpInfo();
      System.out.println(response.getResponseBody());
      System.out.println(response.getResponseHeaders());
      System.out.println(response.getStatusCode());
      System.out.println(response.getRoundTripTime());
      System.out.println(response.getRequest());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchSimilarApi#get");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}

```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q** | **String**|  | |
| **searchIn** | **String**|  | [optional] [default to title_content] |
| **includeSimilarDocuments** | **Boolean**|  | [optional] [default to false] |
| **similarDocumentsNumber** | **Integer**|  | [optional] [default to 5] |
| **similarDocumentsFields** | **String**|  | [optional] [default to title,content] |
| **predefinedSources** | **String**|  | [optional] |
| **sources** | **String**|  | [optional] |
| **notSources** | **String**|  | [optional] |
| **lang** | **String**|  | [optional] |
| **notLang** | **String**|  | [optional] |
| **countries** | **String**|  | [optional] |
| **notCountries** | **String**|  | [optional] |
| **from** | **String**|  | [optional] |
| **to** | **String**|  | [optional] |
| **byParseDate** | **Boolean**|  | [optional] [default to false] |
| **publishedDatePrecision** | **String**|  | [optional] |
| **sortBy** | **String**|  | [optional] [default to relevancy] |
| **rankedOnly** | **String**|  | [optional] |
| **fromRank** | **Integer**|  | [optional] |
| **toRank** | **Integer**|  | [optional] |
| **isHeadline** | **Boolean**|  | [optional] |
| **isPaidContent** | **Boolean**|  | [optional] |
| **parentUrl** | **String**|  | [optional] |
| **allLinks** | **String**|  | [optional] |
| **allDomainLinks** | **String**|  | [optional] |
| **wordCountMin** | **Integer**|  | [optional] |
| **wordCountMax** | **Integer**|  | [optional] |
| **page** | **Integer**|  | [optional] [default to 1] |
| **pageSize** | **Integer**|  | [optional] [default to 100] |
| **includeNlpData** | **Boolean**|  | [optional] |
| **hasNlp** | **Boolean**|  | [optional] |
| **theme** | **String**|  | [optional] |
| **nerName** | **String**|  | [optional] |
| **titleSentimentMin** | **Double**|  | [optional] |
| **titleSentimentMax** | **Double**|  | [optional] |
| **contentSentimentMin** | **Double**|  | [optional] |
| **contentSentimentMax** | **Double**|  | [optional] |

### Return type

[**FSearchResponse2**](FSearchResponse2.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

<a name="post"></a>
# **post**
> FSearchResponse3 post(moreLikeThisRequest).execute();

[Post] Search For Similar Articles Request

This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchSimilarApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
    String q = "q_example";
    String searchIn = "title_content";
    Boolean includeSimilarDocuments = false;
    Integer similarDocumentsNumber = 5;
    String similarDocumentsFields = "title,content";
    String predefinedSources = "predefinedSources_example";
    String sources = "sources_example";
    String notSources = "notSources_example";
    String lang = "lang_example";
    String notLang = "notLang_example";
    String countries = "countries_example";
    String notCountries = "notCountries_example";
    String from = "from_example";
    String to = "to_example";
    Boolean byParseDate = false;
    String publishedDatePrecision = "publishedDatePrecision_example";
    String sortBy = "relevancy";
    String rankedOnly = "rankedOnly_example";
    Integer fromRank = 56;
    Integer toRank = 56;
    Boolean isHeadline = true;
    Boolean isPaidContent = true;
    String parentUrl = "parentUrl_example";
    String allLinks = "allLinks_example";
    String allDomainLinks = "allDomainLinks_example";
    Integer wordCountMin = 56;
    Integer wordCountMax = 56;
    Integer page = 1;
    Integer pageSize = 100;
    Boolean includeNlpData = true;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String nerName = "nerName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    try {
      FSearchResponse3 result = client
              .searchSimilar
              .post(q)
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
              .nerName(nerName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .execute();
      System.out.println(result);
      System.out.println(result.getStatus());
      System.out.println(result.getTotalHits());
      System.out.println(result.getPage());
      System.out.println(result.getTotalPages());
      System.out.println(result.getPageSize());
      System.out.println(result.getArticles());
      System.out.println(result.getUserInput());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchSimilarApi#post");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<FSearchResponse3> response = client
              .searchSimilar
              .post(q)
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
              .nerName(nerName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .executeWithHttpInfo();
      System.out.println(response.getResponseBody());
      System.out.println(response.getResponseHeaders());
      System.out.println(response.getStatusCode());
      System.out.println(response.getRoundTripTime());
      System.out.println(response.getRequest());
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchSimilarApi#post");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}

```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **moreLikeThisRequest** | [**MoreLikeThisRequest**](MoreLikeThisRequest.md)|  | |

### Return type

[**FSearchResponse3**](FSearchResponse3.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

