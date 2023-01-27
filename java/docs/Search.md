

# Search


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**q** | **String** | Keyword/keywords you&#39;re searching for. This is the most important part of your query. Please, refer to the **Advanced Query Parameter** section of the docs for more examples and explanations. |  [optional] |
|**lang** | [**LangEnum**](#LangEnum) | The language you want to search in. |  [optional] |
|**notLang** | [**NotLangEnum**](#NotLangEnum) | Inverse to the lang parameter. |  [optional] |
|**publishedDatePrecision** | [**PublishedDatePrecisionEnum**](#PublishedDatePrecisionEnum) | Precision of the publication date. |  [optional] |
|**from** | **String** | YYYY/mm/dd From which point in time to start the search. The default timezone is UTC.  Defaults to the past week. |  [optional] |
|**to** | **String** | YYYY/mm/dd Until which point in time to search for. The default timezone is UTC. |  [optional] |
|**searchIn** | [**SearchInEnum**](#SearchInEnum) |  |  [optional] |
|**countries** | **String** |  |  [optional] |
|**notCountries** | **String** |  |  [optional] |
|**topic** | [**TopicEnum**](#TopicEnum) |  |  [optional] |
|**sources** | **String** |  |  [optional] |
|**notSources** | **String** |  |  [optional] |
|**rankedOnly** | **Boolean** |  |  [optional] |
|**sortBy** | [**SortByEnum**](#SortByEnum) |  |  [optional] |
|**pageSize** | **Integer** |  |  [optional] |
|**page** | **Integer** |  |  [optional] |



## Enum: LangEnum

| Name | Value |
|---- | -----|
| AF | &quot;af&quot; |
| AR | &quot;ar&quot; |
| BG | &quot;bg&quot; |
| BN | &quot;bn&quot; |
| CA | &quot;ca&quot; |
| CN | &quot;cn&quot; |
| CS | &quot;cs&quot; |
| CY | &quot;cy&quot; |
| DA | &quot;da&quot; |
| DE | &quot;de&quot; |
| EL | &quot;el&quot; |
| EN | &quot;en&quot; |
| ES | &quot;es&quot; |
| ET | &quot;et&quot; |
| FA | &quot;fa&quot; |
| FI | &quot;fi&quot; |
| FR | &quot;fr&quot; |
| GU | &quot;gu&quot; |
| HE | &quot;he&quot; |
| HI | &quot;hi&quot; |
| HR | &quot;hr&quot; |
| HU | &quot;hu&quot; |
| ID | &quot;id&quot; |
| IT | &quot;it&quot; |
| JA | &quot;ja&quot; |
| KN | &quot;kn&quot; |
| KO | &quot;ko&quot; |
| LT | &quot;lt&quot; |
| LV | &quot;lv&quot; |
| MK | &quot;mk&quot; |
| ML | &quot;ml&quot; |
| MR | &quot;mr&quot; |
| NE | &quot;ne&quot; |
| NL | &quot;nl&quot; |
| FALSE | &quot;false&quot; |
| PA | &quot;pa&quot; |
| PL | &quot;pl&quot; |
| PT | &quot;pt&quot; |
| RO | &quot;ro&quot; |
| RU | &quot;ru&quot; |
| SK | &quot;sk&quot; |
| SL | &quot;sl&quot; |
| SO | &quot;so&quot; |
| SQ | &quot;sq&quot; |
| SV | &quot;sv&quot; |
| SW | &quot;sw&quot; |
| TA | &quot;ta&quot; |
| TE | &quot;te&quot; |
| TH | &quot;th&quot; |
| TL | &quot;tl&quot; |
| TR | &quot;tr&quot; |
| TW | &quot;tw&quot; |
| UK | &quot;uk&quot; |
| UR | &quot;ur&quot; |
| VI | &quot;vi&quot; |



## Enum: NotLangEnum

| Name | Value |
|---- | -----|
| AF | &quot;af&quot; |
| AR | &quot;ar&quot; |
| BG | &quot;bg&quot; |
| BN | &quot;bn&quot; |
| CA | &quot;ca&quot; |
| CN | &quot;cn&quot; |
| CS | &quot;cs&quot; |
| CY | &quot;cy&quot; |
| DA | &quot;da&quot; |
| DE | &quot;de&quot; |
| EL | &quot;el&quot; |
| EN | &quot;en&quot; |
| ES | &quot;es&quot; |
| ET | &quot;et&quot; |
| FA | &quot;fa&quot; |
| FI | &quot;fi&quot; |
| FR | &quot;fr&quot; |
| GU | &quot;gu&quot; |
| HE | &quot;he&quot; |
| HI | &quot;hi&quot; |
| HR | &quot;hr&quot; |
| HU | &quot;hu&quot; |
| ID | &quot;id&quot; |
| IT | &quot;it&quot; |
| JA | &quot;ja&quot; |
| KN | &quot;kn&quot; |
| KO | &quot;ko&quot; |
| LT | &quot;lt&quot; |
| LV | &quot;lv&quot; |
| MK | &quot;mk&quot; |
| ML | &quot;ml&quot; |
| MR | &quot;mr&quot; |
| NE | &quot;ne&quot; |
| NL | &quot;nl&quot; |
| FALSE | &quot;false&quot; |
| PA | &quot;pa&quot; |
| PL | &quot;pl&quot; |
| PT | &quot;pt&quot; |
| RO | &quot;ro&quot; |
| RU | &quot;ru&quot; |
| SK | &quot;sk&quot; |
| SL | &quot;sl&quot; |
| SO | &quot;so&quot; |
| SQ | &quot;sq&quot; |
| SV | &quot;sv&quot; |
| SW | &quot;sw&quot; |
| TA | &quot;ta&quot; |
| TE | &quot;te&quot; |
| TH | &quot;th&quot; |
| TL | &quot;tl&quot; |
| TR | &quot;tr&quot; |
| TW | &quot;tw&quot; |
| UK | &quot;uk&quot; |
| UR | &quot;ur&quot; |
| VI | &quot;vi&quot; |



## Enum: PublishedDatePrecisionEnum

| Name | Value |
|---- | -----|
| FULL | &quot;full&quot; |
| TIMEZONE_UNKNOWN | &quot;timezone unknown&quot; |
| DATE | &quot;date&quot; |



## Enum: SearchInEnum

| Name | Value |
|---- | -----|
| TITLE | &quot;title&quot; |
| SUMMARY | &quot;summary&quot; |
| TITLE_SUMMARY | &quot;title_summary&quot; |



## Enum: TopicEnum

| Name | Value |
|---- | -----|
| NEWS | &quot;news&quot; |
| SPORT | &quot;sport&quot; |
| TECH | &quot;tech&quot; |
| WORLD | &quot;world&quot; |
| FINANCE | &quot;finance&quot; |
| POLITICS | &quot;politics&quot; |
| BUSINESS | &quot;business&quot; |
| ECONOMICS | &quot;economics&quot; |
| ENTERTAINMENT | &quot;entertainment&quot; |
| BEAUTY | &quot;beauty&quot; |
| TRAVEL | &quot;travel&quot; |
| MUSIC | &quot;music&quot; |
| FOOD | &quot;food&quot; |
| SCIENCE | &quot;science&quot; |
| GAMING | &quot;gaming&quot; |



## Enum: SortByEnum

| Name | Value |
|---- | -----|
| RELEVANCY | &quot;relevancy&quot; |
| DATE | &quot;date&quot; |
| RANK | &quot;rank&quot; |



