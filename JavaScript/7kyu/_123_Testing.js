import { strict as assert } from "assert";
import { getCount } from "./VovewlCount.js";
import { accum } from "./Mumbling.js";
import { disemvowel } from "./DisemvowelTrolls.js";
import { highAndLow } from "./HighestAndLowest.js";
import { squareDigits } from "./Square Every Digit.js";

describe("7kyu Tests", () => {
  it("Vovewl Count", function () {
    assert.strictEqual(getCount("abracadabra"), 5);
    assert.strictEqual(getCount("aeiou"), 5);
    assert.strictEqual(getCount("y"), 0);
    assert.strictEqual(getCount("bcdfghjklmnpqrstvwxz y"), 0);
    assert.strictEqual(getCount(""), 0);
  });
  it("Mumbling", () => {
    assert.strictEqual(
      accum("ZpglnRxqenU"),
      "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu"
    );
    assert.strictEqual(
      accum("NyffsGeyylB"),
      "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb"
    );
    assert.strictEqual(
      accum("MjtkuBovqrU"),
      "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu"
    );
    assert.strictEqual(
      accum("EvidjUnokmM"),
      "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm"
    );
    assert.strictEqual(
      accum("HbideVbxncC"),
      "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc"
    );
  });
  it("Disemvowel Trolls", () => {
    assert.strictEqual(
      disemvowel("This website is for losers LOL!"),
      "Ths wbst s fr lsrs LL!"
    );
    assert.strictEqual(
      disemvowel(
        "No offense but,\nYour writing is among the worst I've ever read"
      ),
      "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd"
    );
    assert.strictEqual(
      disemvowel("What are you, a communist?"),
      "Wht r y,  cmmnst?"
    );
  });
  it("Highest and Lowest", () => {
    assert.strictEqual(
      highAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"),
      "542 -214"
    );
  });
  it("Square Every Digit", () => {
    assert.strictEqual(squareDigits(3212), 9414);
    assert.strictEqual(squareDigits(2112), 4114);
    assert.strictEqual(squareDigits(0), 0);
  });
});
