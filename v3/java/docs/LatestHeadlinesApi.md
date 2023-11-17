# LatestHeadlinesApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get**](LatestHeadlinesApi.md#get) | **GET** /api/latest_headlines | [Get] Search For Latest Headlines Request |
| [**post**](LatestHeadlinesApi.md#post) | **POST** /api/latest_headlines | [Post] Search For Latest Headlines Request |


<a name="get"></a>
# **get**
> Object get().when(when).byParseDate(byParseDate).lang(lang).notLang(notLang).countries(countries).notCountries(notCountries).sources(sources).predefinedSources(predefinedSources).notSources(notSources).rankedOnly(rankedOnly).isHeadline(isHeadline).isPaidContent(isPaidContent).parentUrl(parentUrl).theme(theme).allLinks(allLinks).allDomainLinks(allDomainLinks).wordCountMin(wordCountMin).wordCountMax(wordCountMax).page(page).pageSize(pageSize).clusteringEnabled(clusteringEnabled).clusteringThreshold(clusteringThreshold).clusteringVariable(clusteringVariable).includeNlpData(includeNlpData).hasNlp(hasNlp).orGEntityName(orGEntityName).peREntityName(peREntityName).loCEntityName(loCEntityName).miSCEntityName(miSCEntityName).titleSentimentMin(titleSentimentMin).titleSentimentMax(titleSentimentMax).contentSentimentMin(contentSentimentMin).contentSentimentMax(contentSentimentMax).execute();

[Get] Search For Latest Headlines Request

This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.LatestHeadlinesApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
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
    try {
      Object result = client
              .latestHeadlines
              .get()
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
    } catch (ApiException e) {
      System.err.println("Exception when calling LatestHeadlinesApi#get");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<Object> response = client
              .latestHeadlines
              .get()
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
              .executeWithHttpInfo();
      System.out.println(response.getResponseBody());
      System.out.println(response.getResponseHeaders());
      System.out.println(response.getStatusCode());
      System.out.println(response.getRoundTripTime());
      System.out.println(response.getRequest());
    } catch (ApiException e) {
      System.err.println("Exception when calling LatestHeadlinesApi#get");
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
| **when** | **String**|  | [optional] [default to 7d] |
| **byParseDate** | **Boolean**|  | [optional] [default to false] |
| **lang** | **String**|  | [optional] |
| **notLang** | **String**|  | [optional] |
| **countries** | **String**|  | [optional] |
| **notCountries** | **String**|  | [optional] |
| **sources** | **String**|  | [optional] |
| **predefinedSources** | **String**|  | [optional] |
| **notSources** | **String**|  | [optional] |
| **rankedOnly** | **String**|  | [optional] |
| **isHeadline** | **Boolean**|  | [optional] |
| **isPaidContent** | **Boolean**|  | [optional] |
| **parentUrl** | **String**|  | [optional] |
| **theme** | **String**|  | [optional] |
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
> Object post(latestHeadlinesRequest).execute();

[Post] Search For Latest Headlines Request

This endpoint allows you to get latest headlines. You need to specify since when you want to get the latest headlines. You can also filter by language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.LatestHeadlinesApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
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
    try {
      Object result = client
              .latestHeadlines
              .post()
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
    } catch (ApiException e) {
      System.err.println("Exception when calling LatestHeadlinesApi#post");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<Object> response = client
              .latestHeadlines
              .post()
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
              .executeWithHttpInfo();
      System.out.println(response.getResponseBody());
      System.out.println(response.getResponseHeaders());
      System.out.println(response.getStatusCode());
      System.out.println(response.getRoundTripTime());
      System.out.println(response.getRequest());
    } catch (ApiException e) {
      System.err.println("Exception when calling LatestHeadlinesApi#post");
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
| **latestHeadlinesRequest** | [**LatestHeadlinesRequest**](LatestHeadlinesRequest.md)|  | |

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

