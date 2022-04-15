def alphabet_position(text):
    # ord() returns the Unicode code point of that character
    return " ".join([str(ord(c) - 96) for c in text.lower() if c.isalpha()])


result = alphabet_position("The sunset sets at twelve o' clock.")
print(result)
