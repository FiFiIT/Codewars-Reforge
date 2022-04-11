function createPhoneNumber(numbers) {
  numbers = numbers.join("");
  return (
    "(" +
    numbers.substring(0, 3) +
    ") " +
    numbers.substring(3, 6) +
    "-" +
    numbers.substring(6)
  );
}

function createPhoneNumber_2(numbers) {
  var format = "(xxx) xxx-xxxx";

  for (let i = 0; i < numbers.length; i++) {
    format = format.replace("x", numbers[i]);
  }

  return format;
}

var resutl = createPhoneNumber_2([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]);
console.log(resutl);
