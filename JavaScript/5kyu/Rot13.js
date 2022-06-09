function rot13(message) {
  return message
    .split("")
    .map((c) => (isalpha(c) ? cesar(c) : c))
    .join("");
}
function isalpha(c) {
  return /^[a-zA-z]$/.test(c);
}

function cesar(c) {
  var a = c.charCodeAt(0);

  if (a < 78 || (a > 90 && a < 110)) {
    return String.fromCharCode(a + 13);
  }

  return String.fromCharCode(a - 13);
}

const rot13_kata_1 = (message) =>
  message.replace(/[a-z]/gi, (letter) =>
    String.fromCharCode(
      letter.charCodeAt(0) + (letter.toLowerCase() <= "m" ? 13 : -13)
    )
  );

//console.log("c".charCodeAt(0) + 1);
var result = rot13_kata_1("abcdefghijklmnopqrstuvwxyz");
console.log(result);
