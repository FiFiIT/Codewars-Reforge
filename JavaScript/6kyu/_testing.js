import { strict as assert } from "assert";
import { likes } from "./WhoLikesIt.js";

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
});
