function isPangram(string) {
  var abc = "abcdefghijklmnopqrstuvwxyz";

  string
    .toLowerCase()
    .split("")
    .map((c) => (abc = abc.replace(c, "")));

  return abc.length == 0;
}

// The every() method tests whether all elements in the array pass the test implemented by the provided function. It returns a Boolean value.
function isPangram_kata(string) {
  return "abcdefghijklmnopqrstuvwxyz"
    .split("")
    .every((x) => string.indexOf(x) != -1);
}

var string =
  "Raw Danger!(Zettai Zetsumei Toshi 2) for the PlayStation 2 is a bit queer, but an alright game I guess, uh... CJ kicks and vexes Tenpenny precariously ? This should be a pangram now, probably.";
var result = isPangram(string);
console.log(result);
