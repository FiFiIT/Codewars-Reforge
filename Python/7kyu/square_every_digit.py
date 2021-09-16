def square_digits(num) -> int:
    return int(''.join(str(int(n)**2) for n in str(num)))


def square_digits_1(num):
    ret = ""
    for x in str(num):
        ret += str(int(x)**2)

    return int(ret)


if __name__ == "__main__":
    r = square_digits_1(9119)
    print(r)
