import { Newscatcher } from "./index";

describe("api", () => {
  const newscatcher = new Newscatcher({
    apiKey: process.env.NEWSCATCHER_API_KEY,
  });
  it("latest headlines", async () => {
    const result = await newscatcher.latestHeadlines.post({
      latestHeadlines: { lang: "en" },
    });
    expect(result).not.toBeNull();
  });
  it("search", async () => {
    const result = await newscatcher.search.post({
      search: { q: "Apple", from: "three months ago" },
    });
    expect(result).not.toBeNull();
  });
  it("sources", async () => {
    const result = await newscatcher.sources.post({
      sourcesQuery: { lang: "en" },
    });
    expect(result).not.toBeNull();
  });
});
