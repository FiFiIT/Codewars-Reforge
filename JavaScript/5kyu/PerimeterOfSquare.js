function perimeter(n) {
  var a = 0;
  var b = 1;
  var c = a + b;
  var r = n > 0 ? 2 * c : c;

  for (let i = 2; i <= n; i++) {
    a = b;
    b = c;
    c = a + b;
    r += c;
  }

  return 4 * r;
}

console.log(perimeter(0));
console.log(perimeter(1));
console.log(perimeter(7));
console.log(perimeter(20));
