function domainName(url) {
  return url.match(/(?:http(?:s)?:\/\/)?(?:w{3}\.)?([^\.]+)/i)[1];
}

function domainName_kata_2(url) {
  url = url.replace("https://", "");
  url = url.replace("http://", "");
  url = url.replace("www.", "");

  return url.split(".")[0];
}

// var result = domainName_kata_2(
//   "http://k84xap1b60zgxhbq6lre-vk-0q0.edu/index.php"
// );
// console.log(result);

export { domainName };
