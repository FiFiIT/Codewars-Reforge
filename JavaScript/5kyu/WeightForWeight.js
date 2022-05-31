function orderWeight(strng) {
  return strng
    .split(" ")
    .sort((a, b) => {
      if (a.weight() == b.weight()) {
        return a > b ? 1 : -1;
      }

      return a.weight() - b.weight();
    })
    .join(" ");
}

function orderWeight_kata_1(strng) {
  return strng
    .split(" ")
    .sort((a, b) =>
      a.weight() == b.weight() ? a.localeCompare(b) : a.weight() - b.weight()
    )
    .join(" ");
}

String.prototype.weight = function () {
  return this.split("").reduce((p, c) => p + parseInt(c), 0);
};

var result = orderWeight_kata_1(
  "2000 10003 1234000 44444444 9999 11 11 22 123"
);
console.log("11 11 2000 10003 22 123 1234000 44444444 9999");
console.log(result);
