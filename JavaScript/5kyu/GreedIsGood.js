function score(dice) {
  var tripple = [0, 1000, 200, 300, 400, 500, 600];
  var other = [0, 100, 0, 0, 0, 50, 0];

  var result = 0;

  for (var diceSide = 1; diceSide <= 6; diceSide++) {
    var rolls = dice.filter((r) => r == diceSide).reduce((a, v) => (a += 1), 0);
    result +=
      tripple[diceSide] * parseInt(rolls / 3) + other[diceSide] * (rolls % 3);
  }

  return result;
}

// score([2, 3, 4, 6, 2]);

export { score };
