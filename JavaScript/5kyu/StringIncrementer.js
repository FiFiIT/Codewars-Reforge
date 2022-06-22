String.prototype.isLetter = function () {
  return /[a-z]/i.test(this);
  return this.toUpperCase() != this.toLocaleLowerCase();
};

const zeroPad = (num, places) => String(num).padStart(places, "0");

function incrementString(strng) {
  var s = strng.split("").reduce(
    (acc, v) => {
      if (v.isLetter()) {
        acc.s += v;
      } else {
        acc.n += v;
      }

      return acc;
    },
    { s: "", n: "" }
  );

  return (
    s["s"] + String(parseInt(s["n"] || 0) + 1).padStart(s["n"].length, "0")
  );
}

function incrementString_kata_1(strng) {
  if (isNaN(parseInt(strng[strng.length - 1]))) {
    return strng + "1";
  }

  return strng.replace(/(0*)([0-9]+$)/, (match, p1, p2) => {
    var up = parseInt(p2) + 1;
    return up.toString().length > p2.length ? p1.slice(0, -1) + up : p1 + up;
  });
}

function incrementString_kata_2(strng) {
  // + before "e" parse it to int so we could change "09" into "10" instead of "010"
  return strng.replace(/([0-8]|\d?9+)?$/, (e) => (e ? +e + 1 : 1));
}

var result = incrementString_kata_2("009");
console.log(result);

console.log(+"009" + 1);
