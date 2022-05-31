from functools import cmp_to_key


def order_weight(strng):
    return " ".join(sorted(strng.split(" "), key=cmp_to_key(weight_comparator)))


def weight_comparator(a, b):
    wa = weight(a)
    wb = weight(b)

    if wa == wb:
        return string_comp(a, b)
    elif wa > wb:
        return 1
    elif wa < wb:
        return -1
    else:
        return 0


def weight(number):
    return sum([int(n) for n in number])


def string_comp(a, b):
    if a > b:
        return 1
    if a < b:
        return -1
    return 0


def order_weight_kata_1(_str):
    return " ".join(sorted(sorted(_str.split(" ")), key=lambda x: sum(int(c) for c in x)))


# print("11" < "2000")

print("11 11 2000 10003 22 123 1234000 44444444 9999")
print(order_weight("2000 10003 1234000 44444444 9999 11 11 22 123"))
