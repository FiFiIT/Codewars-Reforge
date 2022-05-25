function rgb(r, g, b) {
  return r.hex() + g.hex() + b.hex();
}

Number.prototype.hex = function () {
  var value = Math.max(0, Math.min(255, this));
  return value.toString(16);
};

console.log(rgb(173, 255, 47));
