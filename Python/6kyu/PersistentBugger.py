import math
import operator
from functools import reduce


def persistence(nums):
    loops = 0
    while nums > 9:
        nums = math.prod([int(n) for n in str(nums)])
        loops += 1

    return loops


def persistence_kata(nums):
    loops = 0
    while nums > 9:
        nums = reduce(operator.mul, [int(n) for n in str(nums)])
        loops += 1

    return loops


print(persistence_kata(999))
