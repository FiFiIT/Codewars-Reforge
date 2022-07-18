def choose_best_sum(t, k, ls):
    result = choose_best(t, k, ls)

    return result if result > 0 else None


def choose_best(t, k, ls):
    if k == 0:
        return 0

    best = -1
    for i, v in enumerate(ls):
        if v > t:
            continue
        b = choose_best(t-v, k-1, ls[i+1:])
        if b < 0:
            continue
        if b > best and b < t:
            best = b

    return best


xs = [100, 76, 56, 44, 89, 73, 68, 56, 64,
      123, 2333, 144, 50, 132, 123, 34, 89]

result = choose_best_sum(230, 4, xs)
print(result)
