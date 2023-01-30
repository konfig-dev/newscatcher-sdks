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

// SearchUserInput struct for SearchUserInput
type SearchUserInput struct {
	Q *string `json:"q,omitempty"`
	SearchIn []string `json:"search_in,omitempty"`
	Lang []string `json:"lang,omitempty"`
	NotLang []string `json:"not_lang,omitempty"`
	Countries []string `json:"countries,omitempty"`
	NotCountries []string `json:"not_countries,omitempty"`
	From *string `json:"from,omitempty"`
	To NullableString `json:"to,omitempty"`
	RankedOnly *string `json:"ranked_only,omitempty"`
	FromRank NullableInt32 `json:"from_rank,omitempty"`
	ToRank NullableInt32 `json:"to_rank,omitempty"`
	SortBy *string `json:"sort_by,omitempty"`
	Page *int32 `json:"page,omitempty"`
	Size *int32 `json:"size,omitempty"`
	Sources []string `json:"sources,omitempty"`
	NotSources []string `json:"not_sources,omitempty"`
	Topic NullableString `json:"topic,omitempty"`
	PublishedDatePrecision NullableString `json:"published_date_precision,omitempty"`
}

// NewSearchUserInput instantiates a new SearchUserInput object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSearchUserInput() *SearchUserInput {
	this := SearchUserInput{}
	return &this
}

// NewSearchUserInputWithDefaults instantiates a new SearchUserInput object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSearchUserInputWithDefaults() *SearchUserInput {
	this := SearchUserInput{}
	return &this
}

// GetQ returns the Q field value if set, zero value otherwise.
func (o *SearchUserInput) GetQ() string {
	if o == nil || isNil(o.Q) {
		var ret string
		return ret
	}
	return *o.Q
}

// GetQOk returns a tuple with the Q field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchUserInput) GetQOk() (*string, bool) {
	if o == nil || isNil(o.Q) {
    return nil, false
	}
	return o.Q, true
}

// HasQ returns a boolean if a field has been set.
func (o *SearchUserInput) HasQ() bool {
	if o != nil && !isNil(o.Q) {
		return true
	}

	return false
}

// SetQ gets a reference to the given string and assigns it to the Q field.
func (o *SearchUserInput) SetQ(v string) {
	o.Q = &v
}

// GetSearchIn returns the SearchIn field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetSearchIn() []string {
	if o == nil {
		var ret []string
		return ret
	}
	return o.SearchIn
}

// GetSearchInOk returns a tuple with the SearchIn field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetSearchInOk() ([]string, bool) {
	if o == nil || isNil(o.SearchIn) {
    return nil, false
	}
	return o.SearchIn, true
}

// HasSearchIn returns a boolean if a field has been set.
func (o *SearchUserInput) HasSearchIn() bool {
	if o != nil && isNil(o.SearchIn) {
		return true
	}

	return false
}

// SetSearchIn gets a reference to the given []string and assigns it to the SearchIn field.
func (o *SearchUserInput) SetSearchIn(v []string) {
	o.SearchIn = v
}

// GetLang returns the Lang field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetLang() []string {
	if o == nil {
		var ret []string
		return ret
	}
	return o.Lang
}

// GetLangOk returns a tuple with the Lang field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetLangOk() ([]string, bool) {
	if o == nil || isNil(o.Lang) {
    return nil, false
	}
	return o.Lang, true
}

// HasLang returns a boolean if a field has been set.
func (o *SearchUserInput) HasLang() bool {
	if o != nil && isNil(o.Lang) {
		return true
	}

	return false
}

// SetLang gets a reference to the given []string and assigns it to the Lang field.
func (o *SearchUserInput) SetLang(v []string) {
	o.Lang = v
}

// GetNotLang returns the NotLang field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetNotLang() []string {
	if o == nil {
		var ret []string
		return ret
	}
	return o.NotLang
}

