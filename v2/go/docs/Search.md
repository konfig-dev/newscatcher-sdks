# Search

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Q** | Pointer to **string** | Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section of the docs for more examples and explanations. | [optional] 
**Lang** | Pointer to **string** | The language you want to search in. | [optional] 
**NotLang** | Pointer to **string** | Inverse to the lang parameter. | [optional] 
**PublishedDatePrecision** | Pointer to **string** | Precision of the publication date. | [optional] 
**From** | Pointer to **string** | YYYY/mm/dd From which point in time to start the search. The default timezone is UTC.  Defaults to the past week. | [optional] 
**To** | Pointer to **string** | YYYY/mm/dd Until which point in time to search for. The default timezone is UTC. | [optional] 
**SearchIn** | Pointer to **string** |  | [optional] 
**Countries** | Pointer to **string** |  | [optional] 
**NotCountries** | Pointer to **string** |  | [optional] 
**Topic** | Pointer to **string** |  | [optional] 
**Sources** | Pointer to **string** |  | [optional] 
**NotSources** | Pointer to **string** |  | [optional] 
**RankedOnly** | Pointer to **bool** |  | [optional] 
**FromRank** | Pointer to **int32** | &#x60;[0:999999]&#x60; The lowest boundary of the rank of a news website to filter by. Important: lower rank means that a source is more popular  | [optional] 
**ToRank** | Pointer to **int32** | &#x60;[0:999999]&#x60; The upper boundary of the rank of a news website to filter by.  | [optional] 
**SortBy** | Pointer to **string** |  | [optional] 
**PageSize** | Pointer to **int32** |  | [optional] 
**Page** | Pointer to **int32** |  | [optional] 

## Methods

### NewSearch

`func NewSearch() *Search`

NewSearch instantiates a new Search object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSearchWithDefaults

`func NewSearchWithDefaults() *Search`

NewSearchWithDefaults instantiates a new Search object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQ

`func (o *Search) GetQ() string`

GetQ returns the Q field if non-nil, zero value otherwise.

### GetQOk

`func (o *Search) GetQOk() (*string, bool)`

GetQOk returns a tuple with the Q field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQ

`func (o *Search) SetQ(v string)`

SetQ sets Q field to given value.

### HasQ

`func (o *Search) HasQ() bool`

HasQ returns a boolean if a field has been set.

### GetLang

`func (o *Search) GetLang() string`

GetLang returns the Lang field if non-nil, zero value otherwise.

### GetLangOk

`func (o *Search) GetLangOk() (*string, bool)`

GetLangOk returns a tuple with the Lang field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLang

`func (o *Search) SetLang(v string)`

SetLang sets Lang field to given value.

### HasLang

`func (o *Search) HasLang() bool`

HasLang returns a boolean if a field has been set.

### GetNotLang

`func (o *Search) GetNotLang() string`

GetNotLang returns the NotLang field if non-nil, zero value otherwise.

### GetNotLangOk

`func (o *Search) GetNotLangOk() (*string, bool)`

GetNotLangOk returns a tuple with the NotLang field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotLang

`func (o *Search) SetNotLang(v string)`

SetNotLang sets NotLang field to given value.

### HasNotLang

`func (o *Search) HasNotLang() bool`

HasNotLang returns a boolean if a field has been set.

### GetPublishedDatePrecision

`func (o *Search) GetPublishedDatePrecision() string`

GetPublishedDatePrecision returns the PublishedDatePrecision field if non-nil, zero value otherwise.

### GetPublishedDatePrecisionOk

`func (o *Search) GetPublishedDatePrecisionOk() (*string, bool)`

GetPublishedDatePrecisionOk returns a tuple with the PublishedDatePrecision field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPublishedDatePrecision

`func (o *Search) SetPublishedDatePrecision(v string)`

SetPublishedDatePrecision sets PublishedDatePrecision field to given value.

### HasPublishedDatePrecision

`func (o *Search) HasPublishedDatePrecision() bool`

HasPublishedDatePrecision returns a boolean if a field has been set.

### GetFrom

`func (o *Search) GetFrom() string`

GetFrom returns the From field if non-nil, zero value otherwise.

### GetFromOk

`func (o *Search) GetFromOk() (*string, bool)`

GetFromOk returns a tuple with the From field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFrom

`func (o *Search) SetFrom(v string)`

SetFrom sets From field to given value.

### HasFrom

`func (o *Search) HasFrom() bool`

HasFrom returns a boolean if a field has been set.

### GetTo

`func (o *Search) GetTo() string`

GetTo returns the To field if non-nil, zero value otherwise.

### GetToOk

`func (o *Search) GetToOk() (*string, bool)`

GetToOk returns a tuple with the To field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTo

`func (o *Search) SetTo(v string)`

SetTo sets To field to given value.

### HasTo

`func (o *Search) HasTo() bool`

HasTo returns a boolean if a field has been set.

### GetSearchIn

`func (o *Search) GetSearchIn() string`

GetSearchIn returns the SearchIn field if non-nil, zero value otherwise.

### GetSearchInOk

`func (o *Search) GetSearchInOk() (*string, bool)`

GetSearchInOk returns a tuple with the SearchIn field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSearchIn

`func (o *Search) SetSearchIn(v string)`

SetSearchIn sets SearchIn field to given value.

### HasSearchIn

`func (o *Search) HasSearchIn() bool`

HasSearchIn returns a boolean if a field has been set.

### GetCountries

`func (o *Search) GetCountries() string`

