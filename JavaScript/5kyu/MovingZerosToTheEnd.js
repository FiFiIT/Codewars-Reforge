function moveZeros(arr) {
  var zeros = arr.filter((a) => !isNaN(a) && a === 0);
  console.log(zeros);
  var a = arr.filter((a) => {
    if (Number.isInteger(a) && a === 0) {
      return false;
    }

    return true;
  });

  return a.concat(zeros);
}

function moveZeros_kata(arr) {
  return arr.filter((x) => x !== 0).concat(arr.filter((x) => x === 0));
}
