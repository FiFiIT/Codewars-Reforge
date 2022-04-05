def find_it_fifi(seq):
    return [s for s in seq if seq.count(s) % 2 != 0][0]


def find_if(seq):
    for s in seq:
        if seq.count(s) % 2 != 0:
            return s


result = find_it_fifi(
    [20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5])
print(result)
