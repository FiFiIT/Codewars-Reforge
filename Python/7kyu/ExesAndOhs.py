def XO(s):
    return len([o for o in s.lower() if o == 'o']) == len([o for o in s.lower() if o == 'x'])


def XO_2(s):
    s = s.lower()
    return s.count("o") == s.count("x")
