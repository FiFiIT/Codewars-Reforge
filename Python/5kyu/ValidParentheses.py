from math import fabs
from xmlrpc.client import FastParser


def valid_parentheses(string):
    trimed = [s for s in string if s in "()"]

    c = 0
    for p in trimed:
        c += 1 if p == "(" else -1
        if c < 0:
            return False

    return c == 0


def valid_parentheses_kata_1(string):
    c = 0
    for p in string:
        if p == "(":
            c += 1
        if p == ")":
            c -= 1

        if c < 0:
            return False

    return True if c == 0 else False


print(valid_parentheses_kata_1("hi(hi)()"))
