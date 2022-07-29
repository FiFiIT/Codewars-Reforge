import { strict as assert } from "assert";
import { domainName } from "./ExtractTheDomainName.js";
import { score } from "./GreedIsGood.js";
import { primeFactors } from "./PrimeInNumbers.js";
import { validate } from "./RegexPasswordValidation.js";
import { gap } from "./GapInPrimes.js";
import { doneOrNot } from "./DidIFinishMySudoku.js";
import { lastDigit } from "./LastDigitOfALargeNumber.js";
// mocha ./_testing.js -g 'Last digit'

describe("Last digit of a large number", () => {
  it("should work for some examples", function () {
    assert.strictEqual(lastDigit("4", "1"), 4);
    assert.strictEqual(lastDigit("4", "2"), 6);
    assert.strictEqual(lastDigit("9", "7"), 9);
    assert.strictEqual(lastDigit("10", "10000000000"), 0);
    assert.strictEqual(
      lastDigit(
        "1606938044258990275541962092341162602522202993782792835301376",
        "2037035976334486086268445688409378161051468393665936250636140449354381299763336706183397376"
      ),
      6
    );
    assert.strictEqual(
      lastDigit(
        "3715290469715693021198967285016729344580685479654510946723",
        "68819615221552997273737174557165657483427362207517952651"
      ),
      7,
      "3715290469715693021198967285016729344580685479654510946723 power 68819615221552997273737174557165657483427362207517952651"
    );
  });
  it("should work for x ^ 0", function () {
    var randomString = function () {
      var i = Math.floor(Math.random() * 100) + 1,
        str = "";
      while (i-- > 0) {
        str = str + "01234567890".charAt(Math.floor(Math.random() * 10));
      }
      return str;
    };
    var i, r;
    for (i = 0; i < 100; ++i) {
      r = lastDigit(randomString(), "0");
      if (i < 1 || r !== 1) {
        assert.strictEqual(r, 1, "x ^ 0 has 1 as last digit");
        if (r !== 1) return;
      }
    }
  });
});

describe("Did I Finish my Sudoku", () => {
  it("Should be Finished", () => {
    assert.strictEqual(
      doneOrNot([
        [5, 3, 4, 6, 7, 8, 9, 1, 2],
        [6, 7, 2, 1, 9, 5, 3, 4, 8],
        [1, 9, 8, 3, 4, 2, 5, 6, 7],
        [8, 5, 9, 7, 6, 1, 4, 2, 3],
        [4, 2, 6, 8, 5, 3, 7, 9, 1],
        [7, 1, 3, 9, 2, 4, 8, 5, 6],
        [9, 6, 1, 5, 3, 7, 2, 8, 4],
        [2, 8, 7, 4, 1, 9, 6, 3, 5],
        [3, 4, 5, 2, 8, 6, 1, 7, 9],
      ]),
      "Finished!"
    );
  });
  it("Should be Try again!", () => {
    assert.strictEqual(
      doneOrNot([
        [5, 3, 4, 6, 7, 8, 9, 1, 2],
        [6, 7, 2, 1, 9, 0, 3, 4, 9],
        [1, 0, 0, 3, 4, 2, 5, 6, 0],
        [8, 5, 9, 7, 6, 1, 0, 2, 0],
        [4, 2, 6, 8, 5, 3, 7, 9, 1],
        [7, 1, 3, 9, 2, 4, 8, 5, 6],
        [9, 0, 1, 5, 3, 7, 2, 1, 4],
        [2, 8, 7, 4, 1, 9, 6, 3, 5],
        [3, 0, 0, 4, 8, 1, 1, 7, 9],
      ]),
      "Try again!"
    );
  });
});

describe("Gap in Primes", () => {
  it("Basic tests", () => {
    assert.strictEqual(gap(2, 100, 110), [101, 103]);
    assert.strictEqual(gap(4, 100, 110), [103, 107]);
    assert.strictEqual(gap(6, 100, 110), null);
    assert.strictEqual(gap(8, 300, 400), [359, 367]);
    assert.strictEqual(gap(10, 300, 400), [337, 347]);
  });
});

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
