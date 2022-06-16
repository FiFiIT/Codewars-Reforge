def first_non_repeating_letter(string):
    result = [s for s in string if string.lower().count(s.lower()) == 1]

    if result:
        return result[0]

    return ""


def first_non_repeating_letter_kata_1(string):
    string_lower = string.lower()

    for i, letter in enumerate(string_lower):
        if string_lower.count(letter) == 1:
            return string[i]

    return ""


print(first_non_repeating_letter('moonmen'))
