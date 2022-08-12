function brainLuck(code, input) {
  let pointer = 0;
  code.map(interpreter);

  function interpreter(c) {
    switch (c) {
      case ",":
        input.slice(0, 1);
        break;
    }
  }
  return output;
}

var result = brainLuck(",+[-.,+]", "Codewars" + String.fromCharCode(255));
