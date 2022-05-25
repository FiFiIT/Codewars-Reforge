# def zero(*op):
#     return op[0](0) if op else 0


# def one(*op):
#     return op[0](1) if op else 1


# def two(*op):
#     return op[0](2) if op else 2


# def three(*op):
#     return op[0](3) if op else 3


# def four(*op):
#     return op[0](4) if op else 4


# def five(*op):
#     return op[0](5) if op else 5


# def six(*op):
#     return op[0](6) if op else 6


# def seven(*op):
#     return op[0](7) if op else 7


# def eight(*op):
#     return op[0](8) if op else 8


# def nine(*op):
#     return op[0](9) if op else 9


# def plus(a):
#     return lambda b: b + a


# def minus(a):
#     return lambda b: b - a


# def divided_by(a):
#     return lambda b: int(b / a)


# def times(a):
#     return lambda b: b * a

def id_(x): return x
def number(x): return lambda f=id_: f(x)


zero, one, two, three, four, five, six, seven, eight, nine = map(
    number, range(10))


def plus(x): return lambda y: y + x
def minus(x): return lambda y: y - x
def times(x): return lambda y: y * x
def divided_by(x): return lambda y: y / x


print(six(times(seven())))
