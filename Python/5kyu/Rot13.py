def rot13(message):
    return "".join([cypher(c) if c.isalpha() else c for c in message])


def cypher(c):
    next = ord(c)

    if next > 77 and next < 91 or next > 109 and next < 123:
        return chr(next - 13)

    return chr(next + 13)


print(rot13("10+2 is twelve."))
