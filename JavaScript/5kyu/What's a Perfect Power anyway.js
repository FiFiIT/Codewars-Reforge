var isPP = function (n) {
  var border = parseInt(n ** 1 / 2);

  for (let i = 2; i <= border; border--) {
    var r = Math.round(Math.log(n) / Math.log(border));

    if (border ** r == n) {
      return [border, r];
    }
  }

  return null;
};

// var result = isPP(9);
// console.log(result);

var k, m, i, r, l;
for (i = 0; i < 100; ++i) {
  (m = (2 + Math.random() * 0xff) | 0),
    (k = (2 + (Math.random() * Math.log(0x0fffffff)) / Math.log(m)) | 0);
  l = Math.pow(m, k);
  r = isPP(l);
  if (r === null) {
    console.log(l + " is a perfect power");
    break;
  } else if (Math.pow(r[0], r[1]) !== l) {
    console.log(
      Math.pow(r[0], r[1]),
      l,
      "your pair (" + r[0] + ", " + r[1] + ") doesn't work for " + l
    );
    break;
  }
}
