def solution(number):
    return sum(n if(n % 3 == 0 or n % 5 == 0) else 0 for n in range(0, number))


def solution_2(number):
    return sum(x for x in range(number) if x % 3 == 0 or x % 5 == 0)


result = solution_2(16)
print(result)
