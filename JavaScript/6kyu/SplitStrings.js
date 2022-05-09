function splitStrings_fifi(str) {
  return str.length > 0
    ? str
        .concat("_")
        .match(/\w{2}/g)
        .map((v) => v)
    : [];
}

function splitStrings(str) {
  return (str + "_").match(/.{2}/g) || [];
}

var result = splitStrings("abc");
console.log(result);
