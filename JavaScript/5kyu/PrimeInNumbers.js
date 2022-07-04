function primeFactors(n) {
  var primes = [];

  for (let i = 2; i <= n; i++) {
    let counter = 0;
    while (n % i == 0) {
      counter++;
      n = n / i;
    }
    if (counter >= 1) {
      primes.push(counter > 1 ? `(${i}**${counter})` : `(${i})`);
    }
  }

  return primes.join("");
}

function primeFactors_kata_1(n) {
  for (var i = 2, res = "", f; i <= n; i++) {
    f = 0;
    while (n % i == 0) {
      n /= i;
      f++;
    }
    res += f ? "(" + (f > 1 ? i + "**" + f : i) + ")" : "";
  }

  return res || "(" + n + ")";
}

export { primeFactors };
