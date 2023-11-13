# Model200ResponseLatest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | Pointer to [**SuccessStatus**](SuccessStatus.md) |  | [optional] 
**TotalHits** | Pointer to **int32** |  | [optional] 
**Page** | Pointer to **int32** |  | [optional] 
**TotalPages** | Pointer to **int32** |  | [optional] 
**PageSize** | Pointer to **int32** |  | [optional] 
**Articles** | Pointer to [**[]ArticleInner**](ArticleInner.md) |  | [optional] 
**UserInput** | Pointer to [**LatestHeadlinesUserInput**](LatestHeadlinesUserInput.md) |  | [optional] 

## Methods

### NewModel200ResponseLatest

`func NewModel200ResponseLatest() *Model200ResponseLatest`

NewModel200ResponseLatest instantiates a new Model200ResponseLatest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewModel200ResponseLatestWithDefaults

`func NewModel200ResponseLatestWithDefaults() *Model200ResponseLatest`

NewModel200ResponseLatestWithDefaults instantiates a new Model200ResponseLatest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatus

`func (o *Model200ResponseLatest) GetStatus() SuccessStatus`

GetStatus returns the Status field if non-nil, zero value otherwise.

### GetStatusOk

`func (o *Model200ResponseLatest) GetStatusOk() (*SuccessStatus, bool)`

GetStatusOk returns a tuple with the Status field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatus

`func (o *Model200ResponseLatest) SetStatus(v SuccessStatus)`

SetStatus sets Status field to given value.

### HasStatus

`func (o *Model200ResponseLatest) HasStatus() bool`

HasStatus returns a boolean if a field has been set.

### GetTotalHits

`func (o *Model200ResponseLatest) GetTotalHits() int32`

GetTotalHits returns the TotalHits field if non-nil, zero value otherwise.

### GetTotalHitsOk

`func (o *Model200ResponseLatest) GetTotalHitsOk() (*int32, bool)`

GetTotalHitsOk returns a tuple with the TotalHits field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalHits

`func (o *Model200ResponseLatest) SetTotalHits(v int32)`

SetTotalHits sets TotalHits field to given value.

### HasTotalHits

`func (o *Model200ResponseLatest) HasTotalHits() bool`

HasTotalHits returns a boolean if a field has been set.

### GetPage

`func (o *Model200ResponseLatest) GetPage() int32`

GetPage returns the Page field if non-nil, zero value otherwise.

### GetPageOk

`func (o *Model200ResponseLatest) GetPageOk() (*int32, bool)`

GetPageOk returns a tuple with the Page field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPage

`func (o *Model200ResponseLatest) SetPage(v int32)`

SetPage sets Page field to given value.

### HasPage

`func (o *Model200ResponseLatest) HasPage() bool`

HasPage returns a boolean if a field has been set.

### GetTotalPages

`func (o *Model200ResponseLatest) GetTotalPages() int32`

GetTotalPages returns the TotalPages field if non-nil, zero value otherwise.

### GetTotalPagesOk

`func (o *Model200ResponseLatest) GetTotalPagesOk() (*int32, bool)`

GetTotalPagesOk returns a tuple with the TotalPages field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalPages

`func (o *Model200ResponseLatest) SetTotalPages(v int32)`

SetTotalPages sets TotalPages field to given value.

### HasTotalPages

`func (o *Model200ResponseLatest) HasTotalPages() bool`

HasTotalPages returns a boolean if a field has been set.

### GetPageSize

`func (o *Model200ResponseLatest) GetPageSize() int32`

GetPageSize returns the PageSize field if non-nil, zero value otherwise.

### GetPageSizeOk

`func (o *Model200ResponseLatest) GetPageSizeOk() (*int32, bool)`

GetPageSizeOk returns a tuple with the PageSize field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPageSize

`func (o *Model200ResponseLatest) SetPageSize(v int32)`

SetPageSize sets PageSize field to given value.

### HasPageSize

`func (o *Model200ResponseLatest) HasPageSize() bool`

HasPageSize returns a boolean if a field has been set.

### GetArticles

`func (o *Model200ResponseLatest) GetArticles() []ArticleInner`

GetArticles returns the Articles field if non-nil, zero value otherwise.

### GetArticlesOk

`func (o *Model200ResponseLatest) GetArticlesOk() (*[]ArticleInner, bool)`

GetArticlesOk returns a tuple with the Articles field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetArticles

`func (o *Model200ResponseLatest) SetArticles(v []ArticleInner)`

SetArticles sets Articles field to given value.

### HasArticles

`func (o *Model200ResponseLatest) HasArticles() bool`

HasArticles returns a boolean if a field has been set.

### GetUserInput

`func (o *Model200ResponseLatest) GetUserInput() LatestHeadlinesUserInput`

GetUserInput returns the UserInput field if non-nil, zero value otherwise.

### GetUserInputOk

`func (o *Model200ResponseLatest) GetUserInputOk() (*LatestHeadlinesUserInput, bool)`

GetUserInputOk returns a tuple with the UserInput field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetUserInput

`func (o *Model200ResponseLatest) SetUserInput(v LatestHeadlinesUserInput)`

SetUserInput sets UserInput field to given value.

### HasUserInput

`func (o *Model200ResponseLatest) HasUserInput() bool`

HasUserInput returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


