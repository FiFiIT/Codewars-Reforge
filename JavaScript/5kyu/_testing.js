import { strict as assert } from "assert";
import { domainName } from "./ExtractTheDomainName.js";

// mocha ./testing.js

describe("5kyu Tests", () => {
  it("Extract the domain name from a URL", () => {
    assert.strictEqual(domainName("http://google.com"), "google");
    assert.strictEqual(domainName("http://google.co.jp"), "google");
    assert.strictEqual(domainName("www.xakep.ru"), "xakep");
    assert.strictEqual(domainName("https://youtube.com"), "youtube");
  });
});
