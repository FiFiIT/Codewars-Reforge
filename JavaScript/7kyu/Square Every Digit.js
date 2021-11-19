function squareDigits(num) {
  return parseInt(
    num
      .toString()
      .split("")
      .map((n) => n ** 2)
      .join("")
  );
}

// var result = squareDigits(3212);
// console.log(result);

export { squareDigits };
