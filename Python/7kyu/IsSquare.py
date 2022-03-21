import math


def is_square(n):
    return n > -1 and math.sqrt(n) % 1 == 0


def is_squre2(n):
    return n > -1 and n**0.5 % 1 == 0


result = is_square(-1)
print(result)