// GetNotLangOk returns a tuple with the NotLang field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetNotLangOk() ([]string, bool) {
	if o == nil || isNil(o.NotLang) {
    return nil, false
	}
	return o.NotLang, true
}

// HasNotLang returns a boolean if a field has been set.
func (o *SearchUserInput) HasNotLang() bool {
	if o != nil && isNil(o.NotLang) {
		return true
	}

	return false
}

// SetNotLang gets a reference to the given []string and assigns it to the NotLang field.
func (o *SearchUserInput) SetNotLang(v []string) {
	o.NotLang = v
}

// GetCountries returns the Countries field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetCountries() []string {
	if o == nil {
		var ret []string
		return ret
	}
	return o.Countries
}

// GetCountriesOk returns a tuple with the Countries field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetCountriesOk() ([]string, bool) {
	if o == nil || isNil(o.Countries) {
    return nil, false
	}
	return o.Countries, true
}

// HasCountries returns a boolean if a field has been set.
func (o *SearchUserInput) HasCountries() bool {
	if o != nil && isNil(o.Countries) {
		return true
	}

	return false
}

// SetCountries gets a reference to the given []string and assigns it to the Countries field.
func (o *SearchUserInput) SetCountries(v []string) {
	o.Countries = v
}

// GetNotCountries returns the NotCountries field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetNotCountries() []string {
	if o == nil {
		var ret []string
		return ret
	}
	return o.NotCountries
}

// GetNotCountriesOk returns a tuple with the NotCountries field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetNotCountriesOk() ([]string, bool) {
	if o == nil || isNil(o.NotCountries) {
    return nil, false
	}
	return o.NotCountries, true
}

// HasNotCountries returns a boolean if a field has been set.
func (o *SearchUserInput) HasNotCountries() bool {
	if o != nil && isNil(o.NotCountries) {
		return true
	}

	return false
}

// SetNotCountries gets a reference to the given []string and assigns it to the NotCountries field.
func (o *SearchUserInput) SetNotCountries(v []string) {
	o.NotCountries = v
}

// GetFrom returns the From field value if set, zero value otherwise.
func (o *SearchUserInput) GetFrom() string {
	if o == nil || isNil(o.From) {
		var ret string
		return ret
	}
	return *o.From
}

// GetFromOk returns a tuple with the From field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchUserInput) GetFromOk() (*string, bool) {
	if o == nil || isNil(o.From) {
    return nil, false
	}
	return o.From, true
}

// HasFrom returns a boolean if a field has been set.
func (o *SearchUserInput) HasFrom() bool {
	if o != nil && !isNil(o.From) {
		return true
	}

	return false
}

// SetFrom gets a reference to the given string and assigns it to the From field.
func (o *SearchUserInput) SetFrom(v string) {
	o.From = &v
}

// GetTo returns the To field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetTo() string {
	if o == nil || isNil(o.To.Get()) {
		var ret string
		return ret
	}
	return *o.To.Get()
}

// GetToOk returns a tuple with the To field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetToOk() (*string, bool) {
	if o == nil {
    return nil, false
	}
	return o.To.Get(), o.To.IsSet()
}

// HasTo returns a boolean if a field has been set.
func (o *SearchUserInput) HasTo() bool {
	if o != nil && o.To.IsSet() {
		return true
	}

	return false
}

// SetTo gets a reference to the given NullableString and assigns it to the To field.
func (o *SearchUserInput) SetTo(v string) {
	o.To.Set(&v)
}
// SetToNil sets the value for To to be an explicit nil
func (o *SearchUserInput) SetToNil() {
	o.To.Set(nil)
}

// UnsetTo ensures that no value is present for To, not even an explicit nil
func (o *SearchUserInput) UnsetTo() {
	o.To.Unset()
}

// GetRankedOnly returns the RankedOnly field value if set, zero value otherwise.
func (o *SearchUserInput) GetRankedOnly() string {
	if o == nil || isNil(o.RankedOnly) {
		var ret string
		return ret
	}
	return *o.RankedOnly
}

