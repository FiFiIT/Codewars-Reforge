from collections import Counter


def find_uniq(arr):
    # your code here
    arr.sort()

    return arr[-1] if arr[0] == arr[1] else arr[0]


def find_uniq_kata_1(arr):
    a, b = set(arr)

    return a if arr.count(a) == 1 else b


def find_uniq_kata_2(arr):
    return Counter(arr).most_common()[-1][0]


input = [0, 0, 0.55, 0, 0]
result = Counter(input).elements()
for r in result:
    print(r)
