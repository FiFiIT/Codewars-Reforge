function josephus(items, k) {
  var pos = 0;
  var arr = [];
  while (items.length > 0) {
    pos = (pos + k - 1) % items.length;
    arr.push(items[pos]);
    items.splice(pos, 1);
  }

  return arr;
}
var result = josephus([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 2);
console.log(result);