// GetRankedOnlyOk returns a tuple with the RankedOnly field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchUserInput) GetRankedOnlyOk() (*string, bool) {
	if o == nil || isNil(o.RankedOnly) {
    return nil, false
	}
	return o.RankedOnly, true
}

// HasRankedOnly returns a boolean if a field has been set.
func (o *SearchUserInput) HasRankedOnly() bool {
	if o != nil && !isNil(o.RankedOnly) {
		return true
	}

	return false
}

// SetRankedOnly gets a reference to the given string and assigns it to the RankedOnly field.
func (o *SearchUserInput) SetRankedOnly(v string) {
	o.RankedOnly = &v
}

// GetFromRank returns the FromRank field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetFromRank() int32 {
	if o == nil || isNil(o.FromRank.Get()) {
		var ret int32
		return ret
	}
	return *o.FromRank.Get()
}

// GetFromRankOk returns a tuple with the FromRank field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetFromRankOk() (*int32, bool) {
	if o == nil {
    return nil, false
	}
	return o.FromRank.Get(), o.FromRank.IsSet()
}

// HasFromRank returns a boolean if a field has been set.
func (o *SearchUserInput) HasFromRank() bool {
	if o != nil && o.FromRank.IsSet() {
		return true
	}

	return false
}

// SetFromRank gets a reference to the given NullableInt32 and assigns it to the FromRank field.
func (o *SearchUserInput) SetFromRank(v int32) {
	o.FromRank.Set(&v)
}
// SetFromRankNil sets the value for FromRank to be an explicit nil
func (o *SearchUserInput) SetFromRankNil() {
	o.FromRank.Set(nil)
}

// UnsetFromRank ensures that no value is present for FromRank, not even an explicit nil
func (o *SearchUserInput) UnsetFromRank() {
	o.FromRank.Unset()
}

// GetToRank returns the ToRank field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetToRank() int32 {
	if o == nil || isNil(o.ToRank.Get()) {
		var ret int32
		return ret
	}
	return *o.ToRank.Get()
}

// GetToRankOk returns a tuple with the ToRank field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetToRankOk() (*int32, bool) {
	if o == nil {
    return nil, false
	}
	return o.ToRank.Get(), o.ToRank.IsSet()
}

// HasToRank returns a boolean if a field has been set.
func (o *SearchUserInput) HasToRank() bool {
	if o != nil && o.ToRank.IsSet() {
		return true
	}

	return false
}

// SetToRank gets a reference to the given NullableInt32 and assigns it to the ToRank field.
func (o *SearchUserInput) SetToRank(v int32) {
	o.ToRank.Set(&v)
}
// SetToRankNil sets the value for ToRank to be an explicit nil
func (o *SearchUserInput) SetToRankNil() {
	o.ToRank.Set(nil)
}

// UnsetToRank ensures that no value is present for ToRank, not even an explicit nil
func (o *SearchUserInput) UnsetToRank() {
	o.ToRank.Unset()
}

// GetSortBy returns the SortBy field value if set, zero value otherwise.
func (o *SearchUserInput) GetSortBy() string {
	if o == nil || isNil(o.SortBy) {
		var ret string
		return ret
	}
	return *o.SortBy
}

// GetSortByOk returns a tuple with the SortBy field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchUserInput) GetSortByOk() (*string, bool) {
	if o == nil || isNil(o.SortBy) {
    return nil, false
	}
	return o.SortBy, true
}

// HasSortBy returns a boolean if a field has been set.
func (o *SearchUserInput) HasSortBy() bool {
	if o != nil && !isNil(o.SortBy) {
		return true
	}

	return false
}

// SetSortBy gets a reference to the given string and assigns it to the SortBy field.
func (o *SearchUserInput) SetSortBy(v string) {
	o.SortBy = &v
}

// GetPage returns the Page field value if set, zero value otherwise.
func (o *SearchUserInput) GetPage() int32 {
	if o == nil || isNil(o.Page) {
		var ret int32
		return ret
	}
	return *o.Page
}

