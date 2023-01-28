# SearchApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get**](SearchApi.md#get) | **GET** /search | Search for specific news articles |
| [**post**](SearchApi.md#post) | **POST** /search | Search for specific news articles |


<a name="get"></a>
# **get**
> Model200Response get(q, lang, notLang, publishedDatePrecision, from, to, searchIn, countries, notCountries, topic, sources, notSources, rankedOnly, fromRank, toRank, sortBy, pageSize, page)

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example
```java
// Import classes:
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://api.newscatcherapi.com/v2");
    
    // Configure API key authorization: api_key
    ApiKeyAuth api_key = (ApiKeyAuth) defaultClient.getAuthentication("api_key");
    api_key.setApiKey("YOUR API KEY");
    // Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
    //api_key.setApiKeyPrefix("Token");

    SearchApi apiInstance = new SearchApi(defaultClient);
    String q = "\"Elon Musk\""; // String | Keyword/keywords you're searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations 
    String lang = "af"; // String | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code. 
    String notLang = "af"; // String | Inverse to the `lang` parameter 
    PublishDatePrecision publishedDatePrecision = PublishDatePrecision.fromValue("full"); // PublishDatePrecision | There are 3 types of date precision we define: `full` — day and time of an article is correctly identified with the appropriate timezone `timezone unknown` — day and time of an article is correctly identified without timezone `date` — only the day is identified without an exact time 
    String from = "from_example"; // String | `YYYY/mm/dd` From which point in time to start the search. The default timezone is UTC. Defaults to the past week. 
    String to = "to_example"; // String | `YYYY/mm/dd` Until which point in time to search for. The default timezone is UTC. 
    SearchIn searchIn = SearchIn.fromValue("title"); // SearchIn | By default, we search what you specified in the `q` parameter in both `title` and `summary` of the article. However, you can limit this to either `title` or `summary` 
    String countries = "countries_example"; // String | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US` 
    String notCountries = "notCountries_example"; // String | The inverse of the `countries` parameter. 
    Topic topic = Topic.fromValue("news"); // Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label. 
    String sources = "sources_example"; // String | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com` 
    String notSources = "notSources_example"; // String | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com` 
    Boolean rankedOnly = true; // Boolean | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999` 
    Integer fromRank = 56; // Integer | `[0:999999]` The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular 
    Integer toRank = 56; // Integer | `[0:999999]` The upper boundary of the rank of a news website to filter by. 
    SortBy sortBy = SortBy.fromValue("relevancy"); // SortBy | `relevancy` (default value) — the most relevant results first `date` — the most recently published results first `rank` — the results from the highest-ranked sources first 
    Integer pageSize = 56; // Integer | `[1:100]` How many articles to return per page. 
    Integer page = 56; // Integer | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles. 
    try {
      Model200Response result = apiInstance.get(q, lang, notLang, publishedDatePrecision, from, to, searchIn, countries, notCountries, topic, sources, notSources, rankedOnly, fromRank, toRank, sortBy, pageSize, page);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#get");
      System.err.println("Status code: " + e.getCode());
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
| **q** | **String**| Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations  | |
| **lang** | **String**| Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | [optional] [enum: af, ar, bg, bn, ca, cn, cs, cy, da, de, el, en, es, et, fa, fi, fr, gu, he, hi, hr, hu, id, it, ja, kn, ko, lt, lv, mk, ml, mr, ne, nl, false, pa, pl, pt, ro, ru, sk, sl, so, sq, sv, sw, ta, te, th, tl, tr, tw, uk, ur, vi] |
| **notLang** | **String**| Inverse to the &#x60;lang&#x60; parameter  | [optional] [enum: af, ar, bg, bn, ca, cn, cs, cy, da, de, el, en, es, et, fa, fi, fr, gu, he, hi, hr, hu, id, it, ja, kn, ko, lt, lv, mk, ml, mr, ne, nl, false, pa, pl, pt, ro, ru, sk, sl, so, sq, sv, sw, ta, te, th, tl, tr, tw, uk, ur, vi] |
| **publishedDatePrecision** | [**PublishDatePrecision**](.md)| There are 3 types of date precision we define: &#x60;full&#x60; — day and time of an article is correctly identified with the appropriate timezone &#x60;timezone unknown&#x60; — day and time of an article is correctly identified without timezone &#x60;date&#x60; — only the day is identified without an exact time  | [optional] [enum: full, timezone unknown, date] |
| **from** | **String**| &#x60;YYYY/mm/dd&#x60; From which point in time to start the search. The default timezone is UTC. Defaults to the past week.  | [optional] |
| **to** | **String**| &#x60;YYYY/mm/dd&#x60; Until which point in time to search for. The default timezone is UTC.  | [optional] |
| **searchIn** | [**SearchIn**](.md)| By default, we search what you specified in the &#x60;q&#x60; parameter in both &#x60;title&#x60; and &#x60;summary&#x60; of the article. However, you can limit this to either &#x60;title&#x60; or &#x60;summary&#x60;  | [optional] [enum: title, summary, title_summary] |
| **countries** | **String**| Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | [optional] |
| **notCountries** | **String**| The inverse of the &#x60;countries&#x60; parameter.  | [optional] |
| **topic** | [**Topic**](.md)| Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | [optional] [enum: news, sport, tech, world, finance, politics, business, economics, entertainment, beauty, travel, music, food, science, gaming] |
| **sources** | **String**| One or more news resources to filter your search. It should be the normal form of the URL, For example: &#x60;nytimes.com,theguardian.com&#x60;  | [optional] |
| **notSources** | **String**| One or more sources to be excluded from the search. Comma-separated list. For example: &#x60;nytimes.com,cnn.com,wsj.com&#x60;  | [optional] |
| **rankedOnly** | **Boolean**| Default: &#x60;True&#x60; Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals &#x60;999999&#x60;  | [optional] |
| **fromRank** | **Integer**| &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | [optional] |
| **toRank** | **Integer**| &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | [optional] |
| **sortBy** | [**SortBy**](.md)| &#x60;relevancy&#x60; (default value) — the most relevant results first &#x60;date&#x60; — the most recently published results first &#x60;rank&#x60; — the results from the highest-ranked sources first  | [optional] [enum: relevancy, date, rank] |
| **pageSize** | **Integer**| &#x60;[1:100]&#x60; How many articles to return per page.  | [optional] |
| **page** | **Integer**| The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | [optional] |

### Return type

[**Model200Response**](Model200Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | API is not put in headers |  -  |
| **401** | API Key not found |  -  |
| **406** | Wrong parameter has been used |  -  |
| **408** | Request Timeout |  -  |
| **429** | Concurrency violated |  -  |

<a name="post"></a>
# **post**
> Model200Response post(search)

Search for specific news articles

Main endpoint that allows you to find news article by keyword, date, language, country, etc.

### Example
```java
// Import classes:
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.model.*;
import com.konfigthis.newscatcherapi.client.api.SearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://api.newscatcherapi.com/v2");
    
    // Configure API key authorization: api_key
    ApiKeyAuth api_key = (ApiKeyAuth) defaultClient.getAuthentication("api_key");
    api_key.setApiKey("YOUR API KEY");
    // Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
    //api_key.setApiKeyPrefix("Token");

    SearchApi apiInstance = new SearchApi(defaultClient);
    Search search = new Search(); // Search | 
    try {
      Model200Response result = apiInstance.post(search);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SearchApi#post");
      System.err.println("Status code: " + e.getCode());
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
| **search** | [**Search**](Search.md)|  | [optional] |

### Return type

[**Model200Response**](Model200Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | API is not put in headers |  -  |
| **401** | API Key not found |  -  |
| **406** | Wrong parameter has been used |  -  |
| **408** | Request Timeout |  -  |
| **429** | Concurrency violated |  -  |

