function isIsogram(str) {
  let uniq = "";
  str = str.toLowerCase();

  for (let i = 0; i < str.length; i++) {
    if (uniq.includes(str[i]) == false) {
      uniq += str[i];
    } else {
      return false;
    }
  }

  return true;
}

function isIsogram1(str) {
  return !/(\w).*\1/i.test(str);
}

function isIsogram2(str) {
  return new Set(str.toUpperCase()).size == str.length;
}

export { isIsogram };
