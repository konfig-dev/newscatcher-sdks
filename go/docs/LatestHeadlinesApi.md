# \LatestHeadlinesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](LatestHeadlinesApi.md#Get) | **Get** /latest_headlines | Get Latest News Articles
[**Post**](LatestHeadlinesApi.md#Post) | **Post** /latest_headlines | Get Latest News Articles



## Get

> Model200ResponseLatest Get(ctx).Lang(lang).NotLang(notLang).Countries(countries).NotCountries(notCountries).Topic(topic).Sources(sources).NotSources(notSources).RankedOnly(rankedOnly).PageSize(pageSize).Page(page).Execute()

Get Latest News Articles



### Example

```go
package main

import (
    "context"
    "fmt"
    "os"
    newscatcherapi "github.com/konfig-dev/newscatcher-sdks/go"
)

func main() {
    lang := "en" // string | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional)
    notLang := "notLang_example" // string | Inverse to the `lang` parameter  (optional)
    countries := "countries_example" // string | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional)
    notCountries := "notCountries_example" // string | The inverse of the `countries` parameter.  (optional)
    topic := newscatcherapi.topic("news") // Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional)
    sources := "sources_example" // string | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com`  (optional)
    notSources := "notSources_example" // string | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com`  (optional)
    rankedOnly := true // bool | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999`  (optional)
    pageSize := int32(56) // int32 | `[1:100]` How many articles to return per page.  (optional)
    page := int32(56) // int32 | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  (optional)

    configuration := newscatcherapi.NewConfiguration()
    apiClient := newscatcherapi.NewAPIClient(configuration)
    resp, r, err := apiClient.LatestHeadlinesApi.Get(context.Background()).Lang(lang).NotLang(notLang).Countries(countries).NotCountries(notCountries).Topic(topic).Sources(sources).NotSources(notSources).RankedOnly(rankedOnly).PageSize(pageSize).Page(page).Execute()
    if err != nil {
        fmt.Fprintf(os.Stderr, "Error when calling `LatestHeadlinesApi.Get``: %v\n", err)
        fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
    }
    // response from `Get`: Model200ResponseLatest
    fmt.Fprintf(os.Stdout, "Response from `LatestHeadlinesApi.Get`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiGetRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lang** | **string** | Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | 
 **notLang** | **string** | Inverse to the &#x60;lang&#x60; parameter  | 
 **countries** | **string** | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | 
 **notCountries** | **string** | The inverse of the &#x60;countries&#x60; parameter.  | 
 **topic** | [**Topic**](Topic.md) | Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | 
 **sources** | **string** | One or more news resources to filter your search. It should be the normal form of the URL, For example: &#x60;nytimes.com,theguardian.com&#x60;  | 
 **notSources** | **string** | One or more sources to be excluded from the search. Comma-separated list. For example: &#x60;nytimes.com,cnn.com,wsj.com&#x60;  | 
 **rankedOnly** | **bool** | Default: &#x60;True&#x60; Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals &#x60;999999&#x60;  | 
 **pageSize** | **int32** | &#x60;[1:100]&#x60; How many articles to return per page.  | 
 **page** | **int32** | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | 

### Return type

[**Model200ResponseLatest**](Model200ResponseLatest.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Post

> Model200ResponseLatest Post(ctx).LatestHeadlines(latestHeadlines).Execute()

Get Latest News Articles



### Example

```go
package main

import (
    "context"
    "fmt"
    "os"
    newscatcherapi "github.com/konfig-dev/newscatcher-sdks/go"
)

func main() {
    latestHeadlines := *newscatcherapi.NewLatestHeadlines() // LatestHeadlines |  (optional)

    configuration := newscatcherapi.NewConfiguration()
    apiClient := newscatcherapi.NewAPIClient(configuration)
    resp, r, err := apiClient.LatestHeadlinesApi.Post(context.Background()).LatestHeadlines(latestHeadlines).Execute()
    if err != nil {
        fmt.Fprintf(os.Stderr, "Error when calling `LatestHeadlinesApi.Post``: %v\n", err)
        fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
    }
    // response from `Post`: Model200ResponseLatest
    fmt.Fprintf(os.Stdout, "Response from `LatestHeadlinesApi.Post`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiPostRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latestHeadlines** | [**LatestHeadlines**](LatestHeadlines.md) |  | 

### Return type

[**Model200ResponseLatest**](Model200ResponseLatest.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

