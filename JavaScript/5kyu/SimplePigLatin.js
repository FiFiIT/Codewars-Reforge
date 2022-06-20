function pigIt(str) {
  return str.replace(/\w+/g, (m) => m.slice(1) + m[0] + "ay");
}

function pigIt_kata(str) {
  return str.replace(/(\w)(\w*)(\s)/g, "$2$1ay$3");
}

var result = pigIt("Pig latin is cool !!");
console.log(result);
