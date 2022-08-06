def ips_between(start, end):
    return ip_value(end) - ip_value(start)


def ip_value(ip):
    return sum(int(b) << 24 - 8 * i for i, b in enumerate(ip.split(".")))


print(ips_between("20.0.0.0", "20.0.0.50"))
