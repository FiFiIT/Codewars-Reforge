def maskify(cc):
    l = len(cc) - 4
    if l <= 0:
        return cc

    return "#" * l + cc[-4:]


print(maskify("11111"))
