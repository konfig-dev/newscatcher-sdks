# SearchUserInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Q** | Pointer to **string** |  | [optional] 
**SearchIn** | Pointer to **[]string** |  | [optional] 
**Lang** | Pointer to **[]string** |  | [optional] 
**NotLang** | Pointer to **[]string** |  | [optional] 
**Countries** | Pointer to **[]string** |  | [optional] 
**NotCountries** | Pointer to **[]string** |  | [optional] 
**From** | Pointer to **string** |  | [optional] 
**To** | Pointer to **NullableString** |  | [optional] 
**RankedOnly** | Pointer to **string** |  | [optional] 
**FromRank** | Pointer to **NullableInt32** |  | [optional] 
**ToRank** | Pointer to **NullableInt32** |  | [optional] 
**SortBy** | Pointer to **string** |  | [optional] 
**Page** | Pointer to **int32** |  | [optional] 
**Size** | Pointer to **int32** |  | [optional] 
**Sources** | Pointer to **[]string** |  | [optional] 
**NotSources** | Pointer to **[]string** |  | [optional] 
**Topic** | Pointer to **NullableString** |  | [optional] 
**PublishedDatePrecision** | Pointer to **NullableString** |  | [optional] 

## Methods

### NewSearchUserInput

`func NewSearchUserInput() *SearchUserInput`

NewSearchUserInput instantiates a new SearchUserInput object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSearchUserInputWithDefaults

`func NewSearchUserInputWithDefaults() *SearchUserInput`

NewSearchUserInputWithDefaults instantiates a new SearchUserInput object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQ

`func (o *SearchUserInput) GetQ() string`

GetQ returns the Q field if non-nil, zero value otherwise.

### GetQOk

`func (o *SearchUserInput) GetQOk() (*string, bool)`

GetQOk returns a tuple with the Q field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQ

`func (o *SearchUserInput) SetQ(v string)`

SetQ sets Q field to given value.

### HasQ

`func (o *SearchUserInput) HasQ() bool`

HasQ returns a boolean if a field has been set.

### GetSearchIn

`func (o *SearchUserInput) GetSearchIn() []string`

GetSearchIn returns the SearchIn field if non-nil, zero value otherwise.

### GetSearchInOk

`func (o *SearchUserInput) GetSearchInOk() (*[]string, bool)`

GetSearchInOk returns a tuple with the SearchIn field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSearchIn

`func (o *SearchUserInput) SetSearchIn(v []string)`

SetSearchIn sets SearchIn field to given value.

### HasSearchIn

`func (o *SearchUserInput) HasSearchIn() bool`

HasSearchIn returns a boolean if a field has been set.

### SetSearchInNil

`func (o *SearchUserInput) SetSearchInNil(b bool)`

 SetSearchInNil sets the value for SearchIn to be an explicit nil

### UnsetSearchIn
`func (o *SearchUserInput) UnsetSearchIn()`

UnsetSearchIn ensures that no value is present for SearchIn, not even an explicit nil
### GetLang

`func (o *SearchUserInput) GetLang() []string`

GetLang returns the Lang field if non-nil, zero value otherwise.

### GetLangOk

`func (o *SearchUserInput) GetLangOk() (*[]string, bool)`

GetLangOk returns a tuple with the Lang field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLang

`func (o *SearchUserInput) SetLang(v []string)`

SetLang sets Lang field to given value.

### HasLang

`func (o *SearchUserInput) HasLang() bool`

HasLang returns a boolean if a field has been set.

### SetLangNil

`func (o *SearchUserInput) SetLangNil(b bool)`

 SetLangNil sets the value for Lang to be an explicit nil

### UnsetLang
`func (o *SearchUserInput) UnsetLang()`

UnsetLang ensures that no value is present for Lang, not even an explicit nil
### GetNotLang

`func (o *SearchUserInput) GetNotLang() []string`

