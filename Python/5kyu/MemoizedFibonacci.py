from functools import cache

from cv2 import CamShift


@cache
def fibonacci(n):
    if n in [0, 1]:
        return n
    return fibonacci(n - 1) + fibonacci(n - 2)


def fibonacci_kata_1(n):
    fib = [0, 1]
    for i in range(2, n+1):
        fib.append(fib[i-1] + fib[i-2])

    return fib[n]


def memoized(f):
    cashe = {}

    def wrapped(k):
        if k not in cashe:
            v = cache[k] = f(k)

        return v

    return wrapped


@memoized
def fibonacci_kata_2(n):
    if n in [0, 1]:
        return n
    return fibonacci_kata_2(n - 1) + fibonacci_kata_2(n - 2)


print(fibonacci_kata_2(10))
