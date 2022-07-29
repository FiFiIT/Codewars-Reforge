const fibonacci = (num) => {
  var cashe = {};

  function traverse(num) {
    if (cashe[num]) return cashe[num];

    if (num == 0 || num == 1) return num;

    let result = traverse(num - 1) + traverse(num - 2);

    cashe[num] = result;

    return result;
  }

  return traverse(num);
};

console.log(fibonacci(70));
