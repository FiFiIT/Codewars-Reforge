def is_isogram(str):
    return len(set(str.lower())) == len(str)


def is_isogram1(str):
    str = str.lower()
    for letter in str:
        if str.count(letter) > 1:
            return False
    return True
