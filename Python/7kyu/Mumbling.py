def accum(str):
    return '-'.join(s.upper() + s.lower() * i for i, s in enumerate(str))
