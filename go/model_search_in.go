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
	"fmt"
)

// SearchIn the model 'SearchIn'
type SearchIn string

// List of search_in
const (
	SEARCHIN_TITLE SearchIn = "title"
	SEARCHIN_SUMMARY SearchIn = "summary"
	SEARCHIN_TITLE_SUMMARY SearchIn = "title_summary"
)

// All allowed values of SearchIn enum
var AllowedSearchInEnumValues = []SearchIn{
	"title",
	"summary",
	"title_summary",
}

func (v *SearchIn) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := SearchIn(value)
	for _, existing := range AllowedSearchInEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid SearchIn", value)
}

// NewSearchInFromValue returns a pointer to a valid SearchIn
// for the value passed as argument, or an error if the value passed is not allowed by the enum
func NewSearchInFromValue(v string) (*SearchIn, error) {
	ev := SearchIn(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for SearchIn: valid values are %v", v, AllowedSearchInEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise
func (v SearchIn) IsValid() bool {
	for _, existing := range AllowedSearchInEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to search_in value
func (v SearchIn) Ptr() *SearchIn {
	return &v
}

type NullableSearchIn struct {
	value *SearchIn
	isSet bool
}

func (v NullableSearchIn) Get() *SearchIn {
	return v.value
}

func (v *NullableSearchIn) Set(val *SearchIn) {
	v.value = val
	v.isSet = true
}

func (v NullableSearchIn) IsSet() bool {
	return v.isSet
}

func (v *NullableSearchIn) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSearchIn(val *SearchIn) *NullableSearchIn {
	return &NullableSearchIn{value: val, isSet: true}
}

func (v NullableSearchIn) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSearchIn) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

