import numpy as np
import time


def sum_pairs(ints, s):
    cashe = set()
    for i in ints:
        if s - i in cashe:
            return [s-i, i]

        cashe.add(i)


l1 = [1, 4, 8, 7, 3, 15]
l2 = [1, -2, 3, 0, -6, 1]
l3 = [20, -13, 40]
l4 = [1, 2, 3, 4, 1, 0]
l5 = [10, 5, 2, 3, 7, 5]
l6 = [4, -2, 3, 3, 4]
l7 = [0, 2, 0]
l8 = [5, 9, 13, -3]
l9 = [4, 3, 2, 3, 4]


l10 = np.random.randint(0, 10, 1000, dtype=int)
l10 = np.append(l10, [10, 11])

start_time = time.time()
print(sum_pairs(l10, 20))
print("--- %s seconds ---" % (time.time() - start_time))
