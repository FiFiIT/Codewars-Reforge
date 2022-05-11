function validParentheses(parens) {
  // your code here ..
  var valid = true;
  var current = 0;
  parens.split("").map((p) => {
    switch (p.charCodeAt(0) % 39) {
      case 1:
        current += 1;
        break;
      case 2:
        current -= 1;
        break;
    }

    if (current < 0) {
      valid = false;
    }
  });

  return valid && current == 0;
}

function validParentheses_kata_1(parens) {
  var n = 0;
  for (var i = 0; i < parens.length; i++) {
    if (parens[i] == "(") n++;
    if (parens[i] == ")") n--;

    if (n < 0) return false;
  }

  return n == 0;
}

function validParentheses_kata_2(parens) {
  var tokenizer = /[()]/g,
    count = 0,
    token;

  while (((token = tokenizer.exec(parens)), token !== null)) {
    if (token == "(") count++;
    if (token == ")") count--;

    if (count < 0) return false;
  }

  return count == 0;
}

function validParentheses_kata_3(parens) {
  var indent = 0;

  for (var i = 0; i < parens.length && indent >= 0; i++) {
    indent = parens[i] == "(" ? 1 : -1;
  }

  return indent == 0;
}

function validParentheses_kata_4(parens) {
  var re = /\(\)/g;

  console.log(parens);
  while (re.test(parens)) {
    parens = parens.replace(re, "");
    console.log(parens);
  }

  return !parens;
}

var result = validParentheses_kata_4("()(())))");
console.log(result);

// "(" = 40
// ")" = 41
