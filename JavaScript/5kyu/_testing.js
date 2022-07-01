import { strict as assert } from "assert";
import { domainName } from "./ExtractTheDomainName.js";
import { score } from "./GreedIsGood.js";
import { primeFactors } from "./PrimeInNumbers.js";
// mocha ./_testing.js -g 'Scorer Function'

describe("5kyu Tests", () => {
  it("Extract the domain name from a URL", () => {
    assert.strictEqual(domainName("http://google.com"), "google");
    assert.strictEqual(domainName("http://google.co.jp"), "google");
    assert.strictEqual(domainName("www.xakep.ru"), "xakep");
    assert.strictEqual(domainName("https://youtube.com"), "youtube");
  });
});

describe("Greed is Good", () => {
  it("[2, 3, 4, 6, 2] should be 0", () => {
    assert.strictEqual(score([2, 3, 4, 6, 2]), 0);
  });
  it("[4, 4, 4, 3, 3] should be 400", () => {
    assert.strictEqual(score([4, 4, 4, 3, 3]), 400);
  });
  it("[2, 4, 4, 5, 4] should be 450", () => {
    assert.strictEqual(score([2, 4, 4, 5, 4]), 450);
  });
});

describe("Prime in numbers", () => {
  it("Testing for 7775460", () => {
    assert.strictEqual(primeFactors(7775460), "(2**2)(3**3)(5)(7)(11**2)(17)");
  });
});
