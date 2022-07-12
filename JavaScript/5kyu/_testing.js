import { strict as assert } from "assert";
import { domainName } from "./ExtractTheDomainName.js";
import { score } from "./GreedIsGood.js";
import { primeFactors } from "./PrimeInNumbers.js";
import { validate } from "./RegexPasswordValidation.js";
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

describe("Regex Password Validation", () => {
  it("djI38D55 - Expected true", () => {
    assert.strictEqual(validate("djI38D55"), true);
  });
  it("a2.d412 - Expected false", () => {
    assert.strictEqual(validate("a2.d412"), false);
  });
  it("JHD5FJ53 - Expected false", () => {
    assert.strictEqual(validate("JHD5FJ53"), false);
  });
  it("!fdjn345 - Expected false", () => {
    assert.strictEqual(validate("!fdjn345"), false);
  });
  it("jfkdfj3j - Expected false", () => {
    assert.strictEqual(validate("jfkdfj3j"), false);
  });
  it("123 - Expected false", () => {
    assert.strictEqual(validate("123"), false);
  });
  it("abc - Expected false", () => {
    assert.strictEqual(validate("abc"), false);
  });
  it("Password123 - Expected true", () => {
    assert.strictEqual(validate("Password123"), true);
  });
});
