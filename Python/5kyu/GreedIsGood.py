def score(dice):
    tripple = [0, 1000, 200, 300, 400, 500, 600]
    other = [0, 100, 0, 0, 0, 50, 0]
    result = 0

    for side in range(1, 7):
        rolls = sum([1 for d in dice if d == side])
        result += tripple[side] * int(rolls / 3) + other[side] * (rolls % 3)

    return result


def score_kata_1(dice):
    sum = 0
    counter = [0, 0, 0, 0, 0, 0]
    points = [1000, 200, 300, 400, 500, 600]
    extra = [100, 0, 0, 0, 50, 0]

    for die in dice:
        counter[die-1] += 1

    for (i, count) in enumerate(counter):
        sum += points[i] if count >= 3 else 0
        sum += extra[i] * (count % 3)


print(score([4, 4, 4, 3, 3]))
