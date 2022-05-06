function findUniq(arr) {
  var num = arr.slice(0, 3).find((n) => arr.filter((a) => a == n).length > 1);

  var i = 0;
  while (arr[i] == num) {
    i++;
  }

  return arr[i];
}

function findUniq_kata_1(arr) {
  arr.sort((a, b) => a - b);
  return arr[0] == arr[1] ? arr.pop() : arr[0];
}

function findUniq_kata_2(arr) {
  return arr.find((n) => arr.indexOf(n) === arr.lastIndexOf(n));
}

var result = findUniq_kata_2([1, 0, 0, 0, 0, 0, 0, 0]);
console.log(result);
