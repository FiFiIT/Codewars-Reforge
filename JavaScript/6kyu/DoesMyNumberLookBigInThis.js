function narcissistic(value) {
  var result = value
    .toString()
    .split("")
    .map((a, i, arr) => parseInt(a) ** arr.length)
    .reduce((a, b) => a + b, 0);

  return result == value;
}

var result = narcissistic(371);
console.log(result);
