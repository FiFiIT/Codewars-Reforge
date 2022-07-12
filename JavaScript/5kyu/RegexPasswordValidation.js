function validate(password) {
  // only alphanumeric
  var alphanumeric = !/[^a-z0-9_]/gi.test(password);
  var upperCase = /([A-Z])/g.test(password);
  var lowerCase = /([a-z])/g.test(password);
  var containsNumber = /\d/g.test(password);
  var sixCharsLong = /.{6,}/g.test(password);

  return (
    alphanumeric == true &&
    upperCase == true &&
    lowerCase == true &&
    containsNumber == true &&
    sixCharsLong == true
  );
}

console.log(validate("test"));

export { validate };
