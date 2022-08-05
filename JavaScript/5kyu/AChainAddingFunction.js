function add(n) {
  var fn = function (x) {
    return add(n + x);
  };

  fn.valueOf = function () {
    return n;
  };

  return fn;
}

var r = add(1)(2)(3)(4)(5);
console.log(r == 16);
