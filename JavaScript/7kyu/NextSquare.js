function findNextSquare(s) {
  return s ** 0.5 % 1 == 0 ? (s ** 0.5 + 1) ** 2 : -1;
}

console.log(findNextSquare(625));
