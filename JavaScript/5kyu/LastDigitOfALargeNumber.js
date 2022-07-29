var lastDigit = function (str1, str2) {
  if (str2 == "0") return 1;

  var n = parseInt(str1.slice(-1));
  var pow = str2.slice(-2) % 4;

  if (pow == 0) pow = 4;

  var result = Math.pow(n, pow);

  return result % 10;
};

// lastDigit(
//   "3715290469715693021198967285016729344580685479654510946723",
//   "68819615221552997273737174557165657483427362207517952651"
// );

export { lastDigit };
