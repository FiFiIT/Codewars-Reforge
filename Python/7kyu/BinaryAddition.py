def add_binary(a, b):
    return bin(a + b)[2:]


def add_binary_2(a, b):
    return '{0:b}'.format(a+b)


result = add_binary_2(1, 2)
print(result)
