import re


def split_string(s):
    up = int(len(s)/2 + 0.5)
    s = s + "_"
    return [s[x*2:x*2+2] for x in range(0, up)]


def split_string_kata_1(s):
    s += "_"
    return [s[x: x+2] for x in range(0, len(s), 2)]


def split_string_kata_2(s):
    return re.findall(".{2}", s + "_")


print(split_string_kata_2("abc"))
