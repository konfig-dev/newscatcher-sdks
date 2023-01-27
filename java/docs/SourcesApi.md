# SourcesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get**](SourcesApi.md#get) | **GET** /sources | Get top news sources supported by NewsCatcher. |
| [**post**](SourcesApi.md#post) | **POST** /sources | Get top news sources supported by NewsCatcher. |


<a name="get"></a>
# **get**
> Model200ResponseSources get(lang, countries, topic)

Get top news sources supported by NewsCatcher.

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example
```java
// Import classes:
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.models.*;
import com.konfigthis.newscatcherapi.client.api.SourcesApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://api.newscatcherapi.com/v2");
    
    // Configure API key authorization: api_key
    ApiKeyAuth api_key = (ApiKeyAuth) defaultClient.getAuthentication("api_key");
    api_key.setApiKey("YOUR API KEY");
    // Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
    //api_key.setApiKeyPrefix("Token");

    SourcesApi apiInstance = new SourcesApi(defaultClient);
    String lang = "af"; // String | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code. 
    String countries = "countries_example"; // String | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US` 
    Topic topic = Topic.fromValue("news"); // Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label. 
    try {
      Model200ResponseSources result = apiInstance.get(lang, countries, topic);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SourcesApi#get");
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
| **lang** | **String**| Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | [optional] [enum: af, ar, bg, bn, ca, cn, cs, cy, da, de, el, en, es, et, fa, fi, fr, gu, he, hi, hr, hu, id, it, ja, kn, ko, lt, lv, mk, ml, mr, ne, nl, false, pa, pl, pt, ro, ru, sk, sl, so, sq, sv, sw, ta, te, th, tl, tr, tw, uk, ur, vi] |
| **countries** | **String**| Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | [optional] |
| **topic** | [**Topic**](.md)| Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | [optional] [enum: news, sport, tech, world, finance, politics, business, economics, entertainment, beauty, travel, music, food, science, gaming] |

### Return type

[**Model200ResponseSources**](Model200ResponseSources.md)

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
> Model200ResponseSources post(sourcesQuery)

Get top news sources supported by NewsCatcher.

Returns a list of the top 100 supported news websites. Overall, we support over 60,000 websites. Using this endpoint, you may find the top 100 for your specific language, country, topic combination.

### Example
```java
// Import classes:
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.auth.*;
import com.konfigthis.newscatcherapi.client.models.*;
import com.konfigthis.newscatcherapi.client.api.SourcesApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://api.newscatcherapi.com/v2");
    
    // Configure API key authorization: api_key
    ApiKeyAuth api_key = (ApiKeyAuth) defaultClient.getAuthentication("api_key");
    api_key.setApiKey("YOUR API KEY");
    // Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
    //api_key.setApiKeyPrefix("Token");

    SourcesApi apiInstance = new SourcesApi(defaultClient);
    SourcesQuery sourcesQuery = new SourcesQuery(); // SourcesQuery | 
    try {
      Model200ResponseSources result = apiInstance.post(sourcesQuery);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SourcesApi#post");
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
| **sourcesQuery** | [**SourcesQuery**](SourcesQuery.md)|  | [optional] |

### Return type

[**Model200ResponseSources**](Model200ResponseSources.md)

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

