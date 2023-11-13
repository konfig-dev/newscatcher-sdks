# newscatcherapi_client.model.latest_headlines.LatestHeadlines

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
dict, frozendict.frozendict,  | frozendict.frozendict,  |  | 

### Dictionary Keys
Key | Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | ------------- | -------------
**when** | str,  | str,  | The time period you want to get the headlines for. Accpeted format: - &#x60;7d&#x60; -&gt; Daily form, last 7 days time period - &#x60;6h&#x60; -&gt; Hourly form, last six hours  | [optional] 
**lang** | str,  | str,  | The language you want to search in. | [optional] must be one of ["af", "ar", "bg", "bn", "ca", "cn", "cs", "cy", "da", "de", "el", "en", "es", "et", "fa", "fi", "fr", "gu", "he", "hi", "hr", "hu", "id", "it", "ja", "kn", "ko", "lt", "lv", "mk", "ml", "mr", "ne", "nl", "false", "pa", "pl", "pt", "ro", "ru", "sk", "sl", "so", "sq", "sv", "sw", "ta", "te", "th", "tl", "tr", "tw", "uk", "ur", "vi", ] 
**countries** | str,  | str,  |  | [optional] 
**not_countries** | str,  | str,  |  | [optional] 
**topic** | str,  | str,  |  | [optional] must be one of ["news", "sport", "tech", "world", "finance", "politics", "business", "economics", "entertainment", "beauty", "travel", "music", "food", "science", "gaming", ] 
**sources** | str,  | str,  |  | [optional] 
**not_sources** | str,  | str,  |  | [optional] 
**ranked_only** | bool,  | BoolClass,  |  | [optional] 
**page_size** | decimal.Decimal, int,  | decimal.Decimal,  |  | [optional] 
**page** | decimal.Decimal, int,  | decimal.Decimal,  |  | [optional] 
**any_string_name** | dict, frozendict.frozendict, str, date, datetime, int, float, bool, decimal.Decimal, None, list, tuple, bytes, io.FileIO, io.BufferedReader | frozendict.frozendict, str, BoolClass, decimal.Decimal, NoneClass, tuple, bytes, FileIO | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

