function getCount(str) {
  return (str.match(/[aeiou]/g) || []).length;
}

function getCount_1(str) {
  return str
    .split()
    .map((s) => "aeiou".includes(s))
    .join().length;
}

const getCount_2 = (str) => str.replace(/[^aeiou]/g, "").length;

// var r = getCount_2("abracuadabra");
// console.log(r);

export { getCount, getCount_1, getCount_2 };
