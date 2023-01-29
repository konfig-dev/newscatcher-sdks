import { Configuration, LatestHeadlinesApi, SearchApi, SourcesApi } from ".";

describe("api", () => {
  const apiKey = process.env.NEWSCATCHER_API_KEY;
  const config = new Configuration({ apiKey });
  it("latest headlines", async () => {
    const api = new LatestHeadlinesApi(config);
    const result = await api.post({ lang: "en" });
    expect(result).not.toBeNull();
  });
  it("search", async () => {
    const api = new SearchApi(config);
    const result = await api.post({ q: "Apple", from: "three months ago" });
    expect(result).not.toBeNull();
  });
  it("sources", async () => {
    const api = new SourcesApi(config);
    const result = await api.post({ lang: "en" });
    expect(result).not.toBeNull();
  });
});
