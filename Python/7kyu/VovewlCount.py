import re


def getCount(sentence):
    return len([v for v in sentence if 'aeiou'.find(v) >= 0])


def getCount_1(sentence):
    return sum(1 for w in sentence if w in 'aeiou')


def getCount_2(sentence):
    return sum(c in 'aeiou' for c in sentence)
