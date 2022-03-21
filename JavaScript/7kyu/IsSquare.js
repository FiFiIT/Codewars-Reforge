function isSquare(i) {
  return Math.sqrt(i) % 1 == 0;
}

const isSquare2 = (n) => Number.isInteger(Math.sqrt(n));

var result = isSquare(3);
console.log(result);
