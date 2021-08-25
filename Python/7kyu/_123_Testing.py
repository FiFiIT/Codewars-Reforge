import unittest
from VovewlCount import getCount
from Mumbling import accum
from DisemvowelTrolls import disemvowel
from HighestAndLowest import high_and_low
from square_every_digit import square_digits


class Testing_7kyu(unittest.TestCase):
    def test_VowelCount(self):
        self.assertEqual(getCount("aeiou"), 5,
                         f"Incorrect answer for \"aeiou\"")

        self.assertEqual(getCount("y"), 0, f"Incorrect answer for \"y\"")

        self.assertEqual(getCount("bcdfghjklmnpqrstvwxz y"),
                         0, f"Incorrect answer for \"bcdfghjklmnpqrstvwxz y\"")
        self.assertEqual(getCount(""), 0, f"Incorrect answer for empty string")

        self.assertEqual(getCount("abracadabra"), 5,
                         f"Incorrect answer for \"abracadabra\"")

    def test_Mumbling(self):
        self.assertEqual(accum(
            "ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu")
        self.assertEqual(accum("NyffsGeyylB"),
                         "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb")
        self.assertEqual(accum("MjtkuBovqrU"),
                         "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu")
        self.assertEqual(accum("EvidjUnokmM"),
                         "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm")
        self.assertEqual(accum("HbideVbxncC"),
                         "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc")

    def test_DisemvowelTrolls(self):
        self.assertEqual(disemvowel(
            "This website is for losers LOL!"), "Ths wbst s fr lsrs LL!")

    def test_HighAndLow(self):
        self.assertEqual(high_and_low(
            "4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"), "542 -214")
        self.assertEqual(high_and_low("1 -1"), "1 -1")
        self.assertEqual(high_and_low("1 1"), "1 1")
        self.assertEqual(high_and_low("-1 -1"), "-1 -1")
        self.assertEqual(high_and_low("1 -1 0"), "1 -1")
        self.assertEqual(high_and_low("1 1 0"), "1 0")
        self.assertEqual(high_and_low("-1 -1 0"), "0 -1")
        self.assertEqual(high_and_low("42"), "42 42")

    def test_square_digits(self):
        self.assertEqual(square_digits(9119), 811181)
        self.assertEqual(square_digits(0), 0)


if __name__ == '__main__':
    unittest.main()
