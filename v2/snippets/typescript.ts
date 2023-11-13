import { Newscatcher } from "newscatcher-typescript-sdk";

const newscatcher = new Newscatcher({
  apiKey: process.env.NEWSCATCHER_API_KEY,
});

let latestHeadlines = await newscatcher.latestHeadlines.post({
  requestBody: { lang: "en" },
});
console.log(latestHeadlines.data);

// Pagination
while (latestHeadlines.hasNext()) {
  latestHeadlines = await latestHeadlines.next();
  console.log(latestHeadlines.data);
}

const search = await newscatcher.search.post({
  requestBody: { q: "Apple", from: "three months ago" },
});
console.log(search.data);

const sources = await newscatcher.sources.post({
  requestBody: { lang: "en" },
});

console.log(sources.data);
