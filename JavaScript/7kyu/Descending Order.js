function descendingOrder(n) {
  return parseInt(
    n
      .toString()
      .split("")
      .sort((a, b) => b - a)
      .join("")
  );
}

function descendingOrder_1(n) {
  return parseInt(String(n).split("").sort().reverse().join(""));
}

var result = descendingOrder_1(15);
console.log(result);

export { descendingOrder };
