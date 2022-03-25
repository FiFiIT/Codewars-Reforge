function maskify(cc) {
  const len = cc.length - 4;

  if (len <= 0) {
    return cc;
  }

  return "#".repeat(len) + cc.substr(len);
}

function maskify_2(cc) {
  return cc.replace(/\d(?=....)/g, "#");
}

var result = maskify_2("11111231231231");
console.log(result);
