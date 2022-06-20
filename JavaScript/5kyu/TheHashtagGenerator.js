function generateHashtag(str) {
  str = str.match(/\w+/g);

  if (!str) return false;

  var result = str
    .map((w) => w.slice(0, 1).toUpperCase() + w.slice(1).toLowerCase())
    .join("");

  return "#" + result && result.length < 140 ? result : false;
}

function generateHashtag_kata_1(str) {
  return str.length > 140 || str.length === ""
    ? false
    : "#" + str.split(" ").map(capitalize).join("");
}

const capitalize = (word) =>
  word.charAt(0).toUpperCase() + word.slice(1).toLowerCase();

var result = generateHashtag_kata_1("Codewars   is nice");
console.log(result);
