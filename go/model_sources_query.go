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

// SourcesQuery struct for SourcesQuery
type SourcesQuery struct {
	// The language you want to search in.
	Lang *string `json:"lang,omitempty"`
	Countries *string `json:"countries,omitempty"`
	Topic *string `json:"topic,omitempty"`
}

// NewSourcesQuery instantiates a new SourcesQuery object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSourcesQuery() *SourcesQuery {
	this := SourcesQuery{}
	return &this
}

// NewSourcesQueryWithDefaults instantiates a new SourcesQuery object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSourcesQueryWithDefaults() *SourcesQuery {
	this := SourcesQuery{}
	return &this
}

// GetLang returns the Lang field value if set, zero value otherwise.
func (o *SourcesQuery) GetLang() string {
	if o == nil || isNil(o.Lang) {
		var ret string
		return ret
	}
	return *o.Lang
}

// GetLangOk returns a tuple with the Lang field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SourcesQuery) GetLangOk() (*string, bool) {
	if o == nil || isNil(o.Lang) {
    return nil, false
	}
	return o.Lang, true
}

// HasLang returns a boolean if a field has been set.
func (o *SourcesQuery) HasLang() bool {
	if o != nil && !isNil(o.Lang) {
		return true
	}

	return false
}

// SetLang gets a reference to the given string and assigns it to the Lang field.
func (o *SourcesQuery) SetLang(v string) {
	o.Lang = &v
}

// GetCountries returns the Countries field value if set, zero value otherwise.
func (o *SourcesQuery) GetCountries() string {
	if o == nil || isNil(o.Countries) {
		var ret string
		return ret
	}
	return *o.Countries
}

// GetCountriesOk returns a tuple with the Countries field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SourcesQuery) GetCountriesOk() (*string, bool) {
	if o == nil || isNil(o.Countries) {
    return nil, false
	}
	return o.Countries, true
}

// HasCountries returns a boolean if a field has been set.
func (o *SourcesQuery) HasCountries() bool {
	if o != nil && !isNil(o.Countries) {
		return true
	}

	return false
}

// SetCountries gets a reference to the given string and assigns it to the Countries field.
func (o *SourcesQuery) SetCountries(v string) {
	o.Countries = &v
}

// GetTopic returns the Topic field value if set, zero value otherwise.
func (o *SourcesQuery) GetTopic() string {
	if o == nil || isNil(o.Topic) {
		var ret string
		return ret
	}
	return *o.Topic
}

// GetTopicOk returns a tuple with the Topic field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SourcesQuery) GetTopicOk() (*string, bool) {
	if o == nil || isNil(o.Topic) {
    return nil, false
	}
	return o.Topic, true
}

// HasTopic returns a boolean if a field has been set.
func (o *SourcesQuery) HasTopic() bool {
	if o != nil && !isNil(o.Topic) {
		return true
	}

	return false
}

// SetTopic gets a reference to the given string and assigns it to the Topic field.
func (o *SourcesQuery) SetTopic(v string) {
	o.Topic = &v
}

func (o SourcesQuery) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Lang) {
		toSerialize["lang"] = o.Lang
	}
	if !isNil(o.Countries) {
		toSerialize["countries"] = o.Countries
	}
	if !isNil(o.Topic) {
		toSerialize["topic"] = o.Topic
	}
	return json.Marshal(toSerialize)
}

type NullableSourcesQuery struct {
	value *SourcesQuery
	isSet bool
}

func (v NullableSourcesQuery) Get() *SourcesQuery {
	return v.value
}

func (v *NullableSourcesQuery) Set(val *SourcesQuery) {
	v.value = val
	v.isSet = true
}

func (v NullableSourcesQuery) IsSet() bool {
	return v.isSet
}

func (v *NullableSourcesQuery) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSourcesQuery(val *SourcesQuery) *NullableSourcesQuery {
	return &NullableSourcesQuery{value: val, isSet: true}
}

func (v NullableSourcesQuery) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSourcesQuery) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


