def high_and_low(numbers: str):
    n = [int(n) for n in numbers.split()]
    return f"{max(n)} {min(n)}"


if __name__ == '__main__':
    print("********************** TESTING **********************")
    result = high_and_low("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6")
    print(result)
    print("*****************************************************")
