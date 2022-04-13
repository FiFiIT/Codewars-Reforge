function isValidWalk(walk) {
  var n = walk.filter((w) => w == "n").length;
  var s = walk.filter((w) => w == "s").length;
  var e = walk.filter((w) => w == "e").length;
  var w = walk.filter((w) => w == "w").length;

  var valid = n == s && e == w;

  return valid ? true : false;
}

function isValidWalk_kata(walk) {
  var dx = 0;
  var dy = 0;
  var dt = walk.length;

  for (let i = 0; i < walk.length; i++) {
    switch (walk[i]) {
      case "n":
        dy++;
      case "s":
        dy--;
      case "e":
        dx++;
      case "w":
        dy--;
      default:
        dt = -1;
    }
  }

  return dt == 10 && dx == 0 && dy == 0;
}

var result = isValidWalk(["w", "n"]);
console.log(result);
