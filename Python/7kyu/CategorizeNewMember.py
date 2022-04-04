def open_or_senior(data):
    return ["Senior" if(a >= 55 and h > 7) else "Open" for a, h in data]


def open_or_senior_fifi(data):
    return [category(age, handicap) for age, handicap in data]


def category(age, handicap):
    if age >= 55 and handicap > 7:
        return "Senior"

    return "Open"


result = open_or_senior([(45, 12), (55, 21), (19, -2), (104, 20)])
print(result)
