## newscatcherapi-typescript-sdk@4.2.0

This library that utilizes [axios](https://github.com/axios/axios). The generated Node module can be used in the following environments:

Environment
* Node.js
* Webpack
* Browserify

Language level
* ES5 - you must have a Promises/A+ library installed
* ES6

Module system
* CommonJS
* ES6 module system

It can be used in both TypeScript and JavaScript. In TypeScript, the definition should be automatically resolved via `package.json`. ([Reference](http://www.typescriptlang.org/docs/handbook/typings-for-npm-packages.html))

### Building

To build and compile the typescript sources to javascript use:
```
npm install
npm run build
```

### Consuming

navigate to the folder of your consuming project and run the following command.

```
npm install newscatcherapi-typescript-sdk@4.2.0 --save
```

### Getting Started

```typescript
import { Newscatcher } from "newscatcherapi-typescript-sdk"

const newscatcher = new Newscatcher({
    apiKey: 'API_KEY',
})

const response = await newscatcher.latestHeadlines.get({
    'lang': "en",
    'notLang': "af",
    'countries': "US,CA",
    'notCountries': "US,CA",
    'topic': "business",
    'sources': "nytimes.com,theguardian.com",
    'notSources': "wsj.com",
    'rankedOnly': true,
    'pageSize': 100,
    'page': 1,
})

console.log(response)
```

## Documentation for API Endpoints

All URIs are relative to *https://api.newscatcherapi.com/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*LatestHeadlinesApi* | [**get**](docs/LatestHeadlinesApi.md#get) | **GET** /latest_headlines | Get Latest News Articles
*LatestHeadlinesApi* | [**post**](docs/LatestHeadlinesApi.md#post) | **POST** /latest_headlines | Get Latest News Articles
*SearchApi* | [**get**](docs/SearchApi.md#get) | **GET** /search | Search for specific news articles
*SearchApi* | [**post**](docs/SearchApi.md#post) | **POST** /search | Search for specific news articles
*SourcesApi* | [**get**](docs/SourcesApi.md#get) | **GET** /sources | Get top news sources supported by NewsCatcher.
*SourcesApi* | [**post**](docs/SourcesApi.md#post) | **POST** /sources | Get top news sources supported by NewsCatcher.


