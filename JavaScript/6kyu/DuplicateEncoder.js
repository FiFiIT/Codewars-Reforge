function duplicateEncode(word) {
  word = word.toLowerCase().split("");
  return word
    .map((w) => (word.filter((x) => x == w).length == 1 ? "(" : ")"))
    .join("");
}

function duplicateEncode_kata(word) {
  return word
    .toLowerCase()
    .split("")
    .map((a, i, w) => (w.indexOf(a) == w.lastIndexOf(a) ? "(" : ")"))
    .join("");
}

console.log(duplicateEncode_kata("Success"));
