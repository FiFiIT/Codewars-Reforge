function sumTwoSmallestNumbers(numbers) {
  return numbers
    .sort((a, b) => b - a)
    .slice(-2)
    .reduce((a, b) => a + b, 0);
}

function sumTwoSmallestNumbers_2(numbers) {
  var [a, b] = numbers.sort((a, b) => a - b);
  return a + b;
}

var result = sumTwoSmallestNumbers_2([15, 28, 4, 2, 43]);
console.log(result);
