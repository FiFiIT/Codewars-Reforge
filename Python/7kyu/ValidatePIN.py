import re


def validate_pin_fifi(pin):
    if len(pin) == 0 or re.search('[^\d]', pin) or int(pin) < 0:
        return False

    return len(pin) == 4 or len(pin) == 6


def validate_pin(pin):
    return len(pin) in (4, 6) and pin.isdigit()


if __name__ == "__main__":
    print(validate_pin(""))
