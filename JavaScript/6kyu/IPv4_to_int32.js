String.prototype.toBin = function () {
  return (this >> 0).toString(2).padStart(8, "0");
};

function ipToInt32(ip) {
  var binary = ip
    .split(".")
    .map((p) => (p >> 0).toString(2).padStart(8, "0"))
    .join("");

  console.log(binary);

  return parseInt(binary, 2);
}

//>>> Zero fill right shift	Shifts right by pushing zeros in from the left, and let the rightmost bits fall off
const ipToInt32_2 = (ip) => ip.split(".").reduce((a, b) => (a << 8) | b) >>> 0;

function ipToInt32_3(ip) {
  return ip.split(".").reduce((acc, num) => acc * 256 + +num);
}

console.log(1 + +5);

console.log(ipToInt32_3("128.32.10.1"));
// console.log(ipToInt32_2("128.32.10.1"));
