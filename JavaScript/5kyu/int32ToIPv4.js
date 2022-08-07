function int32ToIp(int32) {
  return [24, 16, 8, 0].map((v) => (int32 >> v) & 255).join(".");
}

var result = int32ToIp(2154959208);
console.log(result);
