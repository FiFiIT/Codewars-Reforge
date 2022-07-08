import enum


def pick_peaks(arr):
    result = {"pos": [], "peaks": []}
    pos = 0
    peak = 0

    for i in range(1, len(arr)-1):
        if arr[i] > arr[i-1]:
            pos = i
            peak = arr[i]

        if arr[i] > arr[i+1] and pos != 0:
            result["pos"].append(pos)
            result["peaks"].append(peak)

            pos = 0
            peak = 0

    return result


print(pick_peaks([2, 1, 3, 1, 2, 2, 2, 2]))
