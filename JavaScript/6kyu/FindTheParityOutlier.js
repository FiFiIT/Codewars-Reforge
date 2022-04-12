function findOutlier(integers) {
  var odd = integers.filter((i) => i % 2 != 0);
  var even = integers.filter((i) => i % 2 == 0);

  return odd.length == 1 ? odd[0] : even[0];
}

console.log(findOutlier([1, 1, 0, 1, 1]));
