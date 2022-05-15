function humanReadable(seconds) {
  var hours = Math.floor(seconds / 3600);
  var minutes = Math.floor(seconds / 60) % 60;
  var sec = Math.floor(seconds % 60);

  return `${hours.zeors()}:${minutes.zeors()}:${sec.zeors()}`;
}

Number.prototype.zeors = function () {
  return this.toString().padStart(2, "0");
};

console.log(humanReadable(0));
