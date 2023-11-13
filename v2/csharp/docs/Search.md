# Newscatcherapi.Net.Model.Search

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Q** | **string** | Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section of the docs for more examples and explanations. | [optional] 
**Lang** | **string** | The language you want to search in. | [optional] 
**NotLang** | **string** | Inverse to the lang parameter. | [optional] 
**PublishedDatePrecision** | **string** | Precision of the publication date. | [optional] 
**From** | **string** | YYYY/mm/dd From which point in time to start the search. The default timezone is UTC.  Defaults to the past week. | [optional] 
**To** | **string** | YYYY/mm/dd Until which point in time to search for. The default timezone is UTC. | [optional] 
**SearchIn** | **string** |  | [optional] 
**Countries** | **string** |  | [optional] 
**NotCountries** | **string** |  | [optional] 
**Topic** | **string** |  | [optional] 
**Sources** | **string** |  | [optional] 
**NotSources** | **string** |  | [optional] 
**RankedOnly** | **bool** |  | [optional] 
**FromRank** | **int** | &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | [optional] 
**ToRank** | **int** | &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | [optional] 
**SortBy** | **string** |  | [optional] 
**PageSize** | **int** |  | [optional] 
**Page** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

