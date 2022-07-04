import math


def list_squared(m, n):
    result = []

    for number in range(m, n+1):
        square = square_divisors(number)
        if(math.sqrt(square) % 1 == 0):
            result.append([number, square])

    return result


def square_divisors(number):
    sum = 0

    for n in range(1, int(math.sqrt(number)) + 1):
        if number % n == 0:
            if number / n == n:
                sum += math.pow(n, 2)
            else:
                sum += math.pow(n, 2) + math.pow(int(number / n), 2)

    return int(sum)


print(list_squared(1, 250))
