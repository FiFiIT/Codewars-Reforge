import { strict as assert } from "assert";
import { getCount_2 } from "./VovewlCount.js";
import { accum } from "./Mumbling.js";
import { disemvowel } from "./DisemvowelTrolls.js";
import { highAndLow } from "./HighestAndLowest.js";
import { squareDigits } from "./Square Every Digit.js";
import { descendingOrder } from "./Descending Order.js";
import { getMiddle } from "./GetTheMiddleCharacter.js";
import { isIsogram } from "./Isograms.js";
import { filter_list } from "./ListFiltering.js";
import { XO } from "./ExesAndOhs.js";

describe("7kyu Tests", () => {
  it("Vovewl Count", function () {
    assert.strictEqual(getCount_2("abracadabra"), 5);
    assert.strictEqual(getCount_2("aeiou"), 5);
    assert.strictEqual(getCount_2("y"), 0);
    assert.strictEqual(getCount_2("bcdfghjklmnpqrstvwxz y"), 0);
    assert.strictEqual(getCount_2(""), 0);
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
  it("Descending Order", () => {
    assert.strictEqual(descendingOrder(0), 0);
    assert.strictEqual(descendingOrder(1), 1);
    assert.strictEqual(descendingOrder(111), 111);
    assert.strictEqual(descendingOrder(15), 51);
    assert.strictEqual(descendingOrder(1021), 2110);
    assert.strictEqual(descendingOrder(123456789), 987654321);
  });
  it("Get the middle character", function () {
    assert.strictEqual(getMiddle("test"), "es");
    assert.strictEqual(getMiddle("testing"), "t");
    assert.strictEqual(getMiddle("middle"), "dd");
    assert.strictEqual(getMiddle("A"), "A");
  });
  it("Isogram tests", () => {
    assert.strictEqual(isIsogram("Dermatoglyphics"), true);
    assert.strictEqual(isIsogram("isogram"), true);
    assert.strictEqual(
      isIsogram("aba"),
      false,
      "same chars may not be adjacent"
    );
    assert.strictEqual(
      isIsogram("moOse"),
      false,
      "same chars may not be same case"
    );
    assert.strictEqual(isIsogram("isIsogram"), false);
    assert.strictEqual(
      isIsogram(""),
      true,
      "an empty string is a valid isogram"
    );
  });
  it("List Filtering tests", () => {
    assert.deepEqual(filter_list([1, 2, "a", "b"]), [1, 2]);
    assert.deepEqual(filter_list([1, "a", "b", 0, 15]), [1, 0, 15]);
    assert.deepEqual(filter_list([1, 2, "aasf", "1", "123", 123]), [1, 2, 123]);
  });
  it("Exes and Ohs", () => {
    assert.strictEqual(XO("xo"), true);
    assert.strictEqual(XO("xxOo"), true);
    assert.strictEqual(XO("xxxm"), false);
    assert.strictEqual(XO("Oo"), false);
    assert.strictEqual(XO("ooom"), false);
    assert.strictEqual(XO("Oox"), false);
  });
});
