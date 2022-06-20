function firstNonRepeatingLetter(s) {
  for (var i in s) {
    if (s.match(new RegExp(s[i], "gi")).length == 1) {
      return s[i];
    }
    s.split("").map((c) => c);
  }

  return "";
}

function firstNonRepeatingLetter_kata_1(s) {
  return (
    s.split("").find((c) => s.match(new RegExp(c, "gi")).length == 1) || ""
  );
}

var result = firstNonRepeatingLetter_kata_1("stress");
console.log(result);
