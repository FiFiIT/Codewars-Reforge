function zeros_kata_1(n) {
  var fives = 0;
  while (n > 0) {
    n = Math.floor(n / 5);
    fives += n;
  }
  return fives;
}

function zeros(n) {
  return n / 5 < 1 ? 0 : Math.floor(n / 5) + zeros(n / 5);
}

console.log(zeros(0));
console.log(zeros(5));
console.log(zeros(6));
console.log(zeros(30));
