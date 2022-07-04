import math
from itertools import groupby, count


def prime_factors(n):
    primes = []

    prime = 1
    while prime:
        prime = find_prime(n)
        if prime:
            primes.append(prime)
            n = n / prime

    return print_result(primes)


def print_result(primes):
    result = ""
    for k, g in groupby(primes):
        l = len(list(g))
        l = f"**{l}" if l > 1 else ''
        result += f"({k}{l})"

    return result


def find_prime(n):
    for i in range(2, int(n)+1):
        if n % i == 0:
            return i

    return 0


def is_prime(n):
    if n <= 1:
        return False

    for i in range(2, math.sqrt(n)):
        if n % i == 0:
            return False

    return True


def prime_factors_kata_1(n):
    i, j, p = 2, 0, []

    while n > 1:
        while n % i == 0:
            n, j = n // i, j + 1

        if j > 0:
            p.append([i, j])

        i, j = i + 1, 0

    return p


print(prime_factors_kata_1(7775460))
