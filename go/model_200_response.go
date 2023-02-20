/*
NewsCatcher News API V2

NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 

API version: 1.0.1
Contact: team@newscatcherapi.com
*/

// Code generated by Konfig (https://konfigthis.com); DO NOT EDIT.

package newscatcherapi

import (
	"encoding/json"
)

// Model200Response struct for Model200Response
type Model200Response struct {
	Status *SuccessStatus `json:"status,omitempty"`
	TotalHits *int32 `json:"total_hits,omitempty"`
	Page *int32 `json:"page,omitempty"`
	TotalPages *int32 `json:"total_pages,omitempty"`
	PageSize *int32 `json:"page_size,omitempty"`
	Articles []ArticleInner `json:"articles,omitempty"`
	UserInput *SearchUserInput `json:"user_input,omitempty"`
}

// NewModel200Response instantiates a new Model200Response object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewModel200Response() *Model200Response {
	this := Model200Response{}
	return &this
}

// NewModel200ResponseWithDefaults instantiates a new Model200Response object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewModel200ResponseWithDefaults() *Model200Response {
	this := Model200Response{}
	return &this
}

// GetStatus returns the Status field value if set, zero value otherwise.
func (o *Model200Response) GetStatus() SuccessStatus {
	if o == nil || isNil(o.Status) {
		var ret SuccessStatus
		return ret
	}
	return *o.Status
}

// GetStatusOk returns a tuple with the Status field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Model200Response) GetStatusOk() (*SuccessStatus, bool) {
	if o == nil || isNil(o.Status) {
    return nil, false
	}
	return o.Status, true
}

// HasStatus returns a boolean if a field has been set.
func (o *Model200Response) HasStatus() bool {
	if o != nil && !isNil(o.Status) {
		return true
	}

	return false
}

// SetStatus gets a reference to the given SuccessStatus and assigns it to the Status field.
func (o *Model200Response) SetStatus(v SuccessStatus) {
	o.Status = &v
}

// GetTotalHits returns the TotalHits field value if set, zero value otherwise.
func (o *Model200Response) GetTotalHits() int32 {
	if o == nil || isNil(o.TotalHits) {
		var ret int32
		return ret
	}
	return *o.TotalHits
}

// GetTotalHitsOk returns a tuple with the TotalHits field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Model200Response) GetTotalHitsOk() (*int32, bool) {
	if o == nil || isNil(o.TotalHits) {
    return nil, false
	}
	return o.TotalHits, true
}

// HasTotalHits returns a boolean if a field has been set.
func (o *Model200Response) HasTotalHits() bool {
	if o != nil && !isNil(o.TotalHits) {
		return true
	}

	return false
}

// SetTotalHits gets a reference to the given int32 and assigns it to the TotalHits field.
func (o *Model200Response) SetTotalHits(v int32) {
	o.TotalHits = &v
}

// GetPage returns the Page field value if set, zero value otherwise.
func (o *Model200Response) GetPage() int32 {
	if o == nil || isNil(o.Page) {
		var ret int32
		return ret
	}
	return *o.Page
}

// GetPageOk returns a tuple with the Page field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Model200Response) GetPageOk() (*int32, bool) {
	if o == nil || isNil(o.Page) {
    return nil, false
	}
	return o.Page, true
}

// HasPage returns a boolean if a field has been set.
func (o *Model200Response) HasPage() bool {
	if o != nil && !isNil(o.Page) {
		return true
	}

	return false
}

// SetPage gets a reference to the given int32 and assigns it to the Page field.
func (o *Model200Response) SetPage(v int32) {
	o.Page = &v
}

// GetTotalPages returns the TotalPages field value if set, zero value otherwise.
func (o *Model200Response) GetTotalPages() int32 {
	if o == nil || isNil(o.TotalPages) {
		var ret int32
		return ret
	}
	return *o.TotalPages
}

// GetTotalPagesOk returns a tuple with the TotalPages field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Model200Response) GetTotalPagesOk() (*int32, bool) {
	if o == nil || isNil(o.TotalPages) {
    return nil, false
	}
	return o.TotalPages, true
}

