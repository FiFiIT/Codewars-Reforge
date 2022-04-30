import { strict as assert } from "assert";
import { likes } from "./WhoLikesIt.js";
import { toCamelCase } from "./ConvertStringToCamelCase.js";

describe("6kyu Tests", () => {
  it("Who Likes It?", function () {
    assert.strictEqual(likes([]), "no one likes this");
    assert.strictEqual(likes(["Peter"]), "Peter likes this");
    assert.strictEqual(likes(["Jacob", "Alex"]), "Jacob and Alex like this");
    assert.strictEqual(
      likes(["Max", "John", "Mark"]),
      "Max, John and Mark like this"
    );
    assert.strictEqual(
      likes(["Alex", "Jacob", "Mark", "Max"]),
      "Alex, Jacob and 2 others like this"
    );
  });
  it("Convert string to camel case", () => {
    assert.strictEqual(
      toCamelCase(""),
      "",
      "An empty string was provided but not returned"
    );
    assert.strictEqual(
      toCamelCase("the_stealth_warrior"),
      "theStealthWarrior",
      "toCamelCase('the_stealth_warrior') did not return correct value"
    );
    assert.strictEqual(
      toCamelCase("The-Stealth-Warrior"),
      "TheStealthWarrior",
      "toCamelCase('The-Stealth-Warrior') did not return correct value"
    );
    assert.strictEqual(
      toCamelCase("A-B-C"),
      "ABC",
      "toCamelCase('A-B-C') did not return correct value"
    );
  });
});
