function findMissingLetter(array) {
  var abc = "abcdefghijklmnopqrstuvwxyz";

  if (array[0] == array[0].toUpperCase()) {
    abc = abc.toUpperCase();
  }

  var start = abc.indexOf(array[0]);
  var end = abc.indexOf(array[array.length - 1]);

  return abc
    .slice(start, end)
    .split("")
    .filter((a) => !array.includes(a))
    .join("");
}

function findMissingLetter_kata(array) {
  let first = array[0].characterAt(0);
  for (let i = 1; i < array.length; i++) {
    if (first + i != array[i]) {
      return String.fromCharCode(first + i);
    }
  }
  return new Error("Invalid input");
}

console.log(findMissingLetter_kata(["a", "b", "c", "d", "f"]));
