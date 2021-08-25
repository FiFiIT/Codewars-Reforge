function accum(s) {
  return s
    .split("")
    .map((a, i) => a.toUpperCase() + a.toLowerCase().repeat(i))
    .join("-");
}

// var testObject = "EvidjUnokmM";
// var result = accum(testObject);
// console.log(result);

export { accum };
