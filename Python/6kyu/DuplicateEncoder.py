def duplicate_encode(word):
    # word = list(map(lambda x: x.lower(), word))
    word = word.lower()

    return "".join(["(" if word.count(w) == 1 else ")" for w in word])


print(duplicate_encode("(BfwTLPP!vJ@BYETECVtXRHArbU@VDaGn!"))
