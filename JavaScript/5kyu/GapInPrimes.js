function gap(g, m, n) {
  var lastPrime = 0;
  for (let i = m; i <= n; i++) {
    if (isPrime(i)) {
      if (i - lastPrime == g) return [lastPrime, i];

      lastPrime = i;
    }
  }
  return null;
}

const isPrime = (n) => {
  for (let i = 2; i <= Math.sqrt(n); i++) {
    if (n % i === 0) {
      return false;
    }
  }
  return true;
};

var result = gap(8, 300, 400);
console.log(result);

export { gap };
