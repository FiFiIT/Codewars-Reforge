from asyncio.windows_events import NULL
import re


def find_even_index(arr):
    m = [i for i, r in enumerate(arr) if sum(arr[:i]) == sum(arr[i+1:])]
    if not m:
        return -1

    return min(m)


arr = [1, 2, 3, 1, 0, 6]
result = find_even_index(arr)

print(arr[:result], arr[result+1:]) if result else print(result)
