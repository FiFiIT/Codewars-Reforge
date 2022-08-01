def last_digit(n1, n2):
    if n2 == 0:
        return 1
    n1 = n1 % 10

    n2 = 4 if n2 % 4 == 0 else n2 % 4

    return (n1 ** n2) % 10


def last_digit_kata_1(n1, n2):
    return pow(n1, n2, 10)


def last_digit_kata_2(n1, n2):
    return ((n1 % 10) ** (n2 % 4 + 4)) % 10
