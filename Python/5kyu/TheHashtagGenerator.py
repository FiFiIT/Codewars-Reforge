from attr import has
from black import out
from regex import F


def generate_hashtag(s):
    output = "#"

    for word in s.split():
        output += word.capitalize()

    return False if len(s) == 0 or len(output) > 140 else output


def generate_hashtag_kata_1(s):
    ans = "#" + str(s.title().replace(' ', ''))
    return s and not len(ans) > 140 and ans or False


result = generate_hashtag_kata_1('CodeWarsIs nice       ')
print(result)
