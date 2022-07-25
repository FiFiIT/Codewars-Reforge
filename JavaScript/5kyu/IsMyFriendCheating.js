function removeNb(n) {
  var result = [];
  var s = (n * (n + 1)) / 2;

  for (let i = Math.floor(n / 2); i <= n; i++) {
    let b = Math.floor((s - i) / (i + 1));
    if (b * i + b + i === s) {
      result.push([b, i]);
    }
  }

  return result;
}

function removeNb_kata_1(n) {
  // from the instruction:
  // a * b = S(n) - a - b

  // and the sum of all first n natural numbers is
  // S(n) = n * (n + 1) / 2

  // so we can refrase the first formula like this:
  // a * b = n * (n + 1) / 2 - a - b
  // a * b + b = n * (n + 1) / 2 - a
  // b * (a + 1) = n * (n + 1) / 2 - a
  // b = (n * (n + 1) / 2 - a) / (a + 1)

  // but a and b are natural and up to n

  var results = [];
  for (var a = Math.floor(n / 2); a < n; a++) {
    var b = ((n * (n + 1)) / 2 - a) / (a + 1);
    if (b % 1 === 0 && b <= n) results.push([a, b]);
  }
  return results;
}

console.log(removeNb_kata_1(101));
