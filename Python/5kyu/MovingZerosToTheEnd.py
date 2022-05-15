def move_zeros(array):
    zeros = [x for x in array if x == 0]
    return [x for x in array if x != 0] + zeros


print(move_zeros([1, 2, 0, 1, 0, 1, 0, 3, 0, 1]))
