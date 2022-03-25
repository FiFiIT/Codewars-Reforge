function getSum(a, b) {
  var x = 0;
  for (let i = Math.min(a, b); i < Math.max(a, b); i++) {
    x += i;
  }
  return x;
}

function getSum_2(a, b) {
  let min = Math.min(a, b);
  let max = Math.max(a, b);

  return ((max - min + 1) * (min + max)) / 2;
}

function getSum_3(a, b) {
  return ((a + b) * (Math.abs(a - b) + 1)) / 2;
}

console.log(getSum_3(0, -1));
