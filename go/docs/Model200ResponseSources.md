# Model200ResponseSources

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | Pointer to **string** |  | [optional] 
**Sources** | Pointer to **[]string** |  | [optional] 
**UserInput** | Pointer to [**SourcesUserInput**](SourcesUserInput.md) |  | [optional] 

## Methods

### NewModel200ResponseSources

`func NewModel200ResponseSources() *Model200ResponseSources`

NewModel200ResponseSources instantiates a new Model200ResponseSources object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewModel200ResponseSourcesWithDefaults

`func NewModel200ResponseSourcesWithDefaults() *Model200ResponseSources`

NewModel200ResponseSourcesWithDefaults instantiates a new Model200ResponseSources object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetMessage

`func (o *Model200ResponseSources) GetMessage() string`

GetMessage returns the Message field if non-nil, zero value otherwise.

### GetMessageOk

`func (o *Model200ResponseSources) GetMessageOk() (*string, bool)`

GetMessageOk returns a tuple with the Message field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMessage

`func (o *Model200ResponseSources) SetMessage(v string)`

SetMessage sets Message field to given value.

### HasMessage

`func (o *Model200ResponseSources) HasMessage() bool`

HasMessage returns a boolean if a field has been set.

### GetSources

`func (o *Model200ResponseSources) GetSources() []string`

GetSources returns the Sources field if non-nil, zero value otherwise.

### GetSourcesOk

`func (o *Model200ResponseSources) GetSourcesOk() (*[]string, bool)`

GetSourcesOk returns a tuple with the Sources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSources

`func (o *Model200ResponseSources) SetSources(v []string)`

SetSources sets Sources field to given value.

### HasSources

`func (o *Model200ResponseSources) HasSources() bool`

HasSources returns a boolean if a field has been set.

### SetSourcesNil

`func (o *Model200ResponseSources) SetSourcesNil(b bool)`

 SetSourcesNil sets the value for Sources to be an explicit nil

### UnsetSources
`func (o *Model200ResponseSources) UnsetSources()`

UnsetSources ensures that no value is present for Sources, not even an explicit nil
### GetUserInput

`func (o *Model200ResponseSources) GetUserInput() SourcesUserInput`

GetUserInput returns the UserInput field if non-nil, zero value otherwise.

### GetUserInputOk

`func (o *Model200ResponseSources) GetUserInputOk() (*SourcesUserInput, bool)`

GetUserInputOk returns a tuple with the UserInput field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetUserInput

`func (o *Model200ResponseSources) SetUserInput(v SourcesUserInput)`

SetUserInput sets UserInput field to given value.

### HasUserInput

`func (o *Model200ResponseSources) HasUserInput() bool`

HasUserInput returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


