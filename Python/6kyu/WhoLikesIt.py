# support only in python 3.10 and above
def likes_fifi(names):
    match len(names):
        case 0:
            return "no one likes this"
        case 1:
            return names[0] + " likes this"
        case 2:
            return names[0] + " and " + names[1] + " like this"
        case 3:
            return names[0] + ", " + names[1] + " and " + names[2] + " like this"
        case _:
            return names[0] + ", " + names[1] + " and " + str(len(names[2:])) + " others like this"


def zero(names):
    return "no one likes this"


def one(names):
    return names[0] + " likes this"


def two(names):
    return names[0] + " and " + names[1] + " like this"


def three(names):
    return names[0] + ", " + names[1] + " and " + names[2] + " like this"


def others(names):
    return names[0] + ", " + names[1] + " and " + str(len(names[2:])) + " others like this"


options = {
    0: zero,
    1: one,
    2: two,
    3: three,
    4: others
}


def likes(names):
    return options[4 if len(names) > 4 else len(names)](names)


def likes_kata(names):
    n = len(names)
    return {
        0: 'no one likes this',
        1: '{} likes this',
        2: '{} and {} like this',
        3: '{}, {} and {} like this',
        4: '{}, {} and {others} others like this'
    }[min(4, n)].format(*names[:3], others=n-2)
