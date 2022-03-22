import enum

dict = {
    "A": "T",
    "T": "A",
    "G": "C",
    "C": "G"
}


def DNA_strand(dna):
    return "".join([dict[d] for d in dna])


print(DNA_strand("ATTGC"))
