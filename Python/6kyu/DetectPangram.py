import string


def is_pangram(s):
    return len([a for a in "abcdefghijklmnopqrstuvwxyz" if a not in s.lower()]) == 0


def is_pangram_kata(s):
    return len(set([s for s in s.lower() if s.isalpha()])) == 26


pangram = "The quick, brown fox jumps over the lazy dog!"
result = is_pangram_kata(pangram)
print(result)
