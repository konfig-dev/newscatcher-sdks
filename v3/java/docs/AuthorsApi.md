# AuthorsApi

All URIs are relative to *https://v3-api.newscatcherapi.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get**](AuthorsApi.md#get) | **GET** /api/authors | [Get] Search By Author Request |
| [**post**](AuthorsApi.md#post) | **POST** /api/authors | [Post] Search By Author Request |


<a name="get"></a>
# **get**
> FSearchResponse get(authorName).sources(sources).predefinedSources(predefinedSources).notSources(notSources).lang(lang).notLang(notLang).countries(countries).notCountries(notCountries).from(from).to(to).publishedDatePrecision(publishedDatePrecision).byParseDate(byParseDate).sortBy(sortBy).rankedOnly(rankedOnly).fromRank(fromRank).toRank(toRank).isHeadline(isHeadline).isPaidContent(isPaidContent).parentUrl(parentUrl).allLinks(allLinks).allDomainLinks(allDomainLinks).wordCountMin(wordCountMin).wordCountMax(wordCountMax).page(page).pageSize(pageSize).includeNlpData(includeNlpData).hasNlp(hasNlp).theme(theme).nerName(nerName).titleSentimentMin(titleSentimentMin).titleSentimentMax(titleSentimentMax).contentSentimentMin(contentSentimentMin).contentSentimentMax(contentSentimentMax).execute();

[Get] Search By Author Request

This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.AuthorsApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
    String authorName = "authorName_example";
    String sources = "sources_example";
    String predefinedSources = "predefinedSources_example";
    String notSources = "notSources_example";
    String lang = "lang_example";
    String notLang = "notLang_example";
    String countries = "countries_example";
    String notCountries = "notCountries_example";
    String from = "from_example";
    String to = "to_example";
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
    Boolean includeNlpData = true;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String nerName = "nerName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    try {
      FSearchResponse result = client
              .authors
              .get(authorName)
              .sources(sources)
              .predefinedSources(predefinedSources)
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
      System.err.println("Exception when calling AuthorsApi#get");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<FSearchResponse> response = client
              .authors
              .get(authorName)
              .sources(sources)
              .predefinedSources(predefinedSources)
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
      System.err.println("Exception when calling AuthorsApi#get");
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
| **authorName** | **String**|  | |
| **sources** | **String**|  | [optional] |
| **predefinedSources** | **String**|  | [optional] |
| **notSources** | **String**|  | [optional] |
| **lang** | **String**|  | [optional] |
| **notLang** | **String**|  | [optional] |
| **countries** | **String**|  | [optional] |
| **notCountries** | **String**|  | [optional] |
| **from** | **String**|  | [optional] |
| **to** | **String**|  | [optional] |
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
| **includeNlpData** | **Boolean**|  | [optional] |
| **hasNlp** | **Boolean**|  | [optional] |
| **theme** | **String**|  | [optional] |
| **nerName** | **String**|  | [optional] |
| **titleSentimentMin** | **Double**|  | [optional] |
| **titleSentimentMax** | **Double**|  | [optional] |
| **contentSentimentMin** | **Double**|  | [optional] |
| **contentSentimentMax** | **Double**|  | [optional] |

### Return type

[**FSearchResponse**](FSearchResponse.md)

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
> FSearchResponse1 post(authorSearchRequest).execute();

[Post] Search By Author Request

This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.

### Example
```java
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiResponse;
import com.konfigthis.newscatcherapi.client.Newscatcher;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.AuthorsApi;
import java.util.List;
import java.util.Map;
import java.util.UUID;

public class Example {
  public static void main(String[] args) {
    Configuration configuration = new Configuration();
    configuration.host = "https://v3-api.newscatcherapi.com";
    
    configuration.apiKey  = "YOUR API KEY";
    Newscatcher client = new Newscatcher(configuration);
    String authorName = "authorName_example";
    String sources = "sources_example";
    String predefinedSources = "predefinedSources_example";
    String notSources = "notSources_example";
    String lang = "lang_example";
    String notLang = "notLang_example";
    String countries = "countries_example";
    String notCountries = "notCountries_example";
    String from = "from_example";
    String to = "to_example";
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
    Boolean includeNlpData = true;
    Boolean hasNlp = true;
    String theme = "theme_example";
    String nerName = "nerName_example";
    Double titleSentimentMin = 3.4D;
    Double titleSentimentMax = 3.4D;
    Double contentSentimentMin = 3.4D;
    Double contentSentimentMax = 3.4D;
    try {
      FSearchResponse1 result = client
              .authors
              .post(authorName)
              .sources(sources)
              .predefinedSources(predefinedSources)
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
      System.err.println("Exception when calling AuthorsApi#post");
      System.err.println("Status code: " + e.getStatusCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }

    // Use .executeWithHttpInfo() to retrieve HTTP Status Code, Headers and Request
    try {
      ApiResponse<FSearchResponse1> response = client
              .authors
              .post(authorName)
              .sources(sources)
              .predefinedSources(predefinedSources)
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
      System.err.println("Exception when calling AuthorsApi#post");
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
| **authorSearchRequest** | [**AuthorSearchRequest**](AuthorSearchRequest.md)|  | |

### Return type

[**FSearchResponse1**](FSearchResponse1.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

