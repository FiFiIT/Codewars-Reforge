from functools import reduce
from ipaddress import IPv4Address


def ip_to_int32(ip):
    binary = "".join([(bin(int(b))[2:]).zfill(8) for b in ip.split(".")])
    rbinary = "".join([b for b in reversed(binary)])

    return sum([int(b) * 2 ** i for i, b in enumerate(rbinary)])


def ip_to_int32_2(ip):
    addr = ip.split(".")
    res = int(addr[0]) << 24
    res += int(addr[1]) << 16
    res += int(addr[2]) << 8
    res += int(addr[3])

    return res


def ip_to_int32_3(ip):
    r = ""
    for i in ip.split("."):
        r += "{0:08b}".format(int(i))

    return int(r, 2)


def ip_to_int32_4(ip):
    return reduce(lambda acc, x: acc << 8 | x, (int(x) for x in ip.split(".")))


def ip_to_int32_5(ip):
    return int(IPv4Address(ip))


result = ip_to_int32_5("128.114.17.104")
print(result)
