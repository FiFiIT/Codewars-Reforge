var morseCode = new Map();
morseCode.set(".-", "A");
morseCode.set("-...", "B");
morseCode.set("-.-.", "C");
morseCode.set("-..", "D");
morseCode.set(".", "E");
morseCode.set("..-.", "F");
morseCode.set("--.", "G");
morseCode.set("....", "H");
morseCode.set("..", "I");
morseCode.set(".---", "J");
morseCode.set("-.-", "K");
morseCode.set(".-..", "L");
morseCode.set("--", "M");
morseCode.set("-.", "N");
morseCode.set("---", "O");
morseCode.set(".--.", "P");
morseCode.set("--.-", "Q");
morseCode.set(".-.", "R");
morseCode.set("...", "S");
morseCode.set("-", "T");
morseCode.set("..-", "U");
morseCode.set("...-", "V");
morseCode.set(".--", "W");
morseCode.set("-..-", "X");
morseCode.set("-.--", "Y");
morseCode.set("--..", "Z");
morseCode.set("-----", "0");
morseCode.set(".----", "1");
morseCode.set("..---", "2");
morseCode.set("...--", "3");
morseCode.set("....-", "4");
morseCode.set(".....", "5");
morseCode.set("-....", "6");
morseCode.set("--...", "7");
morseCode.set("---..", "8");
morseCode.set("----.", "9");
morseCode.set("...---...", "SOS");
morseCode.set(".-.-.-", ".");
morseCode.set("..--..", "?");
morseCode.set("-..-.", "/");
morseCode.set("-....-", "-");
morseCode.set("-.--.", "(");
morseCode.set("-.--.-", ")");
morseCode.set("-.-.--", "!");
morseCode.set("--..--", ",");

const decodeMorseLetter = (letter) => morseCode.get(letter);

const decodeMorse = function (code) {
  var words = code.trim().split("   ");

  var translated = words.map((word) =>
    word.split(" ").map(decodeMorseLetter).join("")
  );

  return translated.join(" ");
};

var result = decodeMorse(".... . -.--   .--- ..- -.. .");
console.log(result);

export { decodeMorse };
