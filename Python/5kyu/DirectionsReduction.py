def dirReduc(arr):
    opposite = {
        "NORTH": "SOUTH",
        "EAST": "WEST",
        "SOUTH": "NORTH",
        "WEST": "EAST",
    }

    result = []
    for dir in arr:
        if result and result[-1] == opposite[dir]:
            result.pop()
        else:
            result.append(dir)

    return result


a = ["NORTH", "WEST", "SOUTH", "EAST"]
print(dirReduc(a))
