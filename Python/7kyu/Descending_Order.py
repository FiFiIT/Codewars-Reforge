def descending_order(num):
    lst = [n for n in str(num)]
    lst.sort(reverse=True)
    return int("".join(lst))


def descending_order_1(num):
    return int("".join(sorted(str(num), reverse=True)))


def descending_order_2(num):
    if isinstance(num, int) and num >= 0:
        return int("".join(sorted(str(num), reverse=True)))

    raise ValueError("Non-negative integer expected")


result = descending_order_2(46)
print(result)
