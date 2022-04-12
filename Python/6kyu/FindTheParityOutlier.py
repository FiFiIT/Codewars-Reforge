def find_outlier(integers):
    odd = [i for i in integers if i % 2 != 0]
    even = [i for i in integers if i % 2 == 0]

    return odd[0] if len(odd) == 1 else even[0]


print(find_outlier([2, 4, 6, 8, 10, 3]))
