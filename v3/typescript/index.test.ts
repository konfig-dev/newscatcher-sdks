import { Newscatcher } from "./index";

describe("newscatcherapi-typescript-sdk", () => {
    it("initialize client", async () => {
        const newscatcher = new Newscatcher({
            apiKey: "API_KEY",
        });
    });
});
