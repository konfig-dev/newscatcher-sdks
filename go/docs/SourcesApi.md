# \SourcesApi

All URIs are relative to *https://api.newscatcherapi.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](SourcesApi.md#Get) | **Get** /sources | Get top news sources supported by NewsCatcher.
[**Post**](SourcesApi.md#Post) | **Post** /sources | Get top news sources supported by NewsCatcher.



## Get

> Model200ResponseSources Get(ctx).Lang(lang).Countries(countries).Topic(topic).Execute()

Get top news sources supported by NewsCatcher.



### Example

```go
package main

import (
    "context"
    "fmt"
    "os"
    openapiclient "./openapi"
)

func main() {
    lang := "en" // string | Specifies the languages of the search. For example: `en`. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  (optional)
    countries := "countries_example" // string | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, `US,CA,MX` or just `US`  (optional)
    topic := openapiclient.topic("news") // Topic | Accepted values: `news`, `sport`, `tech`, `world`, `finance`, `politics`, `business`, `economics`, `entertainment`, `beauty`, `travel`, `music`, `food`, `science`, `gaming` The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  (optional)

    configuration := openapiclient.NewConfiguration()
    apiClient := openapiclient.NewAPIClient(configuration)
    resp, r, err := apiClient.SourcesApi.Get(context.Background()).Lang(lang).Countries(countries).Topic(topic).Execute()
    if err != nil {
        fmt.Fprintf(os.Stderr, "Error when calling `SourcesApi.Get``: %v\n", err)
        fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
    }
    // response from `Get`: Model200ResponseSources
    fmt.Fprintf(os.Stdout, "Response from `SourcesApi.Get`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiGetRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lang** | **string** | Specifies the languages of the search. For example: &#x60;en&#x60;. The only accepted format is [ISO 639-1 — 2](https://en.wikipedia.org/wiki/ISO_639-1) letter code.  | 
 **countries** | **string** | Countries where the news publisher is located. **Important**: This parameter is not responsible for the countries mentioned in the news article. One or multiple countries can be used in the search. The only acceptable format is [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) For example, &#x60;US,CA,MX&#x60; or just &#x60;US&#x60;  | 
 **topic** | [**Topic**](Topic.md) | Accepted values: &#x60;news&#x60;, &#x60;sport&#x60;, &#x60;tech&#x60;, &#x60;world&#x60;, &#x60;finance&#x60;, &#x60;politics&#x60;, &#x60;business&#x60;, &#x60;economics&#x60;, &#x60;entertainment&#x60;, &#x60;beauty&#x60;, &#x60;travel&#x60;, &#x60;music&#x60;, &#x60;food&#x60;, &#x60;science&#x60;, &#x60;gaming&#x60; The topic to which you want to restrict the articles of your choice. Not all news articles are assigned with a topic, therefore, we cannot guarantee that 100% of topics talking about technology will be assigned a tech label.  | 

### Return type

[**Model200ResponseSources**](Model200ResponseSources.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Post

> Model200ResponseSources Post(ctx).SourcesQuery(sourcesQuery).Execute()

Get top news sources supported by NewsCatcher.



### Example

```go
package main

import (
    "context"
    "fmt"
    "os"
    openapiclient "./openapi"
)

func main() {
    sourcesQuery := *openapiclient.NewSourcesQuery() // SourcesQuery |  (optional)

    configuration := openapiclient.NewConfiguration()
    apiClient := openapiclient.NewAPIClient(configuration)
    resp, r, err := apiClient.SourcesApi.Post(context.Background()).SourcesQuery(sourcesQuery).Execute()
    if err != nil {
        fmt.Fprintf(os.Stderr, "Error when calling `SourcesApi.Post``: %v\n", err)
        fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
    }
    // response from `Post`: Model200ResponseSources
    fmt.Fprintf(os.Stdout, "Response from `SourcesApi.Post`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiPostRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourcesQuery** | [**SourcesQuery**](SourcesQuery.md) |  | 

### Return type

[**Model200ResponseSources**](Model200ResponseSources.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

