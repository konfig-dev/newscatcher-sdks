# Model200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | Pointer to [**SuccessStatus**](SuccessStatus.md) |  | [optional] 
**TotalHits** | Pointer to **int32** |  | [optional] 
**Page** | Pointer to **int32** |  | [optional] 
**TotalPages** | Pointer to **int32** |  | [optional] 
**PageSize** | Pointer to **int32** |  | [optional] 
**Articles** | Pointer to [**[]ArticleInner**](ArticleInner.md) |  | [optional] 
**UserInput** | Pointer to [**SearchUserInput**](SearchUserInput.md) |  | [optional] 

## Methods

### NewModel200Response

`func NewModel200Response() *Model200Response`

NewModel200Response instantiates a new Model200Response object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewModel200ResponseWithDefaults

`func NewModel200ResponseWithDefaults() *Model200Response`

NewModel200ResponseWithDefaults instantiates a new Model200Response object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatus

`func (o *Model200Response) GetStatus() SuccessStatus`

GetStatus returns the Status field if non-nil, zero value otherwise.

### GetStatusOk

`func (o *Model200Response) GetStatusOk() (*SuccessStatus, bool)`

GetStatusOk returns a tuple with the Status field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatus

`func (o *Model200Response) SetStatus(v SuccessStatus)`

SetStatus sets Status field to given value.

### HasStatus

`func (o *Model200Response) HasStatus() bool`

HasStatus returns a boolean if a field has been set.

### GetTotalHits

`func (o *Model200Response) GetTotalHits() int32`

GetTotalHits returns the TotalHits field if non-nil, zero value otherwise.

### GetTotalHitsOk

`func (o *Model200Response) GetTotalHitsOk() (*int32, bool)`

GetTotalHitsOk returns a tuple with the TotalHits field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalHits

`func (o *Model200Response) SetTotalHits(v int32)`

SetTotalHits sets TotalHits field to given value.

### HasTotalHits

`func (o *Model200Response) HasTotalHits() bool`

HasTotalHits returns a boolean if a field has been set.

### GetPage

`func (o *Model200Response) GetPage() int32`

GetPage returns the Page field if non-nil, zero value otherwise.

### GetPageOk

`func (o *Model200Response) GetPageOk() (*int32, bool)`

GetPageOk returns a tuple with the Page field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPage

`func (o *Model200Response) SetPage(v int32)`

SetPage sets Page field to given value.

### HasPage

`func (o *Model200Response) HasPage() bool`

HasPage returns a boolean if a field has been set.

### GetTotalPages

`func (o *Model200Response) GetTotalPages() int32`

GetTotalPages returns the TotalPages field if non-nil, zero value otherwise.

### GetTotalPagesOk

`func (o *Model200Response) GetTotalPagesOk() (*int32, bool)`

GetTotalPagesOk returns a tuple with the TotalPages field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalPages

`func (o *Model200Response) SetTotalPages(v int32)`

SetTotalPages sets TotalPages field to given value.

### HasTotalPages

`func (o *Model200Response) HasTotalPages() bool`

HasTotalPages returns a boolean if a field has been set.

### GetPageSize

`func (o *Model200Response) GetPageSize() int32`

GetPageSize returns the PageSize field if non-nil, zero value otherwise.

### GetPageSizeOk

`func (o *Model200Response) GetPageSizeOk() (*int32, bool)`

GetPageSizeOk returns a tuple with the PageSize field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPageSize

`func (o *Model200Response) SetPageSize(v int32)`

SetPageSize sets PageSize field to given value.

### HasPageSize

`func (o *Model200Response) HasPageSize() bool`

HasPageSize returns a boolean if a field has been set.

### GetArticles

`func (o *Model200Response) GetArticles() []ArticleInner`

GetArticles returns the Articles field if non-nil, zero value otherwise.

### GetArticlesOk

`func (o *Model200Response) GetArticlesOk() (*[]ArticleInner, bool)`

GetArticlesOk returns a tuple with the Articles field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetArticles

`func (o *Model200Response) SetArticles(v []ArticleInner)`

SetArticles sets Articles field to given value.

### HasArticles

`func (o *Model200Response) HasArticles() bool`

HasArticles returns a boolean if a field has been set.

### GetUserInput

`func (o *Model200Response) GetUserInput() SearchUserInput`

GetUserInput returns the UserInput field if non-nil, zero value otherwise.

### GetUserInputOk

`func (o *Model200Response) GetUserInputOk() (*SearchUserInput, bool)`

GetUserInputOk returns a tuple with the UserInput field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetUserInput

`func (o *Model200Response) SetUserInput(v SearchUserInput)`

SetUserInput sets UserInput field to given value.

### HasUserInput

`func (o *Model200Response) HasUserInput() bool`

HasUserInput returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


