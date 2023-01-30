# ArticleInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | Pointer to **string** |  | [optional] 
**Author** | Pointer to **string** |  | [optional] 
**PublishedDate** | Pointer to **string** |  | [optional] 
**PublishedDatePrecision** | Pointer to **string** |  | [optional] 
**Link** | Pointer to **string** |  | [optional] 
**CleanUrl** | Pointer to **string** |  | [optional] 
**Excerpt** | Pointer to **NullableString** |  | [optional] 
**Summary** | Pointer to **string** |  | [optional] 
**Rights** | Pointer to **NullableString** |  | [optional] 
**Rank** | Pointer to **int32** |  | [optional] 
**Topic** | Pointer to **string** |  | [optional] 
**Country** | Pointer to **string** |  | [optional] 
**Language** | Pointer to **NullableString** |  | [optional] 
**Authors** | Pointer to **string** |  | [optional] 
**IsOpinion** | Pointer to **bool** |  | [optional] 
**TwitterAccount** | Pointer to **NullableString** |  | [optional] 
**Score** | Pointer to **NullableFloat32** |  | [optional] 
**Id** | Pointer to **string** |  | [optional] 

## Methods

### NewArticleInner

`func NewArticleInner() *ArticleInner`

NewArticleInner instantiates a new ArticleInner object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewArticleInnerWithDefaults

`func NewArticleInnerWithDefaults() *ArticleInner`

NewArticleInnerWithDefaults instantiates a new ArticleInner object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetTitle

`func (o *ArticleInner) GetTitle() string`

GetTitle returns the Title field if non-nil, zero value otherwise.

### GetTitleOk

`func (o *ArticleInner) GetTitleOk() (*string, bool)`

GetTitleOk returns a tuple with the Title field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTitle

`func (o *ArticleInner) SetTitle(v string)`

SetTitle sets Title field to given value.

### HasTitle

`func (o *ArticleInner) HasTitle() bool`

HasTitle returns a boolean if a field has been set.

### GetAuthor

`func (o *ArticleInner) GetAuthor() string`

GetAuthor returns the Author field if non-nil, zero value otherwise.

### GetAuthorOk

`func (o *ArticleInner) GetAuthorOk() (*string, bool)`

GetAuthorOk returns a tuple with the Author field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetAuthor

`func (o *ArticleInner) SetAuthor(v string)`

SetAuthor sets Author field to given value.

### HasAuthor

`func (o *ArticleInner) HasAuthor() bool`

HasAuthor returns a boolean if a field has been set.

### GetPublishedDate

`func (o *ArticleInner) GetPublishedDate() string`

GetPublishedDate returns the PublishedDate field if non-nil, zero value otherwise.

### GetPublishedDateOk

`func (o *ArticleInner) GetPublishedDateOk() (*string, bool)`

GetPublishedDateOk returns a tuple with the PublishedDate field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPublishedDate

`func (o *ArticleInner) SetPublishedDate(v string)`

SetPublishedDate sets PublishedDate field to given value.

### HasPublishedDate

`func (o *ArticleInner) HasPublishedDate() bool`

HasPublishedDate returns a boolean if a field has been set.

### GetPublishedDatePrecision

`func (o *ArticleInner) GetPublishedDatePrecision() string`

GetPublishedDatePrecision returns the PublishedDatePrecision field if non-nil, zero value otherwise.

### GetPublishedDatePrecisionOk

`func (o *ArticleInner) GetPublishedDatePrecisionOk() (*string, bool)`

GetPublishedDatePrecisionOk returns a tuple with the PublishedDatePrecision field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPublishedDatePrecision

`func (o *ArticleInner) SetPublishedDatePrecision(v string)`

SetPublishedDatePrecision sets PublishedDatePrecision field to given value.

### HasPublishedDatePrecision

`func (o *ArticleInner) HasPublishedDatePrecision() bool`

HasPublishedDatePrecision returns a boolean if a field has been set.

### GetLink

`func (o *ArticleInner) GetLink() string`

GetLink returns the Link field if non-nil, zero value otherwise.

### GetLinkOk

`func (o *ArticleInner) GetLinkOk() (*string, bool)`

GetLinkOk returns a tuple with the Link field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLink

`func (o *ArticleInner) SetLink(v string)`

SetLink sets Link field to given value.

### HasLink

`func (o *ArticleInner) HasLink() bool`

