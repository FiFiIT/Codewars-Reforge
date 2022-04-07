from math import floor


import math


def digital_root(n):

    if n > 9:
        n = sum([int(l) for l in list(str(n))])
        n = digital_root(n)

    return n


def digital_root_kata(n):
    return n if n < 10 else digital_root(sum(map(int, n)))


print(digital_root(942))
