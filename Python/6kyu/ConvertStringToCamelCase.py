import re


def to_camel_case(text):
    return "".join([w.capitalize() if i > 0 else w for i, w in enumerate(re.split("_|-", text))])


def to_camel_case_kata(s):
    myTab = s.maketrans("", "", "-_")
    return s[0] + s.title().translate(myTab)[1:] if s else s

# String maketrans() Parameters
# maketrans() method takes 3 parameters:

# x - If only one argument is supplied, it must be a dictionary.
# The dictionary should contain a 1-to-1 mapping from a single character string to its translation OR a Unicode number (97 for 'a') to its translation.
# y - If two arguments are passed, it must be two strings with equal length.
# Each character in the first string is a replacement to its corresponding index in the second string.
# z - If three arguments are passed, each character in the third argument is mapped to None.


result = to_camel_case_kata("The-Stealth-Warrior")
print(result)