GetCountries returns the Countries field if non-nil, zero value otherwise.

### GetCountriesOk

`func (o *Search) GetCountriesOk() (*string, bool)`

GetCountriesOk returns a tuple with the Countries field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCountries

`func (o *Search) SetCountries(v string)`

SetCountries sets Countries field to given value.

### HasCountries

`func (o *Search) HasCountries() bool`

HasCountries returns a boolean if a field has been set.

### GetNotCountries

`func (o *Search) GetNotCountries() string`

GetNotCountries returns the NotCountries field if non-nil, zero value otherwise.

### GetNotCountriesOk

`func (o *Search) GetNotCountriesOk() (*string, bool)`

GetNotCountriesOk returns a tuple with the NotCountries field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotCountries

`func (o *Search) SetNotCountries(v string)`

SetNotCountries sets NotCountries field to given value.

### HasNotCountries

`func (o *Search) HasNotCountries() bool`

HasNotCountries returns a boolean if a field has been set.

### GetTopic

`func (o *Search) GetTopic() string`

GetTopic returns the Topic field if non-nil, zero value otherwise.

### GetTopicOk

`func (o *Search) GetTopicOk() (*string, bool)`

GetTopicOk returns a tuple with the Topic field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTopic

`func (o *Search) SetTopic(v string)`

SetTopic sets Topic field to given value.

### HasTopic

`func (o *Search) HasTopic() bool`

HasTopic returns a boolean if a field has been set.

### GetSources

`func (o *Search) GetSources() string`

GetSources returns the Sources field if non-nil, zero value otherwise.

### GetSourcesOk

`func (o *Search) GetSourcesOk() (*string, bool)`

GetSourcesOk returns a tuple with the Sources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSources

`func (o *Search) SetSources(v string)`

SetSources sets Sources field to given value.

### HasSources

`func (o *Search) HasSources() bool`

HasSources returns a boolean if a field has been set.

### GetNotSources

`func (o *Search) GetNotSources() string`

GetNotSources returns the NotSources field if non-nil, zero value otherwise.

### GetNotSourcesOk

`func (o *Search) GetNotSourcesOk() (*string, bool)`

GetNotSourcesOk returns a tuple with the NotSources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotSources

`func (o *Search) SetNotSources(v string)`

SetNotSources sets NotSources field to given value.

### HasNotSources

`func (o *Search) HasNotSources() bool`

HasNotSources returns a boolean if a field has been set.

### GetRankedOnly

`func (o *Search) GetRankedOnly() bool`

GetRankedOnly returns the RankedOnly field if non-nil, zero value otherwise.

### GetRankedOnlyOk

`func (o *Search) GetRankedOnlyOk() (*bool, bool)`

GetRankedOnlyOk returns a tuple with the RankedOnly field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRankedOnly

`func (o *Search) SetRankedOnly(v bool)`

SetRankedOnly sets RankedOnly field to given value.

### HasRankedOnly

`func (o *Search) HasRankedOnly() bool`

HasRankedOnly returns a boolean if a field has been set.

### GetFromRank

`func (o *Search) GetFromRank() int32`

GetFromRank returns the FromRank field if non-nil, zero value otherwise.

### GetFromRankOk

`func (o *Search) GetFromRankOk() (*int32, bool)`

GetFromRankOk returns a tuple with the FromRank field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFromRank

`func (o *Search) SetFromRank(v int32)`

SetFromRank sets FromRank field to given value.

### HasFromRank

`func (o *Search) HasFromRank() bool`

HasFromRank returns a boolean if a field has been set.

### GetToRank

`func (o *Search) GetToRank() int32`

GetToRank returns the ToRank field if non-nil, zero value otherwise.

### GetToRankOk

`func (o *Search) GetToRankOk() (*int32, bool)`

GetToRankOk returns a tuple with the ToRank field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetToRank

`func (o *Search) SetToRank(v int32)`

SetToRank sets ToRank field to given value.

### HasToRank

`func (o *Search) HasToRank() bool`

HasToRank returns a boolean if a field has been set.

### GetSortBy

`func (o *Search) GetSortBy() string`

GetSortBy returns the SortBy field if non-nil, zero value otherwise.

### GetSortByOk

`func (o *Search) GetSortByOk() (*string, bool)`

GetSortByOk returns a tuple with the SortBy field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSortBy

`func (o *Search) SetSortBy(v string)`

SetSortBy sets SortBy field to given value.

### HasSortBy

`func (o *Search) HasSortBy() bool`

HasSortBy returns a boolean if a field has been set.

### GetPageSize

`func (o *Search) GetPageSize() int32`

GetPageSize returns the PageSize field if non-nil, zero value otherwise.

### GetPageSizeOk

`func (o *Search) GetPageSizeOk() (*int32, bool)`

GetPageSizeOk returns a tuple with the PageSize field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPageSize

`func (o *Search) SetPageSize(v int32)`

SetPageSize sets PageSize field to given value.

### HasPageSize

`func (o *Search) HasPageSize() bool`

HasPageSize returns a boolean if a field has been set.

### GetPage

`func (o *Search) GetPage() int32`

GetPage returns the Page field if non-nil, zero value otherwise.

### GetPageOk

`func (o *Search) GetPageOk() (*int32, bool)`

GetPageOk returns a tuple with the Page field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPage

`func (o *Search) SetPage(v int32)`

SetPage sets Page field to given value.

### HasPage

`func (o *Search) HasPage() bool`

HasPage returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