HasLink returns a boolean if a field has been set.

### GetCleanUrl

`func (o *ArticleInner) GetCleanUrl() string`

GetCleanUrl returns the CleanUrl field if non-nil, zero value otherwise.

### GetCleanUrlOk

`func (o *ArticleInner) GetCleanUrlOk() (*string, bool)`

GetCleanUrlOk returns a tuple with the CleanUrl field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCleanUrl

`func (o *ArticleInner) SetCleanUrl(v string)`

SetCleanUrl sets CleanUrl field to given value.

### HasCleanUrl

`func (o *ArticleInner) HasCleanUrl() bool`

HasCleanUrl returns a boolean if a field has been set.

### GetExcerpt

`func (o *ArticleInner) GetExcerpt() string`

GetExcerpt returns the Excerpt field if non-nil, zero value otherwise.

### GetExcerptOk

`func (o *ArticleInner) GetExcerptOk() (*string, bool)`

GetExcerptOk returns a tuple with the Excerpt field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetExcerpt

`func (o *ArticleInner) SetExcerpt(v string)`

SetExcerpt sets Excerpt field to given value.

### HasExcerpt

`func (o *ArticleInner) HasExcerpt() bool`

HasExcerpt returns a boolean if a field has been set.

### SetExcerptNil

`func (o *ArticleInner) SetExcerptNil(b bool)`

 SetExcerptNil sets the value for Excerpt to be an explicit nil

### UnsetExcerpt
`func (o *ArticleInner) UnsetExcerpt()`

UnsetExcerpt ensures that no value is present for Excerpt, not even an explicit nil
### GetSummary

`func (o *ArticleInner) GetSummary() string`

GetSummary returns the Summary field if non-nil, zero value otherwise.

### GetSummaryOk

`func (o *ArticleInner) GetSummaryOk() (*string, bool)`

GetSummaryOk returns a tuple with the Summary field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSummary

`func (o *ArticleInner) SetSummary(v string)`

SetSummary sets Summary field to given value.

### HasSummary

`func (o *ArticleInner) HasSummary() bool`

HasSummary returns a boolean if a field has been set.

### GetRights

`func (o *ArticleInner) GetRights() string`

GetRights returns the Rights field if non-nil, zero value otherwise.

### GetRightsOk

`func (o *ArticleInner) GetRightsOk() (*string, bool)`

GetRightsOk returns a tuple with the Rights field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRights

`func (o *ArticleInner) SetRights(v string)`

SetRights sets Rights field to given value.

### HasRights

`func (o *ArticleInner) HasRights() bool`

HasRights returns a boolean if a field has been set.

### SetRightsNil

`func (o *ArticleInner) SetRightsNil(b bool)`

 SetRightsNil sets the value for Rights to be an explicit nil

### UnsetRights
`func (o *ArticleInner) UnsetRights()`

UnsetRights ensures that no value is present for Rights, not even an explicit nil
### GetRank

`func (o *ArticleInner) GetRank() int32`

GetRank returns the Rank field if non-nil, zero value otherwise.

### GetRankOk

`func (o *ArticleInner) GetRankOk() (*int32, bool)`

GetRankOk returns a tuple with the Rank field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRank

`func (o *ArticleInner) SetRank(v int32)`

SetRank sets Rank field to given value.

### HasRank

`func (o *ArticleInner) HasRank() bool`

HasRank returns a boolean if a field has been set.

### GetTopic

`func (o *ArticleInner) GetTopic() string`

GetTopic returns the Topic field if non-nil, zero value otherwise.

### GetTopicOk

`func (o *ArticleInner) GetTopicOk() (*string, bool)`

GetTopicOk returns a tuple with the Topic field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTopic

`func (o *ArticleInner) SetTopic(v string)`

SetTopic sets Topic field to given value.

### HasTopic

`func (o *ArticleInner) HasTopic() bool`

HasTopic returns a boolean if a field has been set.

### GetCountry

`func (o *ArticleInner) GetCountry() string`

GetCountry returns the Country field if non-nil, zero value otherwise.

### GetCountryOk

`func (o *ArticleInner) GetCountryOk() (*string, bool)`

GetCountryOk returns a tuple with the Country field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCountry

`func (o *ArticleInner) SetCountry(v string)`

SetCountry sets Country field to given value.

### HasCountry

`func (o *ArticleInner) HasCountry() bool`

