import functools
import math


def convert_fracts_kata_2(lst):
    D = 1
    for _, d in lst:
        D *= d // GCD(d, D)

    return [[D * n // d, D] for n, d in lst]


def convert_fracts_kata_1(lst):
    tmp_list = list(map(lambda x: x[1], lst))
    lcm_num = functools.reduce(LCM, tmp_list)

    return list(map(lambda x: [x[0] * lcm_num // x[1], lcm_num], lst))


def convert_fracts(lst):
    l = 1
    for x in lst:
        l = LCM(l, x[1])

    return [[l//x[1] * x[0], l] for x in lst]


def LCM(a, b):
    return a * b // GCD(a, b)


def GCD(a, b):
    if b == 0:
        return a

    return GCD(b, a % b)


a = [[1, 2], [1, 3], [1, 4]]
# print(convert_fracts(a))

# print(convert_fracts_kata_1(a))

for _, d in a:
    print(d)
