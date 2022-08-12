function ipsBetween(start, end) {
  return ipValue(end) - ipValue(start);
}

const ipValue = (ip) => ip.split(".").reduce((a, v) => (a << 8) | v) >>> 0;

var result = ipsBetween("150.0.0.0", "150.0.0.1");
console.log(result);