// HasTotalPages returns a boolean if a field has been set.
func (o *Model200Response) HasTotalPages() bool {
	if o != nil && !isNil(o.TotalPages) {
		return true
	}

	return false
}

// SetTotalPages gets a reference to the given int32 and assigns it to the TotalPages field.
func (o *Model200Response) SetTotalPages(v int32) {
	o.TotalPages = &v
}

// GetPageSize returns the PageSize field value if set, zero value otherwise.
func (o *Model200Response) GetPageSize() int32 {
	if o == nil || isNil(o.PageSize) {
		var ret int32
		return ret
	}
	return *o.PageSize
}

// GetPageSizeOk returns a tuple with the PageSize field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Model200Response) GetPageSizeOk() (*int32, bool) {
	if o == nil || isNil(o.PageSize) {
    return nil, false
	}
	return o.PageSize, true
}

// HasPageSize returns a boolean if a field has been set.
func (o *Model200Response) HasPageSize() bool {
	if o != nil && !isNil(o.PageSize) {
		return true
	}

	return false
}

// SetPageSize gets a reference to the given int32 and assigns it to the PageSize field.
func (o *Model200Response) SetPageSize(v int32) {
	o.PageSize = &v
}

// GetArticles returns the Articles field value if set, zero value otherwise.
func (o *Model200Response) GetArticles() []ArticleInner {
	if o == nil || isNil(o.Articles) {
		var ret []ArticleInner
		return ret
	}
	return o.Articles
}

// GetArticlesOk returns a tuple with the Articles field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Model200Response) GetArticlesOk() ([]ArticleInner, bool) {
	if o == nil || isNil(o.Articles) {
    return nil, false
	}
	return o.Articles, true
}

// HasArticles returns a boolean if a field has been set.
func (o *Model200Response) HasArticles() bool {
	if o != nil && !isNil(o.Articles) {
		return true
	}

	return false
}

// SetArticles gets a reference to the given []ArticleInner and assigns it to the Articles field.
func (o *Model200Response) SetArticles(v []ArticleInner) {
	o.Articles = v
}

// GetUserInput returns the UserInput field value if set, zero value otherwise.
func (o *Model200Response) GetUserInput() SearchUserInput {
	if o == nil || isNil(o.UserInput) {
		var ret SearchUserInput
		return ret
	}
	return *o.UserInput
}

// GetUserInputOk returns a tuple with the UserInput field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Model200Response) GetUserInputOk() (*SearchUserInput, bool) {
	if o == nil || isNil(o.UserInput) {
    return nil, false
	}
	return o.UserInput, true
}

// HasUserInput returns a boolean if a field has been set.
func (o *Model200Response) HasUserInput() bool {
	if o != nil && !isNil(o.UserInput) {
		return true
	}

	return false
}

// SetUserInput gets a reference to the given SearchUserInput and assigns it to the UserInput field.
func (o *Model200Response) SetUserInput(v SearchUserInput) {
	o.UserInput = &v
}

func (o Model200Response) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Status) {
		toSerialize["status"] = o.Status
	}
	if !isNil(o.TotalHits) {
		toSerialize["total_hits"] = o.TotalHits
	}
	if !isNil(o.Page) {
		toSerialize["page"] = o.Page
	}
	if !isNil(o.TotalPages) {
		toSerialize["total_pages"] = o.TotalPages
	}
	if !isNil(o.PageSize) {
		toSerialize["page_size"] = o.PageSize
	}
	if !isNil(o.Articles) {
		toSerialize["articles"] = o.Articles
	}
	if !isNil(o.UserInput) {
		toSerialize["user_input"] = o.UserInput
	}
	return json.Marshal(toSerialize)
}

type NullableModel200Response struct {
	value *Model200Response
	isSet bool
}

func (v NullableModel200Response) Get() *Model200Response {
	return v.value
}

func (v *NullableModel200Response) Set(val *Model200Response) {
	v.value = val
	v.isSet = true
}

func (v NullableModel200Response) IsSet() bool {
	return v.isSet
}

func (v *NullableModel200Response) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableModel200Response(val *Model200Response) *NullableModel200Response {
	return &NullableModel200Response{value: val, isSet: true}
}

func (v NullableModel200Response) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableModel200Response) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

