function solution(number) {
  var sum = 0;

  for (let i = 3; i < number; i++) {
    if (i % 3 == 0 || i % 5 == 0) {
      sum += i;
    }
  }

  return sum;
}

var result = solution(10);
console.log(result);
