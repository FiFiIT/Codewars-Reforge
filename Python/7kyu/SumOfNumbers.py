import sys


def get_sum(a, b):
    tab = sorted([a, b])

    return sum(x for x in range(tab[0], tab[1]+1))


def get_sum_2(a, b):
    return sum(range(min(a, b), max(a, b)))


def get_sum_3(a, b):
    return (a+b) * (abs(a-b) + 1) // 2  # floor division


def firstn(n):
    num = 0
    while num < n:
        yield num
        num += 1
