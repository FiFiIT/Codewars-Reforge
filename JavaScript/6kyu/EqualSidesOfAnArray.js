function findEvenIndex(arr) {
  var total = arr.reduce((a, b) => a + b);
  var sum = 0;
  var index = -1;

  if (total == 0) {
    return 0;
  }

  arr.map((v, i) => {
    total -= v;
    if (sum == total) {
      index = i;
    }
    sum += v;
  });

  return index;
}
// Kata
{
  const sum = (a, from, to) => a.slice(from, to).reduce((a, b) => a + b, 0);
  const findEvenIndex = (a) =>
    a.findIndex((el, i) => sum(a, 0, i) === sum(a, i + 1));
}

var result = findEvenIndex([1, 2, 3, 4, 3, 2, 1]);
console.log(result);
