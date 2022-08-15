import re
pattern = re.compile("(?=^[a-zA-Z0-9]+$)")


def alphanumeric(password):
    return pattern.match(password) is not None


print(alphanumeric("hello world_"))
print(alphanumeric("PassW0rd"))
