import math
import re


def increment_string(strng):
    head = re.sub("\d+", "", strng)
    tail = strng[len(head):]

    if tail == "":
        return head + "1"

    return head + str(int(tail) + 1).zfill(len(tail))

print(increment_string("foo019"))

