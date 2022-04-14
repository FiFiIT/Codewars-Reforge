function persistence(num) {
  var loops = 0;

  while (num > 9) {
    num = num
      .toString()
      .split("")
      .reduce((a, b) => a * b);
    loops++;
  }

  return loops;
}

var result = persistence(999);
console.log(result);
