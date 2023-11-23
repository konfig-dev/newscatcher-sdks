/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

API version: Beta-3.0.0
Contact: maksym@newscatcherapi.com
*/

// Code generated by Konfig (https://konfigthis.com); DO NOT EDIT.

package newscatcherapi

import (
	"encoding/json"
)

// HTTPValidationError struct for HTTPValidationError
type HTTPValidationError struct {
	Detail []ValidationError `json:"detail,omitempty"`
}

// NewHTTPValidationError instantiates a new HTTPValidationError object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewHTTPValidationError() *HTTPValidationError {
	this := HTTPValidationError{}
	return &this
}

// NewHTTPValidationErrorWithDefaults instantiates a new HTTPValidationError object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewHTTPValidationErrorWithDefaults() *HTTPValidationError {
	this := HTTPValidationError{}
	return &this
}

// GetDetail returns the Detail field value if set, zero value otherwise.
func (o *HTTPValidationError) GetDetail() []ValidationError {
	if o == nil || isNil(o.Detail) {
		var ret []ValidationError
		return ret
	}
	return o.Detail
}

// GetDetailOk returns a tuple with the Detail field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *HTTPValidationError) GetDetailOk() ([]ValidationError, bool) {
	if o == nil || isNil(o.Detail) {
    return nil, false
	}
	return o.Detail, true
}

// HasDetail returns a boolean if a field has been set.
func (o *HTTPValidationError) HasDetail() bool {
	if o != nil && !isNil(o.Detail) {
		return true
	}

	return false
}

// SetDetail gets a reference to the given []ValidationError and assigns it to the Detail field.
func (o *HTTPValidationError) SetDetail(v []ValidationError) {
	o.Detail = v
}

func (o HTTPValidationError) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Detail) {
		toSerialize["detail"] = o.Detail
	}
	return json.Marshal(toSerialize)
}

type NullableHTTPValidationError struct {
	value *HTTPValidationError
	isSet bool
}

func (v NullableHTTPValidationError) Get() *HTTPValidationError {
	return v.value
}

func (v *NullableHTTPValidationError) Set(val *HTTPValidationError) {
	v.value = val
	v.isSet = true
}

func (v NullableHTTPValidationError) IsSet() bool {
	return v.isSet
}

func (v *NullableHTTPValidationError) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableHTTPValidationError(val *HTTPValidationError) *NullableHTTPValidationError {
	return &NullableHTTPValidationError{value: val, isSet: true}
}

func (v NullableHTTPValidationError) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableHTTPValidationError) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

