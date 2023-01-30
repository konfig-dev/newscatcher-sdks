# \SearchApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](SearchApi.md#Get) | **Get** /search | Search for specific news articles
[**Post**](SearchApi.md#Post) | **Post** /search | Search for specific news articles



## Get

> Model200Response Get(ctx).Q(q).Lang(lang).NotLang(notLang).PublishedDatePrecision(publishedDatePrecision).From(from).To(to).SearchIn(searchIn).Countries(countries).NotCountries(notCountries).Topic(topic).Sources(sources).NotSources(notSources).RankedOnly(rankedOnly).FromRank(fromRank).ToRank(toRank).SortBy(sortBy).PageSize(pageSize).Page(page).Execute()

Search for specific news articles



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
    q := ""Elon Musk"" // string | Keyword/keywords you're searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations 
    lang := "en" // string | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional)
    notLang := "notLang_example" // string | Inverse to the `lang` parameter  (optional)
    publishedDatePrecision := newscatcherapi.publish_date_precision("full") // PublishDatePrecision | There are 3 types of date precision we define: `full` — day and time of an article is correctly identified with the appropriate timezone `timezone unknown` — day and time of an article is correctly identified without timezone `date` — only the day is identified without an exact time  (optional)
    from := "from_example" // string | `YYYY/mm/dd` From which point in time to start the search. The default timezone is UTC. Defaults to the past week.  (optional)
    to := "to_example" // string | `YYYY/mm/dd` Until which point in time to search for. The default timezone is UTC.  (optional)
    searchIn := newscatcherapi.search_in("title") // SearchIn | By default, we search what you specified in the `q` parameter in both `title` and `summary` of the article. However, you can limit this to either `title` or `summary`  (optional)
    countries := "countries_example" // string | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional)
    notCountries := "notCountries_example" // string | The inverse of the `countries` parameter.  (optional)
    topic := newscatcherapi.topic("news") // Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional)
    sources := "sources_example" // string | One or more news resources to filter your search. It should be the normal form of the URL, For example: `nytimes.com,theguardian.com`  (optional)
    notSources := "notSources_example" // string | One or more sources to be excluded from the search. Comma-separated list. For example: `nytimes.com,cnn.com,wsj.com`  (optional)
    rankedOnly := true // bool | Default: `True` Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals `999999`  (optional)
    fromRank := int32(56) // int32 | `[0:999999]` The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  (optional)
    toRank := int32(56) // int32 | `[0:999999]` The upper boundary of the rank of a news website to filter by.  (optional)
    sortBy := newscatcherapi.sort_by("relevancy") // SortBy | `relevancy` (default value) — the most relevant results first `date` — the most recently published results first `rank` — the results from the highest-ranked sources first  (optional)
    pageSize := int32(56) // int32 | `[1:100]` How many articles to return per page.  (optional)
    page := int32(56) // int32 | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  (optional)

    configuration := newscatcherapi.NewConfiguration()
    apiClient := newscatcherapi.NewAPIClient(configuration)
    resp, r, err := apiClient.SearchApi.Get(context.Background()).Q(q).Lang(lang).NotLang(notLang).PublishedDatePrecision(publishedDatePrecision).From(from).To(to).SearchIn(searchIn).Countries(countries).NotCountries(notCountries).Topic(topic).Sources(sources).NotSources(notSources).RankedOnly(rankedOnly).FromRank(fromRank).ToRank(toRank).SortBy(sortBy).PageSize(pageSize).Page(page).Execute()
    if err != nil {
        fmt.Fprintf(os.Stderr, "Error when calling `SearchApi.Get``: %v\n", err)
        fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
    }
    // response from `Get`: Model200Response
    fmt.Fprintf(os.Stdout, "Response from `SearchApi.Get`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiGetRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string** | Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section below of the docs for more examples and explanations  | 
 **lang** | **string** | Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | 
 **notLang** | **string** | Inverse to the &#x60;lang&#x60; parameter  | 
 **publishedDatePrecision** | [**PublishDatePrecision**](PublishDatePrecision.md) | There are 3 types of date precision we define: &#x60;full&#x60; — day and time of an article is correctly identified with the appropriate timezone &#x60;timezone unknown&#x60; — day and time of an article is correctly identified without timezone &#x60;date&#x60; — only the day is identified without an exact time  | 
 **from** | **string** | &#x60;YYYY/mm/dd&#x60; From which point in time to start the search. The default timezone is UTC. Defaults to the past week.  | 
 **to** | **string** | &#x60;YYYY/mm/dd&#x60; Until which point in time to search for. The default timezone is UTC.  | 
 **searchIn** | [**SearchIn**](SearchIn.md) | By default, we search what you specified in the &#x60;q&#x60; parameter in both &#x60;title&#x60; and &#x60;summary&#x60; of the article. However, you can limit this to either &#x60;title&#x60; or &#x60;summary&#x60;  | 
 **countries** | **string** | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | 
 **notCountries** | **string** | The inverse of the &#x60;countries&#x60; parameter.  | 
 **topic** | [**Topic**](Topic.md) | Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | 
 **sources** | **string** | One or more news resources to filter your search. It should be the normal form of the URL, For example: &#x60;nytimes.com,theguardian.com&#x60;  | 
 **notSources** | **string** | One or more sources to be excluded from the search. Comma-separated list. For example: &#x60;nytimes.com,cnn.com,wsj.com&#x60;  | 
 **rankedOnly** | **bool** | Default: &#x60;True&#x60; Limit the search only for the sources which are in the top 1 million online websites. Unranked sources are assigned a rank that equals &#x60;999999&#x60;  | 
 **fromRank** | **int32** | &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | 
 **toRank** | **int32** | &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | 
 **sortBy** | [**SortBy**](SortBy.md) | &#x60;relevancy&#x60; (default value) — the most relevant results first &#x60;date&#x60; — the most recently published results first &#x60;rank&#x60; — the results from the highest-ranked sources first  | 
 **pageSize** | **int32** | &#x60;[1:100]&#x60; How many articles to return per page.  | 
 **page** | **int32** | The number of the page. Use it to scroll through the results. This parameter is used to paginate: scroll through results because one API response cannot return more than 100 articles.  | 

### Return type

[**Model200Response**](Model200Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Post

> Model200Response Post(ctx).Search(search).Execute()

Search for specific news articles



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
    search := *newscatcherapi.NewSearch() // Search |  (optional)

    configuration := newscatcherapi.NewConfiguration()
    apiClient := newscatcherapi.NewAPIClient(configuration)
    resp, r, err := apiClient.SearchApi.Post(context.Background()).Search(search).Execute()
    if err != nil {
        fmt.Fprintf(os.Stderr, "Error when calling `SearchApi.Post``: %v\n", err)
        fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
    }
    // response from `Post`: Model200Response
    fmt.Fprintf(os.Stdout, "Response from `SearchApi.Post`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiPostRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | [**Search**](Search.md) |  | 

### Return type

[**Model200Response**](Model200Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

