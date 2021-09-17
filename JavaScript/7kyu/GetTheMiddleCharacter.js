function getMiddle_1(s) {
  var index = (s.length - 1) / 2;
  var end = index + 2 - (s.length % 2);

  return s.substring(index, end);
}

function getMiddle(s) {
  return s.substr((s.length - 1) / 2, 2 - (s.length % 2));
}

var r = getMiddle("testing");
console.log(r);

export { getMiddle };