// GetPageOk returns a tuple with the Page field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchUserInput) GetPageOk() (*int32, bool) {
	if o == nil || isNil(o.Page) {
    return nil, false
	}
	return o.Page, true
}

// HasPage returns a boolean if a field has been set.
func (o *SearchUserInput) HasPage() bool {
	if o != nil && !isNil(o.Page) {
		return true
	}

	return false
}

// SetPage gets a reference to the given int32 and assigns it to the Page field.
func (o *SearchUserInput) SetPage(v int32) {
	o.Page = &v
}

// GetSize returns the Size field value if set, zero value otherwise.
func (o *SearchUserInput) GetSize() int32 {
	if o == nil || isNil(o.Size) {
		var ret int32
		return ret
	}
	return *o.Size
}

// GetSizeOk returns a tuple with the Size field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchUserInput) GetSizeOk() (*int32, bool) {
	if o == nil || isNil(o.Size) {
    return nil, false
	}
	return o.Size, true
}

// HasSize returns a boolean if a field has been set.
func (o *SearchUserInput) HasSize() bool {
	if o != nil && !isNil(o.Size) {
		return true
	}

	return false
}

// SetSize gets a reference to the given int32 and assigns it to the Size field.
func (o *SearchUserInput) SetSize(v int32) {
	o.Size = &v
}

// GetSources returns the Sources field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetSources() []string {
	if o == nil {
		var ret []string
		return ret
	}
	return o.Sources
}

// GetSourcesOk returns a tuple with the Sources field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetSourcesOk() ([]string, bool) {
	if o == nil || isNil(o.Sources) {
    return nil, false
	}
	return o.Sources, true
}

// HasSources returns a boolean if a field has been set.
func (o *SearchUserInput) HasSources() bool {
	if o != nil && isNil(o.Sources) {
		return true
	}

	return false
}

// SetSources gets a reference to the given []string and assigns it to the Sources field.
func (o *SearchUserInput) SetSources(v []string) {
	o.Sources = v
}

// GetNotSources returns the NotSources field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetNotSources() []string {
	if o == nil {
		var ret []string
		return ret
	}
	return o.NotSources
}

// GetNotSourcesOk returns a tuple with the NotSources field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetNotSourcesOk() ([]string, bool) {
	if o == nil || isNil(o.NotSources) {
    return nil, false
	}
	return o.NotSources, true
}

// HasNotSources returns a boolean if a field has been set.
func (o *SearchUserInput) HasNotSources() bool {
	if o != nil && isNil(o.NotSources) {
		return true
	}

	return false
}

// SetNotSources gets a reference to the given []string and assigns it to the NotSources field.
func (o *SearchUserInput) SetNotSources(v []string) {
	o.NotSources = v
}

// GetTopic returns the Topic field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetTopic() string {
	if o == nil || isNil(o.Topic.Get()) {
		var ret string
		return ret
	}
	return *o.Topic.Get()
}

// GetTopicOk returns a tuple with the Topic field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetTopicOk() (*string, bool) {
	if o == nil {
    return nil, false
	}
	return o.Topic.Get(), o.Topic.IsSet()
}

// HasTopic returns a boolean if a field has been set.
func (o *SearchUserInput) HasTopic() bool {
	if o != nil && o.Topic.IsSet() {
		return true
	}

	return false
}

// SetTopic gets a reference to the given NullableString and assigns it to the Topic field.
func (o *SearchUserInput) SetTopic(v string) {
	o.Topic.Set(&v)
}
// SetTopicNil sets the value for Topic to be an explicit nil
func (o *SearchUserInput) SetTopicNil() {
	o.Topic.Set(nil)
}

// UnsetTopic ensures that no value is present for Topic, not even an explicit nil
func (o *SearchUserInput) UnsetTopic() {
	o.Topic.Unset()
}

