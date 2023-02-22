## newscatcherapi-typescript-sdk@4.0.0

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
npm install newscatcherapi-typescript-sdk@4.0.0 --save
```

### Getting Started

```typescript
import { Newscatcher } from "newscatcher-typescript-sdk";

const newscatcher = new Newscatcher({
  apiKey: process.env.NEWSCATCHER_API_KEY,
});

const latestHeadlines = await newscatcher.latestHeadlines.post({
  latestHeadlines: { lang: "en" },
});
console.log(latestHeadlines);

const search = await newscatcher.search.post({
  search: { q: "Apple", from: "three months ago" },
});
console.log(search);

const sources = await newscatcher.sources.post({
  sourcesQuery: { lang: "en" },
});

console.log(sources);
```
