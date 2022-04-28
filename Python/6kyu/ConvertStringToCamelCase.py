import re


def to_camel_case(text):
    return "".join([w.capitalize() if i > 0 else w for i, w in enumerate(re.split("_|-", text))])


def to_camel_case_kata(s):
    myTab = s.maketrans("", "", "-_")
    return s[0] + s.title().translate(myTab)[1:] if s else s


result = to_camel_case_kata("The-Stealth-Warrior")
print(result)
