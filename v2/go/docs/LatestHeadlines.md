# LatestHeadlines

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**When** | Pointer to **string** | The time period you want to get the headlines for. Accpeted format: - &#x60;7d&#x60; -&gt; Daily form, last 7 days time period - &#x60;6h&#x60; -&gt; Hourly form, last six hours  | [optional] 
**Lang** | Pointer to **string** | The language you want to search in. | [optional] 
**Countries** | Pointer to **string** |  | [optional] 
**NotCountries** | Pointer to **string** |  | [optional] 
**Topic** | Pointer to **string** |  | [optional] 
**Sources** | Pointer to **string** |  | [optional] 
**NotSources** | Pointer to **string** |  | [optional] 
**RankedOnly** | Pointer to **bool** |  | [optional] 
**PageSize** | Pointer to **int32** |  | [optional] 
**Page** | Pointer to **int32** |  | [optional] 

## Methods

### NewLatestHeadlines

`func NewLatestHeadlines() *LatestHeadlines`

NewLatestHeadlines instantiates a new LatestHeadlines object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewLatestHeadlinesWithDefaults

`func NewLatestHeadlinesWithDefaults() *LatestHeadlines`

NewLatestHeadlinesWithDefaults instantiates a new LatestHeadlines object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetWhen

`func (o *LatestHeadlines) GetWhen() string`

GetWhen returns the When field if non-nil, zero value otherwise.

### GetWhenOk

`func (o *LatestHeadlines) GetWhenOk() (*string, bool)`

GetWhenOk returns a tuple with the When field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetWhen

`func (o *LatestHeadlines) SetWhen(v string)`

SetWhen sets When field to given value.

### HasWhen

`func (o *LatestHeadlines) HasWhen() bool`

HasWhen returns a boolean if a field has been set.

### GetLang

`func (o *LatestHeadlines) GetLang() string`

GetLang returns the Lang field if non-nil, zero value otherwise.

### GetLangOk

`func (o *LatestHeadlines) GetLangOk() (*string, bool)`

GetLangOk returns a tuple with the Lang field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLang

`func (o *LatestHeadlines) SetLang(v string)`

SetLang sets Lang field to given value.

### HasLang

`func (o *LatestHeadlines) HasLang() bool`

HasLang returns a boolean if a field has been set.

### GetCountries

`func (o *LatestHeadlines) GetCountries() string`

GetCountries returns the Countries field if non-nil, zero value otherwise.

### GetCountriesOk

`func (o *LatestHeadlines) GetCountriesOk() (*string, bool)`

GetCountriesOk returns a tuple with the Countries field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCountries

`func (o *LatestHeadlines) SetCountries(v string)`

SetCountries sets Countries field to given value.

### HasCountries

`func (o *LatestHeadlines) HasCountries() bool`

HasCountries returns a boolean if a field has been set.

### GetNotCountries

`func (o *LatestHeadlines) GetNotCountries() string`

GetNotCountries returns the NotCountries field if non-nil, zero value otherwise.

### GetNotCountriesOk

`func (o *LatestHeadlines) GetNotCountriesOk() (*string, bool)`

GetNotCountriesOk returns a tuple with the NotCountries field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotCountries

`func (o *LatestHeadlines) SetNotCountries(v string)`

SetNotCountries sets NotCountries field to given value.

### HasNotCountries

`func (o *LatestHeadlines) HasNotCountries() bool`

HasNotCountries returns a boolean if a field has been set.

### GetTopic

`func (o *LatestHeadlines) GetTopic() string`

GetTopic returns the Topic field if non-nil, zero value otherwise.

### GetTopicOk

`func (o *LatestHeadlines) GetTopicOk() (*string, bool)`

GetTopicOk returns a tuple with the Topic field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTopic

`func (o *LatestHeadlines) SetTopic(v string)`

SetTopic sets Topic field to given value.

### HasTopic

`func (o *LatestHeadlines) HasTopic() bool`

HasTopic returns a boolean if a field has been set.

### GetSources

`func (o *LatestHeadlines) GetSources() string`

GetSources returns the Sources field if non-nil, zero value otherwise.

### GetSourcesOk

`func (o *LatestHeadlines) GetSourcesOk() (*string, bool)`

GetSourcesOk returns a tuple with the Sources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSources

`func (o *LatestHeadlines) SetSources(v string)`

SetSources sets Sources field to given value.

### HasSources

`func (o *LatestHeadlines) HasSources() bool`

HasSources returns a boolean if a field has been set.

### GetNotSources

`func (o *LatestHeadlines) GetNotSources() string`

GetNotSources returns the NotSources field if non-nil, zero value otherwise.

### GetNotSourcesOk

`func (o *LatestHeadlines) GetNotSourcesOk() (*string, bool)`

GetNotSourcesOk returns a tuple with the NotSources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotSources

`func (o *LatestHeadlines) SetNotSources(v string)`

SetNotSources sets NotSources field to given value.

### HasNotSources

`func (o *LatestHeadlines) HasNotSources() bool`

HasNotSources returns a boolean if a field has been set.

### GetRankedOnly

`func (o *LatestHeadlines) GetRankedOnly() bool`

GetRankedOnly returns the RankedOnly field if non-nil, zero value otherwise.

### GetRankedOnlyOk

`func (o *LatestHeadlines) GetRankedOnlyOk() (*bool, bool)`

GetRankedOnlyOk returns a tuple with the RankedOnly field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRankedOnly

`func (o *LatestHeadlines) SetRankedOnly(v bool)`

SetRankedOnly sets RankedOnly field to given value.

### HasRankedOnly

`func (o *LatestHeadlines) HasRankedOnly() bool`

HasRankedOnly returns a boolean if a field has been set.

### GetPageSize

`func (o *LatestHeadlines) GetPageSize() int32`

GetPageSize returns the PageSize field if non-nil, zero value otherwise.

### GetPageSizeOk

`func (o *LatestHeadlines) GetPageSizeOk() (*int32, bool)`

GetPageSizeOk returns a tuple with the PageSize field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPageSize

`func (o *LatestHeadlines) SetPageSize(v int32)`

SetPageSize sets PageSize field to given value.

### HasPageSize

`func (o *LatestHeadlines) HasPageSize() bool`

HasPageSize returns a boolean if a field has been set.

### GetPage

`func (o *LatestHeadlines) GetPage() int32`

GetPage returns the Page field if non-nil, zero value otherwise.

### GetPageOk

`func (o *LatestHeadlines) GetPageOk() (*int32, bool)`

GetPageOk returns a tuple with the Page field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPage

`func (o *LatestHeadlines) SetPage(v int32)`

SetPage sets Page field to given value.

### HasPage

`func (o *LatestHeadlines) HasPage() bool`

HasPage returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


