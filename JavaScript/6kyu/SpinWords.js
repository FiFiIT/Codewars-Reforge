function spinWords(string) {
  return string
    .split(" ")
    .map((v, i) => (v.length >= 5 ? v.split("").reverse().join("") : v));
}

function spinWords_2(string) {
  return string.replace(/\w{5,}/g, (w) => w.split("").reverse().join(""));
}

var input = "Hey fellow warriors";
var result = spinWords_2(input);
console.log(result);
