function sum_pairs(ints, s) {
  var seen = {};
  for (var i = 0; i < ints.length; ++i) {
    if (seen[s - ints[i]]) return [s - ints[i], ints[i]];
    seen[ints[i]] = true;
  }

  return [];
}

var l5 = [10, 5, 2, 3, 7, 5];
var result = sum_pairs(l5, 10);
console.log(result);
