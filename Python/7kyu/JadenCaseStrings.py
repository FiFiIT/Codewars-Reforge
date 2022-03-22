import string


def to_jaden_case(phrase):
    return " ".join(w[0].upper() + w[1:] for w in phrase.split())


def to_jaden_case_2(phrase):
    return " ".join(w.capitalize() for w in phrase.split())


def to_jaden_case_3(phrase):
    return string.capwords(phrase)


print(to_jaden_case_3("How can mirrors be real if our eyes aren't real"))
