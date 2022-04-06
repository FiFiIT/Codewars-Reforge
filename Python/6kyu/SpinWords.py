def spin_words_fifi(sentence):
    return " ".join([spin(s) if len(s) >= 5 else s for s in sentence.split()])


def spin(word):
    return "".join([i[1] for i in sorted(enumerate(word), key=lambda x: x[0], reverse=True)])


def spin_words(sentence):
    return " ".join([s[::-1] if len(s) >= 5 else s for s in sentence.split()])


result = spin_words("Hey fellow warriors")
print(result)
