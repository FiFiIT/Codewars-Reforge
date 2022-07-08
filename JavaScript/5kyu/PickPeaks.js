function pickPeaks(arr) {
  var pos = 0,
    peak = 0;

  var result = { pos: [], peaks: [] };

  for (let i = 1; i < arr.length - 1; i++) {
    if (arr[i] > arr[i - 1]) {
      pos = i;
      peak = arr[i];
    }
    if (arr[i] > arr[i + 1] && pos != 0) {
      result.pos.push(pos);
      result.peaks.push(peak);

      pos = 0;
      peak = 0;
    }
  }

  return result;
}

var result = pickPeaks([1, 2, 3, 6, 4, 1, 2, 3, 2, 1]);
console.log(result);
