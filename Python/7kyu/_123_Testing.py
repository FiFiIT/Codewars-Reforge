import unittest
from VovewlCount import getCount
from Mumbling import accum
from DisemvowelTrolls import disemvowel
from HighestAndLowest import high_and_low
from square_every_digit import square_digits
from Descending_Order import descending_order
from GetTheMiddleCharacter import get_middle
from Isogram import is_isogram, is_isogram1
from ListFiltering import filter_list
from ExesAndOhs import XO
from ValidatePIN import validate_pin


class Testing_7kyu(unittest.TestCase):
    def test_VowelCount(self):
        self.assertEqual(getCount("aeiou"), 5, f'Incorrect answer for "aeiou"')

        self.assertEqual(getCount("y"), 0, f'Incorrect answer for "y"')

        self.assertEqual(
            getCount("bcdfghjklmnpqrstvwxz y"),
            0,
            f'Incorrect answer for "bcdfghjklmnpqrstvwxz y"',
        )
        self.assertEqual(getCount(""), 0, f"Incorrect answer for empty string")

        self.assertEqual(
            getCount("abracadabra"), 5, f'Incorrect answer for "abracadabra"'
        )

    def test_Mumbling(self):
        self.assertEqual(
            accum("ZpglnRxqenU"),
            "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu",
        )
        self.assertEqual(
            accum("NyffsGeyylB"),
            "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb",
        )
        self.assertEqual(
            accum("MjtkuBovqrU"),
            "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu",
        )
        self.assertEqual(
            accum("EvidjUnokmM"),
            "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm",
        )
        self.assertEqual(
            accum("HbideVbxncC"),
            "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc",
        )

    def test_DisemvowelTrolls(self):
        self.assertEqual(
            disemvowel(
                "This website is for losers LOL!"), "Ths wbst s fr lsrs LL!"
        )

    def test_HighAndLow(self):
        self.assertEqual(
            high_and_low("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"), "542 -214"
        )
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

    def test_descending_order(self):
        self.assertEqual(descending_order(0), 0)
        self.assertEqual(descending_order(1), 1)
        self.assertEqual(descending_order(111), 111)
        self.assertEqual(descending_order(15), 51)
        self.assertEqual(descending_order(1021), 2110)
        self.assertEqual(descending_order(123456789), 987654321)

    def test_get_the_middle_character(self):
        self.assertEqual(get_middle("test"), "es")
        self.assertEqual(get_middle("testing"), "t")
        self.assertEqual(get_middle("middle"), "dd")
        self.assertEqual(get_middle("A"), "A")
        self.assertEqual(get_middle("of"), "of")

    def test_is_isogram(self):
        self.assertEqual(is_isogram("Dermatoglyphics"), True)
        self.assertEqual(is_isogram("isogram"), True)
        self.assertEqual(is_isogram("aba"), False,
                         "same chars may not be adjacent")
        self.assertEqual(is_isogram("moOse"), False,
                         "same chars may not be same case")
        self.assertEqual(is_isogram("isIsogram"), False)
        self.assertEqual(is_isogram(""), True,
                         "an empty string is a valid isogram")

        self.assertEqual(is_isogram1("Dermatoglyphics"), True)
        self.assertEqual(is_isogram1("isogram"), True)
        self.assertEqual(is_isogram1("aba"), False,
                         "same chars may not be adjacent")
        self.assertEqual(is_isogram1("moOse"), False,
                         "same chars may not be same case")
        self.assertEqual(is_isogram1("isIsogram"), False)
        self.assertEqual(is_isogram1(""), True,
                         "an empty string is a valid isogram")

    def test_list_filtering(self):
        self.assertEqual(filter_list([1, 2, 'a', 'b']), [1, 2])
        self.assertEqual(filter_list([1, 'a', 'b', 0, 15]), [1, 0, 15])
        self.assertEqual(filter_list(
            [1, 2, 'aasf', '1', '123', 123]), [1, 2, 123])

    def test_exes_and_ohs(self):
        self.assertEqual(XO("xo"), True)
        self.assertEqual(XO("xo0"), True)
        self.assertEqual(XO("xxxxxo"), False)

    def test_validate_pin(self):
        self.assertEqual(validate_pin("1"), False, "Wrong output for '1'")
        self.assertEqual(validate_pin("12"), False, "Wrong output for '12'")
        self.assertEqual(validate_pin("123"), False, "Wrong output for '123'")
        self.assertEqual(validate_pin("12345"), False,
                         "Wrong output for '12345'")
        self.assertEqual(validate_pin("1234567"), False,
                         "Wrong output for '1234567'")
        self.assertEqual(validate_pin("-1234"), False,
                         "Wrong output for '-1234'")
        self.assertEqual(validate_pin("-12345"), False,
                         "Wrong output for '-12345'")
        self.assertEqual(validate_pin("1.234"), False,
                         "Wrong output for '1.234'")
        self.assertEqual(validate_pin("00000000"), False,
                         "Wrong output for '00000000'")


if __name__ == "__main__":
    unittest.main()
