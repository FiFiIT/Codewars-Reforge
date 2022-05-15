import math


def make_readable(seconds):
    n = [math.floor(seconds/3600), math.floor(seconds / 60) % 60, seconds % 60]
    return "{:02d}:{:02d}:{:02d}".format(*n)


print(make_readable(5))
