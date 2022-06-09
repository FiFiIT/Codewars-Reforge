def max_sequence(arr):
    c_sum = 0
    max_sum = 0

    for v in arr:
        c_sum = max(c_sum + v, 0)
        max_sum = max(c_sum, max_sum)

    return max_sum


print(max_sequence([-2, 1, -3, 4, -1, 2, 1, -5, 4]))
