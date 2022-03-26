function longest(s1, s2) {
  return Array.from(new Set(s1 + s2))
    .sort()
    .join("");
}

const longest_2 = (s1, s2) => [...new Set(s1 + s2)].sort().join("");

var result = longest_2("loopingisfunbutdangerous", "lessdangerousthancoding");
var expected = "abcdefghilnoprstu";
console.log(result == expected);

//
