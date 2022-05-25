def rgb(r, g, b):
    return "".join([convert(h) for h in [val(r), val(g), val(b)]])


def val(h):
    if h < 0:
        h = 0
    if h > 255:
        h = 255

    return hex(h)


def convert(h):
    return h[-2:].upper().replace("X", "0")


def rgb_kata(r, g, b):
    def round(x): return min(255, max(0, x))
    return ("{:02X}" * 3).format(round(r), round(g), round(b))


print(rgb_kata(10, 1, 0))
