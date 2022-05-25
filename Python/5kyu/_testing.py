import unittest
from SimplePigLatin import pig_it
from PeteTheBaker import cakes


class Testing_5kyu(unittest.TestCase):
    def test_pig_it(self):
        self.assertEqual(pig_it('Pig latin is cool'),
                         'igPay atinlay siay oolcay')
        self.assertEqual(pig_it('This is my string'),
                         'hisTay siay ymay tringsay')
        self.assertEqual(pig_it('O tempora o mores !'),
                         'Oay emporatay oay oresmay !')

    def test_pete_recipe_1(self):
        recipe = {"flour": 500, "sugar": 200, "eggs": 1}
        available = {"flour": 1200, "sugar": 1200, "eggs": 5, "milk": 200}

        self.assertEqual(
            cakes(recipe=recipe, available=available), 2, 'example #1')

    def test_pete_recipe_2(self):
        recipe = {"apples": 3, "flour": 300,
                  "sugar": 150, "milk": 100, "oil": 100}
        available = {"sugar": 500, "flour": 2000, "milk": 2000}
        self.assertEqual(cakes(recipe, available), 0, 'example #2')


if __name__ == "__main__":
    unittest.main()
