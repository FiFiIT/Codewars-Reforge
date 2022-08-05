class CustomInt(int):
    def __call__(self, v):
        return CustomInt(self + v)


def add(n):
    return CustomInt(n)


# print(add(1))
# print(add(1)(2))
print(add(1)(2)(3))
