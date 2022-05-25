function productFib(prod) {
  let i = 1;
  let n1 = 0;
  let n2 = 1;
  let result = false;

  while (true) {
    n1 = fib(i - 1);
    n2 = fib(i);

    if (n1 * n2 >= prod) {
      break;
    }

    i++;
  }

  return [n1, n2, n1 * n2 == prod];
}

function fib(n) {
  let tab = [0, 1];

  if (n == 0) {
    return 0;
  }

  if (n == 1) {
    return 1;
  }

  for (let i = 1; i < n; i++) {
    let tmp = tab[1];
    tab[1] = tab[0] + tab[1];
    tab[0] = tmp;
  }

  return tab[1];
}

function productFib_kata_1(prod) {
  var n = 0;
  var nPlus = 1;

  while (n * nPlus < prod) {
    nPlus = n + nPlus;
    n = nPlus - n;
  }

  return [n, nPlus, n * nPlus == prod];
}

console.log(productFib_kata_1(74049690));
