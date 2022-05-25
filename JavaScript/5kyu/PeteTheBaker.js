function cakes_fifi(recipe, available) {
  var result = [];

  for (const [key, value] of Object.entries(recipe)) {
    if (key in available) {
      result.push(Math.floor(available[key] / recipe[key]));
    } else {
      result.push(0);
    }
  }
  return result;
  return Math.min(...result);
}

function cakes_kata_1(recipe, available) {
  return Object.keys(recipe).reduce((p, c) => {
    let v = Math.floor(available[c] / recipe[c] || 0);
    return Math.min(v, p);
  }, Infinity);
}

let recipe = { flour: 500, sugar: 200, eggs: 1 };
let available = { flour: 1200, sugar: 1200, eggs: 5, milk: 200 };

recipe = { apples: 3, flour: 300, sugar: 150, milk: 100, oil: 100 };
available = { sugar: 500, flour: 2000, milk: 2000 };

let result = cakes_kata_1(recipe, available);
console.log(result);
