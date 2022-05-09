import unittest
from SimplePigLatin import pig_it


class Testing_5kyu(unittest.TestCase):
    def test_pig_it(self):
        self.assertEqual(pig_it('Pig latin is cool'),
                         'igPay atinlay siay oolcay')
        self.assertEqual(pig_it('This is my string'),
                         'hisTay siay ymay tringsay')
        self.assertEqual(pig_it('O tempora o mores !'),
                         'Oay emporatay oay oresmay !')

if __name__ == "__main__":
    unittest.main()
