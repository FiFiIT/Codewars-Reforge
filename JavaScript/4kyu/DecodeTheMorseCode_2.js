import { decodeMorse } from "../6kyu/DecodeTheMorseCode.js";

function decodeBits_kata(bits) {
  // Trim zeros
  bits = bits.replace(/(^0+|0+$)/g, "");

  // Find transmission rate
  var rate = Math.min.apply(
    null,
    bits.match(/0+|1+/g).map(function (b) {
      return b.length;
    })
  );

  // Convert to morse code
  bits = bits
    .replace(new RegExp("(?:111){" + rate + "}(?:0{" + rate + "}|$)", "g"), "-")
    .replace(new RegExp("1{" + rate + "}(?:0{" + rate + "}|$)", "g"), ".")
    .replace(new RegExp("(?:000000){" + rate + "}", "g"), "   ")
    .replace(new RegExp("(?:00){" + rate + "}", "g"), " ");

  return bits;
}

function decodeMorse_kata(message) {
  return message
    .replace(/   /g, " _ ")
    .split(" ")
    .map(function (letter) {
      return letter === "_" ? " " : MORSE_CODE[letter];
    })
    .join("");
}

var decodeBits = function (bits) {
  // ToDo: Accept 0's and 1's, return dots, dashes and spaces
  var cleanBits = bits.replace(/^0+|0+$/g, "");

  var rate = Math.min(...getLengths(input, "0").concat(getLengths(input, "1")));

  const words = new RegExp(`${"0".repeat(7 * rate)}`, "g");
  const letter = new RegExp(`${"0".repeat(3 * rate)}`, "g");
  const dash = new RegExp(`${"1".repeat(3 * rate)}`, "g");
  const dot = new RegExp(`${"1".repeat(rate)}`, "g");
  const pause = new RegExp(`${"0".repeat(rate)}`, "g");

  return cleanBits
    .replace(words, "   ")
    .replace(letter, " ")
    .replace(dash, "-")
    .replace(dot, ".")
    .replace(pause, "");
};

const getLengths = (input, del) => {
  return input
    .split(del)
    .map((v) => v.length)
    .filter((l) => l > 0);
};

var input =
  "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011";

var result = decodeMorse(
  decodeBits(
    "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"
  )
);
