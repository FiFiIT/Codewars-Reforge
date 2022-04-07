function arrayDiff(a, b) {
  return a.filter((v) => !b.includes(v));
}

var result = arrayDiff([1, 2, 3], [1, 2]);
console.log(result);
