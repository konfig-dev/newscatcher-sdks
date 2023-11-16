# SearchApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get**](SearchApi.md#get) | **GET** /api/search | [Get] Search For Articles Request |
| [**post**](SearchApi.md#post) | **POST** /api/search | [Post] Search For Articles Request |


<a name="get"></a>
# **get**
> Object get(q).searchIn(searchIn).predefinedSources(predefinedSources).sources(sources).notSources(notSources).lang(lang).notLang(notLang).countries(countries).notCountries(notCountries).from(from).to(to).publishedDatePrecision(publishedDatePrecision).byParseDate(byParseDate).sortBy(sortBy).rankedOnly(rankedOnly).fromRank(fromRank).toRank(toRank).isHeadline(isHeadline).isPaidContent(isPaidContent).parentUrl(parentUrl).allLinks(allLinks).allDomainLinks(allDomainLinks).wordCountMin(wordCountMin).wordCountMax(wordCountMax).page(page).pageSize(pageSize).clusteringEnabled(clusteringEnabled).clusteringThreshold(clusteringThreshold).clusteringVariable(clusteringVariable).includeNlpData(includeNlpData).hasNlp(hasNlp).theme(theme).orGEntityName(orGEntityName).peREntityName(peREntityName).loCEntityName(loCEntityName).miSCEntityName(miSCEntityName).titleSentimentMin(titleSentimentMin).titleSentimentMax(titleSentimentMax).contentSentimentMin(contentSentimentMin).contentSentimentMax(contentSentimentMax).execute();

[Get] Search For Articles Request

This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    // Configure API key authorization: apiKey
    configuration.x-api-token  = "YOUR API KEY";

    Newscatcher client = new Newscatcher(configuration);
    String q = "q_example";
    String searchIn = "title_content";
    String predefinedSources = "predefinedSources_example";
    String sources = "sources_example";
    String notSources = "notSources_example";
    String lang = "lang_example";
    String notLang = "notLang_example";
    String countries = "countries_example";
    String notCountries = "notCountries_example";
    Object from = null;
    Object to = null;
    String publishedDatePrecision = "publishedDatePrecision_example";
    Boolean byParseDate = false;
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
    Boolean clusteringEnabled = true;
    Double clusteringThreshold = 3.4D;
    String clusteringVariable = "clusteringVariable_example";
    Boolean includeNlpData = true;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String orGEntityName = "orGEntityName_example";
    String peREntityName = "peREntityName_example";
    String loCEntityName = "loCEntityName_example";
    String miSCEntityName = "miSCEntityName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    try {
      Object result = client
              .search
              .get(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
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
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .clusteringVariable(clusteringVariable)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .execute();
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#get");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<Object> response = client
              .search
              .get(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
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
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .clusteringVariable(clusteringVariable)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
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
      System.err.println("Exception when calling SearchApi#get");
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
| **predefinedSources** | **String**|  | [optional] |
| **sources** | **String**|  | [optional] |
| **notSources** | **String**|  | [optional] |
| **lang** | **String**|  | [optional] |
| **notLang** | **String**|  | [optional] |
| **countries** | **String**|  | [optional] |
| **notCountries** | **String**|  | [optional] |
| **from** | [**Object**](.md)|  | [optional] |
| **to** | [**Object**](.md)|  | [optional] |
| **publishedDatePrecision** | **String**|  | [optional] |
| **byParseDate** | **Boolean**|  | [optional] [default to false] |
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
| **clusteringEnabled** | **Boolean**|  | [optional] |
| **clusteringThreshold** | **Double**|  | [optional] |
| **clusteringVariable** | **String**|  | [optional] |
| **includeNlpData** | **Boolean**|  | [optional] |
| **hasNlp** | **Boolean**|  | [optional] |
| **theme** | **String**|  | [optional] |
| **orGEntityName** | **String**|  | [optional] |
| **peREntityName** | **String**|  | [optional] |
| **loCEntityName** | **String**|  | [optional] |
| **miSCEntityName** | **String**|  | [optional] |
| **titleSentimentMin** | **Double**|  | [optional] |
| **titleSentimentMax** | **Double**|  | [optional] |
| **contentSentimentMin** | **Double**|  | [optional] |
| **contentSentimentMax** | **Double**|  | [optional] |

### Return type

**Object**

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
> Object post(searchRequest).execute();

[Post] Search For Articles Request

This endpoint allows you to search for articles. You can search for articles by keyword, language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    // Configure API key authorization: apiKey
    configuration.x-api-token  = "YOUR API KEY";

    Newscatcher client = new Newscatcher(configuration);
    String q = "q_example";
    String searchIn = "title_content";
    String predefinedSources = "predefinedSources_example";
    String sources = "sources_example";
    String notSources = "notSources_example";
    String lang = "lang_example";
    String notLang = "notLang_example";
    String countries = "countries_example";
    String notCountries = "notCountries_example";
    Object from = null;
    Object to = null;
    String publishedDatePrecision = "publishedDatePrecision_example";
    Boolean byParseDate = false;
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
    Boolean clusteringEnabled = true;
    Double clusteringThreshold = 3.4D;
    String clusteringVariable = "clusteringVariable_example";
    Boolean includeNlpData = true;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String orGEntityName = "orGEntityName_example";
    String peREntityName = "peREntityName_example";
    String loCEntityName = "loCEntityName_example";
    String miSCEntityName = "miSCEntityName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    try {
      Object result = client
              .search
              .post(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
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
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .clusteringVariable(clusteringVariable)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
              .titleSentimentMin(titleSentimentMin)
              .titleSentimentMax(titleSentimentMax)
              .contentSentimentMin(contentSentimentMin)
              .contentSentimentMax(contentSentimentMax)
              .execute();
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#post");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<Object> response = client
              .search
              .post(q)
              .searchIn(searchIn)
              .predefinedSources(predefinedSources)
              .sources(sources)
              .notSources(notSources)
              .lang(lang)
              .notLang(notLang)
              .countries(countries)
              .notCountries(notCountries)
              .from(from)
              .to(to)
              .publishedDatePrecision(publishedDatePrecision)
              .byParseDate(byParseDate)
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
              .clusteringEnabled(clusteringEnabled)
              .clusteringThreshold(clusteringThreshold)
              .clusteringVariable(clusteringVariable)
              .includeNlpData(includeNlpData)
              .hasNlp(hasNlp)
              .theme(theme)
              .orGEntityName(orGEntityName)
              .peREntityName(peREntityName)
              .loCEntityName(loCEntityName)
              .miSCEntityName(miSCEntityName)
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
      System.err.println("Exception when calling SearchApi#post");
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
| **searchRequest** | [**SearchRequest**](SearchRequest.md)|  | |

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

