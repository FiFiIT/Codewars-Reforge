function sortArray(array) {
  var odds = array.filter((x) => x % 2 != 0).sort((a, b) => b - a);

  return array.map((a) => (a % 2 ? odds.pop() : a));
}

function sortArray_kata_1(array) {
  var odds = array.filter((x) => x % 2 != 0).sort((a, b) => a - b);

  return array.map((a) => (a % 2 ? odds.shift() : a));
}

var input = [
  47, -18, 20, -10, 11, 12, 4, -16, -36, -13, -14, -50, -14, 34, 41, -38, -45,
];
var result = sortArray_kata_1(input);

console.log(result, "Result");
console.log(
  [-45, -18, 20, -10, -13, 12, 4, -16, -36, 11, -14, -50, -14, 34, 41, -38, 47],
  "Exepted"
);
