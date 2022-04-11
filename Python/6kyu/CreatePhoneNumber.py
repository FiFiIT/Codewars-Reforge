def create_phone_number(n):
    n = "".join(map(str, n))

    result = "({}) {}-{}".format(n[:3], n[3:6], n[6:])

    return result


def create_phone_number(n):
    return "({}{}{}) {}{}{}-{}{}{}{}".format(*n)


# input = [0, 2, 3, 0, 5, 6, 0, 8, 9, 0]
# print(*input)

# result = create_phone_number([0, 2, 3, 0, 5, 6, 0, 8, 9, 0])
# print(result)
