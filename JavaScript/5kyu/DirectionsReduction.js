function dirReduc(arr) {
  var directions = { NORTH: 0, WEST: 1, SOUTH: 0, EAST: 1 };

  var reducing = false;
  var start = true;
  while (reducing || start) {
    start = false;
    reducing = false;
    for (let i = 1; i < arr.length; i++) {
      if (
        arr[i - 1] != arr[i] &&
        directions[arr[i - 1]] == directions[arr[i]]
      ) {
        arr.splice(i - 1, 2);
        reducing = true;
        break;
      }
    }
  }

  return arr;
}

function dirReduc_kata_1(plan) {
  var opposite = {
    NORTH: "SOUTH",
    EAST: "WEST",
    SOUTH: "NORTH",
    WEST: "EAST",
  };

  return plan.reduce(function (dirs, dir) {
    if (dirs[dirs.length - 1] === opposite[dir]) dirs.pop();
    else dirs.push(dir);
    return dirs;
  }, []);
}

function dirReduc_kata_2(plan) {
  var str = plan.join("");
  var pattern = /NORTHSOUTH|EASTWEST|SOUTHNORTH|WESTEAST/;

  while (pattern.test(str)) {
    str = str.replace(pattern, "");
  }

  return str.match(/(NORTH|SOUTH|EAST|WEST)/g) || [];
}

var input = [
  "EAST",
  "EAST",
  "WEST",
  "NORTH",
  "WEST",
  "EAST",
  "EAST",
  "SOUTH",
  "NORTH",
  "WEST",
];
var result = dirReduc_kata_2(input);

console.log(result);
