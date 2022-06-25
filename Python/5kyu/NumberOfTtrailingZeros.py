from unittest import result


def zeros_kata_1(n):
    result = 0
    while(n > 0):
        n = int(n / 5)
        result += n

    return result


def zeros(n):
    x = int(n/5)
    return x + zeros(x) if x else 0


print(zeros(100))
print(zeros(6))
print(zeros(30))
