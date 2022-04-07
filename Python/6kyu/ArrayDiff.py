def array_diff(a, b):
    return [x for x in a if x not in b]


result = array_diff([1, 2, 2], [2])
print(result)
