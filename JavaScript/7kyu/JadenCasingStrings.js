String.prototype.toJadenCase = function () {
  return this.split(" ")
    .map((w) => w.charAt(0).toUpperCase() + w.slice(1))
    .join(" ");
};

String.prototype.toJadenCase_2 = function () {
  return this.replace(/(^|\s)([a-z])/g, (w) => w.toUpperCase());
};

console.log("How can mirrors be real if our eyes aren't real".toJadenCase_2());
