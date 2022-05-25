def anagrams(word, words):
    return [w for w in words if sorted(w) == sorted(word)]


input = ['aabb', 'abcd', 'bbaa', 'dada']
input2 = ['crazer', 'carer', 'racar', 'caers', 'racer']
result = anagrams('racer', input2)
print(result)
