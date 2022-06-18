function scramble(str1, str2) {
  return str2.split("").every((v) => {
    var r1 = (str1.match(new RegExp(`${v}+`, "gi")) || []).length;
    var r2 = str2.match(new RegExp(`${v}+`, "gi")).length;

    return r1 >= r2;
  });
}

function scramble_kata_1(str1, str2) {
  let occurence = str1.split("").reduce((arr, curr) => {
    arr[curr] ? arr[curr]++ : (arr[curr] = 1);
    return arr;
  }, {});

  return str2.split("").every((c) => --occurence[c] >= 0);
}

var result = scramble("scriptjavx", "javascript");
console.log(result);