HasCountry returns a boolean if a field has been set.

### GetLanguage

`func (o *ArticleInner) GetLanguage() string`

GetLanguage returns the Language field if non-nil, zero value otherwise.

### GetLanguageOk

`func (o *ArticleInner) GetLanguageOk() (*string, bool)`

GetLanguageOk returns a tuple with the Language field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguage

`func (o *ArticleInner) SetLanguage(v string)`

SetLanguage sets Language field to given value.

### HasLanguage

`func (o *ArticleInner) HasLanguage() bool`

HasLanguage returns a boolean if a field has been set.

### SetLanguageNil

`func (o *ArticleInner) SetLanguageNil(b bool)`

 SetLanguageNil sets the value for Language to be an explicit nil

### UnsetLanguage
`func (o *ArticleInner) UnsetLanguage()`

UnsetLanguage ensures that no value is present for Language, not even an explicit nil
### GetAuthors

`func (o *ArticleInner) GetAuthors() string`

GetAuthors returns the Authors field if non-nil, zero value otherwise.

### GetAuthorsOk

`func (o *ArticleInner) GetAuthorsOk() (*string, bool)`

GetAuthorsOk returns a tuple with the Authors field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetAuthors

`func (o *ArticleInner) SetAuthors(v string)`

SetAuthors sets Authors field to given value.

### HasAuthors

`func (o *ArticleInner) HasAuthors() bool`

HasAuthors returns a boolean if a field has been set.

### GetIsOpinion

`func (o *ArticleInner) GetIsOpinion() bool`

GetIsOpinion returns the IsOpinion field if non-nil, zero value otherwise.

### GetIsOpinionOk

`func (o *ArticleInner) GetIsOpinionOk() (*bool, bool)`

GetIsOpinionOk returns a tuple with the IsOpinion field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsOpinion

`func (o *ArticleInner) SetIsOpinion(v bool)`

SetIsOpinion sets IsOpinion field to given value.

### HasIsOpinion

`func (o *ArticleInner) HasIsOpinion() bool`

HasIsOpinion returns a boolean if a field has been set.

### GetTwitterAccount

`func (o *ArticleInner) GetTwitterAccount() string`

GetTwitterAccount returns the TwitterAccount field if non-nil, zero value otherwise.

### GetTwitterAccountOk

`func (o *ArticleInner) GetTwitterAccountOk() (*string, bool)`

GetTwitterAccountOk returns a tuple with the TwitterAccount field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTwitterAccount

`func (o *ArticleInner) SetTwitterAccount(v string)`

SetTwitterAccount sets TwitterAccount field to given value.

### HasTwitterAccount

`func (o *ArticleInner) HasTwitterAccount() bool`

HasTwitterAccount returns a boolean if a field has been set.

### SetTwitterAccountNil

`func (o *ArticleInner) SetTwitterAccountNil(b bool)`

 SetTwitterAccountNil sets the value for TwitterAccount to be an explicit nil

### UnsetTwitterAccount
`func (o *ArticleInner) UnsetTwitterAccount()`

UnsetTwitterAccount ensures that no value is present for TwitterAccount, not even an explicit nil
### GetScore

`func (o *ArticleInner) GetScore() float32`

GetScore returns the Score field if non-nil, zero value otherwise.

### GetScoreOk

`func (o *ArticleInner) GetScoreOk() (*float32, bool)`

GetScoreOk returns a tuple with the Score field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetScore

`func (o *ArticleInner) SetScore(v float32)`

SetScore sets Score field to given value.

### HasScore

`func (o *ArticleInner) HasScore() bool`

HasScore returns a boolean if a field has been set.

### SetScoreNil

`func (o *ArticleInner) SetScoreNil(b bool)`

 SetScoreNil sets the value for Score to be an explicit nil

### UnsetScore
`func (o *ArticleInner) UnsetScore()`

UnsetScore ensures that no value is present for Score, not even an explicit nil
### GetId

`func (o *ArticleInner) GetId() string`

GetId returns the Id field if non-nil, zero value otherwise.

### GetIdOk

`func (o *ArticleInner) GetIdOk() (*string, bool)`

GetIdOk returns a tuple with the Id field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetId

`func (o *ArticleInner) SetId(v string)`

SetId sets Id field to given value.

### HasId

`func (o *ArticleInner) HasId() bool`

HasId returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


