# newscatcherapi_client.model.latest_headlines_user_input.LatestHeadlinesUserInput

## Model Type Info
Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | -------------
dict, frozendict.frozendict,  | frozendict.frozendict,  |  | 

### Dictionary Keys
Key | Input Type | Accessed Type | Description | Notes
------------ | ------------- | ------------- | ------------- | -------------
**lang** | [**ModelList**](ModelList.md) | [**ModelList**](ModelList.md) |  | [optional] 
**not_lang** | [**ModelList**](ModelList.md) | [**ModelList**](ModelList.md) |  | [optional] 
**countries** | [**ModelList**](ModelList.md) | [**ModelList**](ModelList.md) |  | [optional] 
**not_countries** | [**ModelList**](ModelList.md) | [**ModelList**](ModelList.md) |  | [optional] 
**page** | decimal.Decimal, int,  | decimal.Decimal,  |  | [optional] 
**size** | decimal.Decimal, int,  | decimal.Decimal,  |  | [optional] 
**sources** | [**ModelList**](ModelList.md) | [**ModelList**](ModelList.md) |  | [optional] 
**not_sources** | [**ModelList**](ModelList.md) | [**ModelList**](ModelList.md) |  | [optional] 
**topic** | None, str,  | NoneClass, str,  |  | [optional] 
**any_string_name** | dict, frozendict.frozendict, str, date, datetime, int, float, bool, decimal.Decimal, None, list, tuple, bytes, io.FileIO, io.BufferedReader | frozendict.frozendict, str, BoolClass, decimal.Decimal, NoneClass, tuple, bytes, FileIO | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

