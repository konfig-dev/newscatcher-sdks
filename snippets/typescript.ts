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