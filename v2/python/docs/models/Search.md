# newscatcherapi_client.model.search.Search

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
dict, frozendict.frozendict,  | frozendict.frozendict,  |  | 

### Dictionary Keys
Key | Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | ------------- | -------------
**q** | str,  | str,  | Keyword/keywords you&#x27;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section of the docs for more examples and explanations. | [optional] 
**lang** | str,  | str,  | The language you want to search in. | [optional] must be one of ["af", "ar", "bg", "bn", "ca", "cn", "cs", "cy", "da", "de", "el", "en", "es", "et", "fa", "fi", "fr", "gu", "he", "hi", "hr", "hu", "id", "it", "ja", "kn", "ko", "lt", "lv", "mk", "ml", "mr", "ne", "nl", "false", "pa", "pl", "pt", "ro", "ru", "sk", "sl", "so", "sq", "sv", "sw", "ta", "te", "th", "tl", "tr", "tw", "uk", "ur", "vi", ] 
**not_lang** | str,  | str,  | Inverse to the lang parameter. | [optional] must be one of ["af", "ar", "bg", "bn", "ca", "cn", "cs", "cy", "da", "de", "el", "en", "es", "et", "fa", "fi", "fr", "gu", "he", "hi", "hr", "hu", "id", "it", "ja", "kn", "ko", "lt", "lv", "mk", "ml", "mr", "ne", "nl", "false", "pa", "pl", "pt", "ro", "ru", "sk", "sl", "so", "sq", "sv", "sw", "ta", "te", "th", "tl", "tr", "tw", "uk", "ur", "vi", ] 
**published_date_precision** | str,  | str,  | Precision of the publication date. | [optional] must be one of ["full", "timezone unknown", "date", ] 
**from** | str,  | str,  | YYYY/mm/dd From which point in time to start the search. The default timezone is UTC.  Defaults to the past week. | [optional] 
**to** | str,  | str,  | YYYY/mm/dd Until which point in time to search for. The default timezone is UTC. | [optional] 
**search_in** | str,  | str,  |  | [optional] must be one of ["title", "summary", "title_summary", ] 
**countries** | str,  | str,  |  | [optional] 
**not_countries** | str,  | str,  |  | [optional] 
**topic** | str,  | str,  |  | [optional] must be one of ["news", "sport", "tech", "world", "finance", "politics", "business", "economics", "entertainment", "beauty", "travel", "music", "food", "science", "gaming", ] 
**sources** | str,  | str,  |  | [optional] 
**not_sources** | str,  | str,  |  | [optional] 
**ranked_only** | bool,  | BoolClass,  |  | [optional] 
**from_rank** | decimal.Decimal, int,  | decimal.Decimal,  | &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | [optional] 
**to_rank** | decimal.Decimal, int,  | decimal.Decimal,  | &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | [optional] 
**sort_by** | str,  | str,  |  | [optional] must be one of ["relevancy", "date", "rank", ] 
**page_size** | decimal.Decimal, int,  | decimal.Decimal,  |  | [optional] 
**page** | decimal.Decimal, int,  | decimal.Decimal,  |  | [optional] 
**any_string_name** | dict, frozendict.frozendict, str, date, datetime, int, float, bool, decimal.Decimal, None, list, tuple, bytes, io.FileIO, io.BufferedReader | frozendict.frozendict, str, BoolClass, decimal.Decimal, NoneClass, tuple, bytes, FileIO | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

