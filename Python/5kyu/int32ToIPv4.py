def int32_to_ip(int32):
    return ".".join([str(int32 >> r & 255) for r in [24, 16, 8, 0]])

# int.to_bytes(length, byteorder, *, signed=False)
# Return an array of bytes representing an integer.


def int32_to_ip_kata_1(int32):
    return "{}.{}.{}.{}".format(*int32.to_bytes(4, 'big'))


print(int32_to_ip_kata_1(2154959208))
# print(int32_to_ip_kata_1(0))
