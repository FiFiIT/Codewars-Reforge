function brainLuck(code, input) {
  var inp = 0;
  var p = 0;
  var data = new Array(32).fill(0);
  var output = "";

  for (let i = 0; i < code.length > 0; i++) {
    if (code[i] == ">") p++;
    if (code[i] == "<") p--;
    if (code[i] == "+") {
      if (data[p] == 255) {
        data[p] = 0;
      } else {
        data[p]++;
      }
    }
    if (code[i] == "-") {
      if (data[p] == 0) {
        data[p] = 255;
      } else {
        data[p]--;
      }
    }
    if (code[i] == ",") {
      if (input[inp]) {
        data[p] = input[inp].charCodeAt(0);
      } else {
        data[p] = 0;
      }
      inp++;
    }
    if (code[i] == ".") {
      output += String.fromCharCode(data[p]);
    }
    if (code[i] == "[" && data[p] == 0) i = BMatch(code, i, -1, 1, "]");
    if (code[i] == "]" && data[p] != 0) i = BMatch(code, i, 1, -1, "[");
  }

  return output;
}

function BMatch(code, i, b, dir, pair) {
  if (code[i] == pair && b == 0) return i;
  if (code[i] == "[") b++;
  if (code[i] == "]") b--;
  return BMatch(code, i + dir, b, dir, pair);
}

function brainLuck_kata(code, input) {
  var data = [],
    pos = 0,
    ipos = 0,
    output = [],
    skipping = 0,
    backwards = 0;

  var COMMANDS = {
    ">": () => ++pos,
    "<": () => --pos,
    "+": () => (data[pos] = ((data[pos] || 0) + 1) % 256),
    "-": () => (data[pos] = ((data[pos] || 0) + 255) % 256),
    ".": () => output.push(data[pos]),
    ",": () => (data[pos] = (input[ipos++] || "").charCodeAt()),
    "[": () => (!data[pos] ? (skipping = 1) : null),
    "]": () => (data[pos] ? (backwards = 1) : null),
  };

  for (var cpos = 0, l = code.length; cpos <= l; ++cpos) {
    if (skipping) {
      if (code[cpos] === "[") {
        skipping++;
      }
      if (code[cpos] === "]") {
        skipping--;
      }
    } else if (backwards) {
      cpos -= 2;
      if (code[cpos] === "]") {
        backwards++;
      }
      if (code[cpos] === "[") {
        backwards--;
      }
    } else {
      code[cpos] && COMMANDS[code[cpos]]();
    }
  }

  return String.fromCharCode.apply(null, output);
}

var result = brainLuck_kata(
  ",>,<[>[->+>+<<]>>[-<<+>>]<<<-]>>.",
  String.fromCharCode(8, 9)
);
console.log(result);
