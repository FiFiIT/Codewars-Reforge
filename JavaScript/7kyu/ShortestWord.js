function findshort(s) {
  return Math.min(...s.split(" ").map((a) => a.length));
}
