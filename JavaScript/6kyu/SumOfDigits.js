function digital_root(n) {
  return n < 10 ? n : digital_root(Math.floor(n / 10) + (n % 10));
}
