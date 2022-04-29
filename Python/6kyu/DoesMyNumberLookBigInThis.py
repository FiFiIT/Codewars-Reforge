def narcissistic(value):
    s = str(value)
    pow = len(s)

    return sum(int(v) ** pow for v in s) == value


result = narcissistic(371)
print(result)
