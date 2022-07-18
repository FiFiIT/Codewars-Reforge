import math


def gap(g, m, n):
    last_prime = 0

    for p in range(m, n+1):
        if is_prime(p):
            if p - last_prime == g:
                return [last_prime, p]

            last_prime = p

    return []


def is_prime(n):
    for x in range(2, int(math.sqrt(n))):
        if n % x == 0:
            return False

    return True


print(gap(3, 3, 10))
