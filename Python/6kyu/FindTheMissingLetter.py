def find_missing_letter(chars):
    first = ord(chars[0])
    for x in range(0, len(chars)):
        if first != ord(chars[x]):
            return chr(first)

        first += 1


def find_missing_letter_kata(chars):
    n = 0
    while ord(chars[n]) == ord(chars[n]) - 1:
        n += 1

    return chr(ord(chars[n])+1)


result = find_missing_letter(['a', 'b', 'c', 'd', 'f'])
print(result)
