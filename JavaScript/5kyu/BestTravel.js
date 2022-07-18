function chooseBestSum(t, k, ls) {
  var arr = [];

  rec(0, ls, k, arr);

  var sol = arr.sort((a, b) => b - a).find((a) => a <= t);
  return typeof sol == "undefined" ? null : sol;
}

const rec = (sum, ar, n, arr) => {
  if (n == 0) {
    arr.push(sum);
  } else {
    for (let i = 0; i < ar.length; i++) {
      rec(sum + ar[i], ar.slice(i + 1), n - 1, arr);
    }
  }
};

var ts = [50, 55, 56, 57, 58];
console.log(chooseBestSum(163, 3, ts));