GetNotLang returns the NotLang field if non-nil, zero value otherwise.

### GetNotLangOk

`func (o *SearchUserInput) GetNotLangOk() (*[]string, bool)`

GetNotLangOk returns a tuple with the NotLang field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotLang

`func (o *SearchUserInput) SetNotLang(v []string)`

SetNotLang sets NotLang field to given value.

### HasNotLang

`func (o *SearchUserInput) HasNotLang() bool`

HasNotLang returns a boolean if a field has been set.

### SetNotLangNil

`func (o *SearchUserInput) SetNotLangNil(b bool)`

 SetNotLangNil sets the value for NotLang to be an explicit nil

### UnsetNotLang
`func (o *SearchUserInput) UnsetNotLang()`

UnsetNotLang ensures that no value is present for NotLang, not even an explicit nil
### GetCountries

`func (o *SearchUserInput) GetCountries() []string`

GetCountries returns the Countries field if non-nil, zero value otherwise.

### GetCountriesOk

`func (o *SearchUserInput) GetCountriesOk() (*[]string, bool)`

GetCountriesOk returns a tuple with the Countries field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCountries

`func (o *SearchUserInput) SetCountries(v []string)`

SetCountries sets Countries field to given value.

### HasCountries

`func (o *SearchUserInput) HasCountries() bool`

HasCountries returns a boolean if a field has been set.

### SetCountriesNil

`func (o *SearchUserInput) SetCountriesNil(b bool)`

 SetCountriesNil sets the value for Countries to be an explicit nil

### UnsetCountries
`func (o *SearchUserInput) UnsetCountries()`

UnsetCountries ensures that no value is present for Countries, not even an explicit nil
### GetNotCountries

`func (o *SearchUserInput) GetNotCountries() []string`

GetNotCountries returns the NotCountries field if non-nil, zero value otherwise.

### GetNotCountriesOk

`func (o *SearchUserInput) GetNotCountriesOk() (*[]string, bool)`

GetNotCountriesOk returns a tuple with the NotCountries field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotCountries

`func (o *SearchUserInput) SetNotCountries(v []string)`

SetNotCountries sets NotCountries field to given value.

### HasNotCountries

`func (o *SearchUserInput) HasNotCountries() bool`

HasNotCountries returns a boolean if a field has been set.

### SetNotCountriesNil

`func (o *SearchUserInput) SetNotCountriesNil(b bool)`

 SetNotCountriesNil sets the value for NotCountries to be an explicit nil

### UnsetNotCountries
`func (o *SearchUserInput) UnsetNotCountries()`

UnsetNotCountries ensures that no value is present for NotCountries, not even an explicit nil
### GetFrom

`func (o *SearchUserInput) GetFrom() string`

GetFrom returns the From field if non-nil, zero value otherwise.

### GetFromOk

`func (o *SearchUserInput) GetFromOk() (*string, bool)`

GetFromOk returns a tuple with the From field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFrom

`func (o *SearchUserInput) SetFrom(v string)`

SetFrom sets From field to given value.

### HasFrom

`func (o *SearchUserInput) HasFrom() bool`

HasFrom returns a boolean if a field has been set.

### GetTo

`func (o *SearchUserInput) GetTo() string`

GetTo returns the To field if non-nil, zero value otherwise.

### GetToOk

`func (o *SearchUserInput) GetToOk() (*string, bool)`

GetToOk returns a tuple with the To field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTo

`func (o *SearchUserInput) SetTo(v string)`

SetTo sets To field to given value.

### HasTo

`func (o *SearchUserInput) HasTo() bool`

HasTo returns a boolean if a field has been set.

### SetToNil

`func (o *SearchUserInput) SetToNil(b bool)`

 SetToNil sets the value for To to be an explicit nil

### UnsetTo
`func (o *SearchUserInput) UnsetTo()`

UnsetTo ensures that no value is present for To, not even an explicit nil
### GetRankedOnly

