def remov_nb(n):
    result = []
    s = n * (n + 1)//2
    for x in range(n//2, n):
        r = (s - x) // (x + 1)
        if r * x + r + x == s:
            result.append([x, r])

    return result


print(remov_nb(26))
