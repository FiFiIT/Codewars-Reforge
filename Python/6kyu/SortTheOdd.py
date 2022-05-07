import time
from itertools import cycle
# Number may repeat !!!


def sort_array(source_array):
    sorted_array = sorted([x for x in source_array if x % 2 != 0])
    arr = cycle(sorted_array)

    for i, x in enumerate(source_array):
        if x % 2 != 0:
            source_array[i] = next(arr)

    return source_array


def sort_array_kata_1(arr):
    odds = sorted((x for x in arr if x % 2 != 0), reverse=True)

    return [x if x % 2 == 0 else odds.pop() for x in arr]


def sort_array_kata_2(arr):
    odds = iter(sorted(v for v in arr if v % 2))
    return [next(odds) if i % 2 else i for i in arr]


input = [25, -33, -33, -5, 12, -5, -33, -7, -9, -
         10, -45, 43, -18, 36, 3, -28, 19, 16, 12, 3, 47, 24]


result = sort_array_kata_2(input)
print(result)
