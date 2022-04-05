function findOdd_fifi(A) {
  return A.find((e) => A.filter((a) => a == e).length % 2 != 0);
}

function findOdd(A) {
  //   return A.reduce((a, b) => a ^ b);
  A.reduce((a, b) => {
    let sum = a ^ b;
    console.log(
      a.toString(2).padStart(8),
      b.toString(2).padStart(8),
      sum.toString(2).padStart(8)
    );
    return sum;
  });

  return -1;
}

var result = findOdd([20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5]);
console.log(result);
