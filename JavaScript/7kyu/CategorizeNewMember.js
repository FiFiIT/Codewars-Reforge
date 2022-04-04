function openOrSenior(data) {
  return data.map(([age, handicap]) =>
    age >= 55 && handicap > 7 ? "Senior" : "Open"
  );
}

function openOrSenior_fifi(data) {
  return data.reduce((pV, cV, cI) => {
    var result = cV[0] >= 55 && cV[1] > 7 ? "Senior" : "Open";

    pV.push(result);

    return pV;
  }, []);
}

export { openOrSenior };

var result = openOrSenior([
  [45, 12],
  [55, 21],
  [19, -2],
  [104, 20],
]);

console.log(result);
