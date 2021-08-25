function highAndLow(numbers) {
  var n = numbers.split(" ");
  return `${Math.max(...n)} ${Math.min(...n)}`;
}

var result = highAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6");
console.log(result);

export { highAndLow };
