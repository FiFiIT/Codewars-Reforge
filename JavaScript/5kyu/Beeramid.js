var beeramid = function (bonus, price) {
  var cans = Math.ceil(bonus / price);
  var pyramid = 0;

  for (let i = 1; cans > 0; i++) {
    cans -= Math.pow(i, 2);
    pyramid += cans > 0 ? 1 : 0;
  }

  return pyramid;
};

var beeramid2 = function (bonus, price) {
  var beers = Math.floor(bonus / price);
  var level = 0;

  while (beers >= (++level) ** level) {
    beers -= level ** level;
  }

  return level;
};

var result = beeramid(9, 2);
console.log(result);
