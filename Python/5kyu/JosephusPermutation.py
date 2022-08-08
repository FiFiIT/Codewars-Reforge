from unittest import result


def josephus(items, k):
    pos = 0
    result = []
    for i in range(0, len(items)):
        pos = (pos + k - 1) % len(items)
        result.append(items.pop(pos))

    return result


print(josephus([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 3))