`func (o *SearchUserInput) GetRankedOnly() string`

GetRankedOnly returns the RankedOnly field if non-nil, zero value otherwise.

### GetRankedOnlyOk

`func (o *SearchUserInput) GetRankedOnlyOk() (*string, bool)`

GetRankedOnlyOk returns a tuple with the RankedOnly field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRankedOnly

`func (o *SearchUserInput) SetRankedOnly(v string)`

SetRankedOnly sets RankedOnly field to given value.

### HasRankedOnly

`func (o *SearchUserInput) HasRankedOnly() bool`

HasRankedOnly returns a boolean if a field has been set.

### GetFromRank

`func (o *SearchUserInput) GetFromRank() int32`

GetFromRank returns the FromRank field if non-nil, zero value otherwise.

### GetFromRankOk

`func (o *SearchUserInput) GetFromRankOk() (*int32, bool)`

GetFromRankOk returns a tuple with the FromRank field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFromRank

`func (o *SearchUserInput) SetFromRank(v int32)`

SetFromRank sets FromRank field to given value.

### HasFromRank

`func (o *SearchUserInput) HasFromRank() bool`

HasFromRank returns a boolean if a field has been set.

### SetFromRankNil

`func (o *SearchUserInput) SetFromRankNil(b bool)`

 SetFromRankNil sets the value for FromRank to be an explicit nil

### UnsetFromRank
`func (o *SearchUserInput) UnsetFromRank()`

UnsetFromRank ensures that no value is present for FromRank, not even an explicit nil
### GetToRank

`func (o *SearchUserInput) GetToRank() int32`

GetToRank returns the ToRank field if non-nil, zero value otherwise.

### GetToRankOk

`func (o *SearchUserInput) GetToRankOk() (*int32, bool)`

GetToRankOk returns a tuple with the ToRank field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetToRank

`func (o *SearchUserInput) SetToRank(v int32)`

SetToRank sets ToRank field to given value.

### HasToRank

`func (o *SearchUserInput) HasToRank() bool`

HasToRank returns a boolean if a field has been set.

### SetToRankNil

`func (o *SearchUserInput) SetToRankNil(b bool)`

 SetToRankNil sets the value for ToRank to be an explicit nil

### UnsetToRank
`func (o *SearchUserInput) UnsetToRank()`

UnsetToRank ensures that no value is present for ToRank, not even an explicit nil
### GetSortBy

`func (o *SearchUserInput) GetSortBy() string`

GetSortBy returns the SortBy field if non-nil, zero value otherwise.

### GetSortByOk

`func (o *SearchUserInput) GetSortByOk() (*string, bool)`

GetSortByOk returns a tuple with the SortBy field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSortBy

`func (o *SearchUserInput) SetSortBy(v string)`

SetSortBy sets SortBy field to given value.

### HasSortBy

`func (o *SearchUserInput) HasSortBy() bool`

HasSortBy returns a boolean if a field has been set.

### GetPage

`func (o *SearchUserInput) GetPage() int32`

GetPage returns the Page field if non-nil, zero value otherwise.

### GetPageOk

`func (o *SearchUserInput) GetPageOk() (*int32, bool)`

GetPageOk returns a tuple with the Page field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPage

`func (o *SearchUserInput) SetPage(v int32)`

SetPage sets Page field to given value.

### HasPage

`func (o *SearchUserInput) HasPage() bool`

HasPage returns a boolean if a field has been set.

### GetSize

`func (o *SearchUserInput) GetSize() int32`

GetSize returns the Size field if non-nil, zero value otherwise.

### GetSizeOk

`func (o *SearchUserInput) GetSizeOk() (*int32, bool)`

GetSizeOk returns a tuple with the Size field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSize

`func (o *SearchUserInput) SetSize(v int32)`

SetSize sets Size field to given value.

### HasSize

`func (o *SearchUserInput) HasSize() bool`

