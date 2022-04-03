function validatePIN_fif(pin) {
  return pin.match(/[^\d]/) == null && (pin.length == 4 || pin.length == 6);
}

function validatePIN(pin) {
  return /^(\d{4}|\d{6})$/.test(pin);
}
