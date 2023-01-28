# Search


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**q** | **str** | Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section of the docs for more examples and explanations. | [optional] 
**lang** | **str** | The language you want to search in. | [optional] 
**not_lang** | **str** | Inverse to the lang parameter. | [optional] 
**published_date_precision** | **str** | Precision of the publication date. | [optional] 
**_from** | **str** | YYYY/mm/dd From which point in time to start the search. The default timezone is UTC.  Defaults to the past week. | [optional] 
**to** | **str** | YYYY/mm/dd Until which point in time to search for. The default timezone is UTC. | [optional] 
**search_in** | **str** |  | [optional] 
**countries** | **str** |  | [optional] 
**not_countries** | **str** |  | [optional] 
**topic** | **str** |  | [optional] 
**sources** | **str** |  | [optional] 
**not_sources** | **str** |  | [optional] 
**ranked_only** | **bool** |  | [optional] 
**from_rank** | **int** | &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | [optional] 
**to_rank** | **int** | &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | [optional] 
**sort_by** | **str** |  | [optional] 
**page_size** | **int** |  | [optional] 
**page** | **int** |  | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


