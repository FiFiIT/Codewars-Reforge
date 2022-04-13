def is_valid_walk(walk):
    dy = 0
    dx = 0

    for w in walk:
        if w == "n":
            dy += 1
        if w == "s":
            dy -= 1
        if w == "e":
            dx += 1
        if w == "w":
            dx -= 1

    return len(walk) == 10 and dy == 0 and dx == 0


def is_valid_walk_kata(walk):
    return len(walk) == 10 and walk.count('n') == walk.count('s') and walk.count('e') == walk.count('w')
