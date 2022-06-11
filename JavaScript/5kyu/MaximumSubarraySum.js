var maxSequence = function (arr) {
  var res = 0;
  for (var i = 0; i < arr.length; i++) {
    var sum = 0;
    for (var j = i; j < arr.length; j++) {
      sum += arr[j];
      res = Math.max(res, sum);
    }
  }

  return res;
};

function maxSequence_kata_2(arr) {
  var res = arr.reduce(
    (p, v) => {
      p.sum += v;
      p.max = p.sum < p.max ? p.sum : p.max;
      p.res = p.sum - p.max > p.res ? p.sum - p.max : p.res;

      return p;
    },
    { sum: 0, max: 0, res: 0 }
  );

  return res;
}

function maxSequence_kata_3(arr) {
  var sum = 0,
    max = 0,
    res = 0;

  arr.map((v) => {
    sum += v;
    max = sum < max ? sum : max;
    res = sum - max > res ? sum - max : res;
  });

  return res;
}

function maxSequence_kata_4(arr) {
  var currentSum = 0;
  return arr.reduce((maxSum, v) => {
    currentSum = Math.max(currentSum + v, 0);
    return Math.max(currentSum, maxSum);
  }, 0);
}

var result = maxSequence_kata_4([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
console.log(result);
