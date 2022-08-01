function add(n) {
  if (!b) return n;

  return function (b) {
    return n + b;
  };
}

console.log(add(1)(2)(3));