// GetPublishedDatePrecision returns the PublishedDatePrecision field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchUserInput) GetPublishedDatePrecision() string {
	if o == nil || isNil(o.PublishedDatePrecision.Get()) {
		var ret string
		return ret
	}
	return *o.PublishedDatePrecision.Get()
}

// GetPublishedDatePrecisionOk returns a tuple with the PublishedDatePrecision field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchUserInput) GetPublishedDatePrecisionOk() (*string, bool) {
	if o == nil {
    return nil, false
	}
	return o.PublishedDatePrecision.Get(), o.PublishedDatePrecision.IsSet()
}

// HasPublishedDatePrecision returns a boolean if a field has been set.
func (o *SearchUserInput) HasPublishedDatePrecision() bool {
	if o != nil && o.PublishedDatePrecision.IsSet() {
		return true
	}

	return false
}

// SetPublishedDatePrecision gets a reference to the given NullableString and assigns it to the PublishedDatePrecision field.
func (o *SearchUserInput) SetPublishedDatePrecision(v string) {
	o.PublishedDatePrecision.Set(&v)
}
// SetPublishedDatePrecisionNil sets the value for PublishedDatePrecision to be an explicit nil
func (o *SearchUserInput) SetPublishedDatePrecisionNil() {
	o.PublishedDatePrecision.Set(nil)
}

// UnsetPublishedDatePrecision ensures that no value is present for PublishedDatePrecision, not even an explicit nil
func (o *SearchUserInput) UnsetPublishedDatePrecision() {
	o.PublishedDatePrecision.Unset()
}

func (o SearchUserInput) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Q) {
		toSerialize["q"] = o.Q
	}
	if o.SearchIn != nil {
		toSerialize["search_in"] = o.SearchIn
	}
	if o.Lang != nil {
		toSerialize["lang"] = o.Lang
	}
	if o.NotLang != nil {
		toSerialize["not_lang"] = o.NotLang
	}
	if o.Countries != nil {
		toSerialize["countries"] = o.Countries
	}
	if o.NotCountries != nil {
		toSerialize["not_countries"] = o.NotCountries
	}
	if !isNil(o.From) {
		toSerialize["from"] = o.From
	}
	if o.To.IsSet() {
		toSerialize["to"] = o.To.Get()
	}
	if !isNil(o.RankedOnly) {
		toSerialize["ranked_only"] = o.RankedOnly
	}
	if o.FromRank.IsSet() {
		toSerialize["from_rank"] = o.FromRank.Get()
	}
	if o.ToRank.IsSet() {
		toSerialize["to_rank"] = o.ToRank.Get()
	}
	if !isNil(o.SortBy) {
		toSerialize["sort_by"] = o.SortBy
	}
	if !isNil(o.Page) {
		toSerialize["page"] = o.Page
	}
	if !isNil(o.Size) {
		toSerialize["size"] = o.Size
	}
	if o.Sources != nil {
		toSerialize["sources"] = o.Sources
	}
	if o.NotSources != nil {
		toSerialize["not_sources"] = o.NotSources
	}
	if o.Topic.IsSet() {
		toSerialize["topic"] = o.Topic.Get()
	}
	if o.PublishedDatePrecision.IsSet() {
		toSerialize["published_date_precision"] = o.PublishedDatePrecision.Get()
	}
	return json.Marshal(toSerialize)
}

type NullableSearchUserInput struct {
	value *SearchUserInput
	isSet bool
}

func (v NullableSearchUserInput) Get() *SearchUserInput {
	return v.value
}

func (v *NullableSearchUserInput) Set(val *SearchUserInput) {
	v.value = val
	v.isSet = true
}

func (v NullableSearchUserInput) IsSet() bool {
	return v.isSet
}

func (v *NullableSearchUserInput) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSearchUserInput(val *SearchUserInput) *NullableSearchUserInput {
	return &NullableSearchUserInput{value: val, isSet: true}
}

func (v NullableSearchUserInput) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSearchUserInput) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


