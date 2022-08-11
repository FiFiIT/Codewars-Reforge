import math


def isPP(n):
    border = int(math.sqrt(n)) + 1

    for b in reversed(range(2, border)):
        e = round(math.log(n, b))
        print("{:<2} ** {} = {}".format(b, e, b ** e))
        if b ** e == n:
            return [b, e]

    return None


print(isPP(243))
