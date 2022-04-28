using System;
using Xunit;
using CSharp._4Kyu;
using CSharp._6Kyu;
using Xunit.Abstractions;

namespace CSharp._4Kyu.Testing
{
    // dotnet test --filter DecodeMorse
    public class DecodeTheMorseCode_2_Test
    {
        private ITestOutputHelper output;
        public DecodeTheMorseCode_2_Test(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void DecodeMorse_101()
        {
            var input = "1110111";
            var expected = "M";

            var actual = Kata4.DecodeBits(input);
            actual = Kata4.DecodeMorse(actual);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DecodeMorse_110011()
        {
            var input = "110011";
            var expected = "I";

            var actual = Kata4.DecodeBits(input);
            actual = Kata4.DecodeMorse(actual);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DecodeMorse_10001()
        {
            var input = "10001";
            var expected = "EE";

            var actual = Kata4.DecodeBits(input);
            actual = Kata4.DecodeMorse(actual);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DecodeMorse_111000111()
        {
            var input = "111000111";
            var expected = "I";

            var actual = Kata4.DecodeBits(input);
            actual = Kata4.DecodeMorse(actual);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DecodeMorse_1()
        {
            var input = "1";
            var expected = "E";

            var actual = Kata4.DecodeBits(input);
            actual = Kata4.DecodeMorse(actual);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equal_Sides_O_An_Array_3()
        {
            var input = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            int expected = 3;

            var actual = Kata6.FindEvenIndex(input);

            Assert.Equal(expected, actual);

        }
    }
}