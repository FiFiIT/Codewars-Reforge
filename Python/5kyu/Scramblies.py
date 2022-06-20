from collections import Counter


def scramble(s1, s2):
    # Counter basically creates a dictionary of counts and letters
    # Using set subtraction, we know that if anything is left over,
    # something exists in s2 that doesn't exist in s1
    return len(Counter(s2) - Counter(s1)) == 0


def scramble_kata_1(s1, s2):
    c1 = Counter(s1)
    c2 = Counter(s2)

    for c in c2:
        if c2[c] > c1[c]:
            return False

    return True


def scramble_kata_2(s1, s2):
    return all(s1.count(x) >= s2.count(x) for x in s2)


def scramble_fifi(s1, s2):
    for c in s2:
        if s1.count(c) < s2.count(c):
            return False

    return True


print(scramble('katas', 'steak'))
# print('world', scramble('rkqodlw', 'world') == True)
# print('codewars', scramble('cedewaraaossoqqyt', 'codewars') == True)
# print('steak', scramble('katas', 'steak') == False)
# print('javascript', scramble('scriptjava', 'javascript') == True)
# print('javascript', scramble('scriptingjava', 'javascript') == True)