HasSize returns a boolean if a field has been set.

### GetSources

`func (o *SearchUserInput) GetSources() []string`

GetSources returns the Sources field if non-nil, zero value otherwise.

### GetSourcesOk

`func (o *SearchUserInput) GetSourcesOk() (*[]string, bool)`

GetSourcesOk returns a tuple with the Sources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSources

`func (o *SearchUserInput) SetSources(v []string)`

SetSources sets Sources field to given value.

### HasSources

`func (o *SearchUserInput) HasSources() bool`

HasSources returns a boolean if a field has been set.

### SetSourcesNil

`func (o *SearchUserInput) SetSourcesNil(b bool)`

 SetSourcesNil sets the value for Sources to be an explicit nil

### UnsetSources
`func (o *SearchUserInput) UnsetSources()`

UnsetSources ensures that no value is present for Sources, not even an explicit nil
### GetNotSources

`func (o *SearchUserInput) GetNotSources() []string`

GetNotSources returns the NotSources field if non-nil, zero value otherwise.

### GetNotSourcesOk

`func (o *SearchUserInput) GetNotSourcesOk() (*[]string, bool)`

GetNotSourcesOk returns a tuple with the NotSources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNotSources

`func (o *SearchUserInput) SetNotSources(v []string)`

SetNotSources sets NotSources field to given value.

### HasNotSources

`func (o *SearchUserInput) HasNotSources() bool`

HasNotSources returns a boolean if a field has been set.

### SetNotSourcesNil

`func (o *SearchUserInput) SetNotSourcesNil(b bool)`

 SetNotSourcesNil sets the value for NotSources to be an explicit nil

### UnsetNotSources
`func (o *SearchUserInput) UnsetNotSources()`

UnsetNotSources ensures that no value is present for NotSources, not even an explicit nil
### GetTopic

`func (o *SearchUserInput) GetTopic() string`

GetTopic returns the Topic field if non-nil, zero value otherwise.

### GetTopicOk

`func (o *SearchUserInput) GetTopicOk() (*string, bool)`

GetTopicOk returns a tuple with the Topic field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTopic

`func (o *SearchUserInput) SetTopic(v string)`

SetTopic sets Topic field to given value.

### HasTopic

`func (o *SearchUserInput) HasTopic() bool`

HasTopic returns a boolean if a field has been set.

### SetTopicNil

`func (o *SearchUserInput) SetTopicNil(b bool)`

 SetTopicNil sets the value for Topic to be an explicit nil

### UnsetTopic
`func (o *SearchUserInput) UnsetTopic()`

UnsetTopic ensures that no value is present for Topic, not even an explicit nil
### GetPublishedDatePrecision

`func (o *SearchUserInput) GetPublishedDatePrecision() string`

GetPublishedDatePrecision returns the PublishedDatePrecision field if non-nil, zero value otherwise.

### GetPublishedDatePrecisionOk

`func (o *SearchUserInput) GetPublishedDatePrecisionOk() (*string, bool)`

GetPublishedDatePrecisionOk returns a tuple with the PublishedDatePrecision field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPublishedDatePrecision

`func (o *SearchUserInput) SetPublishedDatePrecision(v string)`

SetPublishedDatePrecision sets PublishedDatePrecision field to given value.

### HasPublishedDatePrecision

`func (o *SearchUserInput) HasPublishedDatePrecision() bool`

HasPublishedDatePrecision returns a boolean if a field has been set.

### SetPublishedDatePrecisionNil

`func (o *SearchUserInput) SetPublishedDatePrecisionNil(b bool)`

 SetPublishedDatePrecisionNil sets the value for PublishedDatePrecision to be an explicit nil

### UnsetPublishedDatePrecision
`func (o *SearchUserInput) UnsetPublishedDatePrecision()`

UnsetPublishedDatePrecision ensures that no value is present for PublishedDatePrecision, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


