import math


def cakes_fifi(recipe, available):
    available = [math.floor(available[k] / recipe[k])
                 if k in available.keys() else 0 for k in recipe.keys()]

    return min(available)


def cakes(recipe, available):
    return min(available.get(k, 0)//recipe[k] for k in recipe)


recipe = {"apples": 3, "flour": 300,
          "sugar": 150, "milk": 100, "oil": 100}
available = {"sugar": 500, "flour": 2000, "milk": 2000}

# print(cakes(recipe, available))
