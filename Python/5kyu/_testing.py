import unittest
from SimplePigLatin import pig_it
from PeteTheBaker import cakes
from GreedIsGood import score
from SumOfPairs import sum_pairs
# run specific test: py .\_testing.py Testing_5kyu.test_dice_score


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

    def test_dice_score(self):
        rolls = [2, 3, 4, 6, 2]
        expected = 0
        actual = score(rolls)
        self.assertEqual(expected, actual, "[2, 3, 4, 6, 2] should be 0")

    def test_sum_of_pairs(self):
        l1 = [1, 4, 8, 7, 3, 15]
        l2 = [1, -2, 3, 0, -6, 1]
        l3 = [20, -13, 40]
        l4 = [1, 2, 3, 4, 1, 0]
        l5 = [10, 5, 2, 3, 7, 5]
        l6 = [4, -2, 3, 3, 4]
        l7 = [0, 2, 0]
        l8 = [5, 9, 13, -3]

        self.assertEqual(sum_pairs(l1, 8), [
                         1, 7], "Basic: %s should return [1, 7] for sum = 8" % l1)
        self.assertEqual(sum_pairs(
            l2, -6), [0, -6], "Negatives: %s should return [0, -6] for sum = -6" % l2)
        self.assertEqual(sum_pairs(l3, -7), None,
                         "No Match: %s should return None for sum = -7" % l3)
        self.assertEqual(sum_pairs(l4, 2), [
                         1, 1], "First Match From Left: %s should return [1, 1] for sum = 2 " % l4)
        self.assertEqual(sum_pairs(l5, 10), [
                         3, 7], "First Match From Left REDUX!: %s should return [3, 7] for sum = 10 " % l5)
        self.assertEqual(sum_pairs(l6, 8), [
                         4, 4], "Duplicates: %s should return [4, 4] for sum = 8" % l6)
        self.assertEqual(sum_pairs(l7, 0), [
                         0, 0], "Zeroes: %s should return [0, 0] for sum = 0" % l7)
        self.assertEqual(sum_pairs(l8, 10), [
                         13, -3], "Subtraction: %s should return [13, -3] for sum = 10" % l8)


if __name__ == "__main__":
    unittest.main()
