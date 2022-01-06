import re


def solution(text: str) -> int:
    for i in range(1, len(text)):
        split = text[:i]
        tab = text.split(split)
        left = len([t for t in tab if t])
        # print(split)

        if left == 0:
            return sum(1 for t in re.finditer(split, text))

    return 1


if __name__ == "__main__":
    result = solution("a")
    print(result)
