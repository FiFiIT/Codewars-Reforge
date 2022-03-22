var translate = {
  A: "T",
  T: "A",
  G: "C",
  C: "G",
};

function DNAStrand(dna) {
  return dna
    .split("")
    .map((d) => translate[d])
    .join("");
}

function DNAStrand_2(dna) {
  return dna.replace(/./g, (w) => translate[w]);
}

console.log(DNAStrand_2("ATTGC"));
