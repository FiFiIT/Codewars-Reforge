function alphabetPosition(text) {
  text = text.toLowerCase().match(/[a-z]/gi);

  if (!text) return "";

  return text.map((c) => "abcdefghijklmnopqrstuvwxyz".indexOf(c) + 1).join(" ");
}

var result = alphabetPosition("123");
console.log(result);
