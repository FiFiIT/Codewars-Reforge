const doneOrNot = (board) => (isDone(board) ? "Finished!" : "Try again!");

const isDone = (sudoku) => {
  for (let i = 0; i < 9; i++) {
    //check rows
    var rows = sudoku[i].reduce((a, v) => (a += v), 0);
    var cols = sudoku.reduce((a, v) => (a += v[i]), 0);

    let start = 3 * Math.floor(i / 3);
    let end = start + 3;

    var block = sudoku.slice(start, end).reduce((a, v) => {
      let start = 3 * (i % 3);
      let end = start + 3;

      var sl = v.slice(start, end);
      a += sl.reduce((a, v) => (a += v), 0);
      return a;
    }, 0);

    if ([rows, cols, block].some((v) => v != 45)) {
      return false;
    }
  }

  return true;
};

var result = doneOrNot([
  [5, 3, 4, 6, 7, 8, 9, 1, 2],
  [6, 7, 2, 1, 9, 5, 3, 4, 8],
  [1, 9, 8, 3, 4, 2, 5, 6, 7],
  [8, 5, 9, 7, 6, 1, 4, 2, 3],
  [4, 2, 6, 8, 5, 3, 7, 9, 1],
  [7, 1, 3, 9, 2, 4, 8, 5, 6],
  [9, 6, 1, 5, 3, 7, 2, 8, 4],
  [2, 8, 7, 4, 1, 9, 6, 3, 5],
  [3, 4, 5, 2, 8, 6, 1, 7, 9],
]);

console.log(result);

export { doneOrNot };
