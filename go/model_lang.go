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

// Lang the model 'Lang'
type Lang string

// List of lang
const (
	LANG_AF Lang = "af"
	LANG_AR Lang = "ar"
	LANG_BG Lang = "bg"
	LANG_BN Lang = "bn"
	LANG_CA Lang = "ca"
	LANG_CN Lang = "cn"
	LANG_CS Lang = "cs"
	LANG_CY Lang = "cy"
	LANG_DA Lang = "da"
	LANG_DE Lang = "de"
	LANG_EL Lang = "el"
	LANG_EN Lang = "en"
	LANG_ES Lang = "es"
	LANG_ET Lang = "et"
	LANG_FA Lang = "fa"
	LANG_FI Lang = "fi"
	LANG_FR Lang = "fr"
	LANG_GU Lang = "gu"
	LANG_HE Lang = "he"
	LANG_HI Lang = "hi"
	LANG_HR Lang = "hr"
	LANG_HU Lang = "hu"
	LANG_ID Lang = "id"
	LANG_IT Lang = "it"
	LANG_JA Lang = "ja"
	LANG_KN Lang = "kn"
	LANG_KO Lang = "ko"
	LANG_LT Lang = "lt"
	LANG_LV Lang = "lv"
	LANG_MK Lang = "mk"
	LANG_ML Lang = "ml"
	LANG_MR Lang = "mr"
	LANG_NE Lang = "ne"
	LANG_NL Lang = "nl"
	LANG_FALSE Lang = "false"
	LANG_PA Lang = "pa"
	LANG_PL Lang = "pl"
	LANG_PT Lang = "pt"
	LANG_RO Lang = "ro"
	LANG_RU Lang = "ru"
	LANG_SK Lang = "sk"
	LANG_SL Lang = "sl"
	LANG_SO Lang = "so"
	LANG_SQ Lang = "sq"
	LANG_SV Lang = "sv"
	LANG_SW Lang = "sw"
	LANG_TA Lang = "ta"
	LANG_TE Lang = "te"
	LANG_TH Lang = "th"
	LANG_TL Lang = "tl"
	LANG_TR Lang = "tr"
	LANG_TW Lang = "tw"
	LANG_UK Lang = "uk"
	LANG_UR Lang = "ur"
	LANG_VI Lang = "vi"
)

// All allowed values of Lang enum
var AllowedLangEnumValues = []Lang{
	"af",
	"ar",
	"bg",
	"bn",
	"ca",
	"cn",
	"cs",
	"cy",
	"da",
	"de",
	"el",
	"en",
	"es",
	"et",
	"fa",
	"fi",
	"fr",
	"gu",
	"he",
	"hi",
	"hr",
	"hu",
	"id",
	"it",
	"ja",
	"kn",
	"ko",
	"lt",
	"lv",
	"mk",
	"ml",
	"mr",
	"ne",
	"nl",
	"false",
	"pa",
	"pl",
	"pt",
	"ro",
	"ru",
	"sk",
	"sl",
	"so",
	"sq",
	"sv",
	"sw",
	"ta",
	"te",
	"th",
	"tl",
	"tr",
	"tw",
	"uk",
	"ur",
	"vi",
}

func (v *Lang) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := Lang(value)
	for _, existing := range AllowedLangEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid Lang", value)
}

// NewLangFromValue returns a pointer to a valid Lang
// for the value passed as argument, or an error if the value passed is not allowed by the enum
func NewLangFromValue(v string) (*Lang, error) {
	ev := Lang(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for Lang: valid values are %v", v, AllowedLangEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise
func (v Lang) IsValid() bool {
	for _, existing := range AllowedLangEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to lang value
func (v Lang) Ptr() *Lang {
	return &v
}

type NullableLang struct {
	value *Lang
	isSet bool
}

func (v NullableLang) Get() *Lang {
	return v.value
}

func (v *NullableLang) Set(val *Lang) {
	v.value = val
	v.isSet = true
}

func (v NullableLang) IsSet() bool {
	return v.isSet
}

func (v *NullableLang) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableLang(val *Lang) *NullableLang {
	return &NullableLang{value: val, isSet: true}
}

func (v NullableLang) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableLang) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

