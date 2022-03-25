def get_middle(s):
    start = int((len(s) - 1) / 2)
    end = start + (2 - len(s) % 2)

    if s:
        return s[start:end]

    return s


def get_middle_1(s):
    index, odd = divmod(len(s), 2)
    return s[index] if odd else s[index - 1: index + 1]


if __name__ == "__main__":
    result = get_middle_1("testing")
    print(result)
