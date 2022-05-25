function anagrams(word, words) {
  return words.filter((w) => {
    if (w.length != word.length) {
      return false;
    }

    word = word.split("").sort().join("");

    return w
      .split("")
      .sort()
      .every((v, i, a) => v == word[i]);
  });
}

String.prototype.sort = function () {
  return this.split("").sort().join("");
};

function anagrams_kata_1(word, words) {
  word = word.sort();

  return words.filter((w) => w.sort() == word);
}

var input = ["crazer", "carer", "racar", "caers", "racer"];
var result = anagrams_kata_1("racer", input);
console.log(result);
