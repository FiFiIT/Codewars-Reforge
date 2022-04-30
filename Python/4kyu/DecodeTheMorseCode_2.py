import re


def decode_bits(bits):
    clean_bits = bits.strip('0')

    # zero = get_rate(clean_bits, "1")
    # one = get_rate(clean_bits, "0")
    # rate = min(zero + one)

    rate = min([len(x) for x in re.findall(r'1+|0+', clean_bits)])

    clean_bits = clean_bits.replace("0" * 7 * rate, "   ")
    clean_bits = clean_bits.replace("0" * 3 * rate, " ")
    clean_bits = clean_bits.replace("1" * 3 * rate, "-")
    clean_bits = clean_bits.replace("1" * rate, ".")
    clean_bits = clean_bits.replace("0" * rate, "")

    return clean_bits


def get_rate(str, deli):
    return [len(x) for x in str.split(deli) if len(x) > 0]


def decode_morse(morseCode):
    # ToDo: Accept dots, dashes and spaces, return human-readable message
    result = []
    for word in morseCode.split("   "):
        w = "".join([MORSE_CODE[letter] for letter in word.split(" ")])
        result.append(w)

    return " ".join(result)


input = "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"
result = decode_bits(input)
print(result)
result = decode_morse(result)
print(result)
