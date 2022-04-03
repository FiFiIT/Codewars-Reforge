import math


def find_next_square(sq):
    t = math.sqrt(sq)

    if t % 1 == 0:
        return math.pow(t + 1, 2)

    return -1


print(find_next_square(121))
