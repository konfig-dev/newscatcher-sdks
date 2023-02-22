import { Newscatcher } from "./index";

describe("api", () => {
  const newscatcher = new Newscatcher({
    apiKey: process.env.NEWSCATCHER_API_KEY,
  });
  it("latest headlines - get", async () => {
    let page = await newscatcher.latestHeadlines.get({
      lang: "en",
    });
    expect(page).not.toBeNull();

    // Test pagination
    let paginationCount = 0;
    let lastPage = page.data.page;
    while (page.hasNext()) {
      page = await page.next();
      paginationCount++;
      console.log(`Paginated ${paginationCount} time(s)`);
      expect(page.data).not.toBeNull();
      expect(page.data.page).toBeGreaterThan(lastPage);
      lastPage = page.data.page;
      console.log(`Page: ${page.data.page}`);

      if (paginationCount === 1) break;
    }
    expect(paginationCount).toBe(1);
  });
  it("latest headlines - post", async () => {
    let page = await newscatcher.latestHeadlines.post({
      requestBody: { lang: "en" },
    });
    expect(page).not.toBeNull();

    // Test pagination
    let paginationCount = 0;
    let lastPage = page.data.page;
    while (page.hasNext()) {
      page = await page.next();
      paginationCount++;
      console.log(`Paginated ${paginationCount} time(s)`);
      expect(page.data).not.toBeNull();
      expect(page.data.page).toBeGreaterThan(lastPage);
      lastPage = page.data.page;

      if (paginationCount === 1) break;
    }
    expect(paginationCount).toBe(1);
  });
  it("search", async () => {
    const result = await newscatcher.search.post({
      requestBody: { q: "Apple", from: "three months ago" },
    });
    expect(result).not.toBeNull();
  });
  it("sources", async () => {
    const result = await newscatcher.sources.post({
      requestBody: { lang: "en" },
    });
    expect(result).not.toBeNull();
  });
});
