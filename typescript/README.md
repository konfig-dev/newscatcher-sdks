## newscatcherapi-typescript-sdk@1.0.0

This generator creates TypeScript/JavaScript client that utilizes [axios](https://github.com/axios/axios). The generated Node module can be used in the following environments:

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
npm install newscatcherapi-typescript-sdk@1.0.0 --save
```

### Getting Started

```typescript

import { Configuration, LatestHeadlinesApi, Model200ResponseLatest, Topic, ErrorResponse } from "newscatcherapi-typescript-sdk";

const apiKey = process.env.API_KEY;
const config = new Configuration({ apiKey });

const api = new LatestHeadlinesApi(config);

const lang: 'af' | 'ar' | 'bg' | 'bn' | 'ca' | 'cn' | 'cs' | 'cy' | 'da' | 'de' | 'el' | 'en' | 'es' | 'et' | 'fa' | 'fi' | 'fr' | 'gu' | 'he' | 'hi' | 'hr' | 'hu' | 'id' | 'it' | 'ja' | 'kn' | 'ko' | 'lt' | 'lv' | 'mk' | 'ml' | 'mr' | 'ne' | 'nl' | 'false' | 'pa' | 'pl' | 'pt' | 'ro' | 'ru' | 'sk' | 'sl' | 'so' | 'sq' | 'sv' | 'sw' | 'ta' | 'te' | 'th' | 'tl' | 'tr' | 'tw' | 'uk' | 'ur' | 'vi' = "en";
const notLang: 'af' | 'ar' | 'bg' | 'bn' | 'ca' | 'cn' | 'cs' | 'cy' | 'da' | 'de' | 'el' | 'en' | 'es' | 'et' | 'fa' | 'fi' | 'fr' | 'gu' | 'he' | 'hi' | 'hr' | 'hu' | 'id' | 'it' | 'ja' | 'kn' | 'ko' | 'lt' | 'lv' | 'mk' | 'ml' | 'mr' | 'ne' | 'nl' | 'false' | 'pa' | 'pl' | 'pt' | 'ro' | 'ru' | 'sk' | 'sl' | 'so' | 'sq' | 'sv' | 'sw' | 'ta' | 'te' | 'th' | 'tl' | 'tr' | 'tw' | 'uk' | 'ur' | 'vi' = "notLang_example";
const countries: string = "countries_example";
const notCountries: string = "notCountries_example";
const topic: Topic = ;
const sources: string = "sources_example";
const notSources: string = "notSources_example";
const rankedOnly: boolean = true;
const pageSize: number = 56;
const page: number = 56;

const request = api.get(lang, notLang, countries, notCountries, topic, sources, notSources, rankedOnly, pageSize, page);
request.then(result => {
    console.log(result)
})

```
