def pig_it(text):
    result = [pig(t) if t.isalpha()
              else t for t in text.split(' ')]
    return " ".join(result)


def pig(word):
    return word[1:] + word[:1] + "ay"

# The isalnum() method returns True if all characters in the string are alphanumeric (either alphabets or numbers). If not, it returns False.


def pig_it_kata(text):
    return " ".join(pig(x) if x.isalnum() else x for x in text.split())


# print(pig_it_kata('Pig latin is cool !'))
