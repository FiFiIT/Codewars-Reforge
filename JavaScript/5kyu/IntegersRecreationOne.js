function listSquared(m, n) {
  var result = [];
  var sum = 0;

  for (let number = m; number <= n; number++) {
    sum = findDivisors(number).reduce((a, v) => (a += v * v), 0);

    if (sum ** 0.5 % 1 == 0) {
      result.push([number, sum]);
    }
  }

  return result;
}

const findDivisors = (n) => {
  var div = [];
  for (let i = 1; i <= Math.sqrt(n); i++) {
    if (n % i == 0) {
      if (n / i == i) {
        div.push(i);
      } else {
        div.push(i, n / i);
      }
    }
  }

  return div;
};

console.log(listSquared(1, 246));
