using Xunit;
using Xunit.Abstractions;
using CSharp._6Kyu;

namespace CSharp._6Kyu.Testing
{
    public class SortTheOdd_Tests
    {
        // dotnet test --filter SortTheOdd
        [Fact]
        public void SortTheOdd_01()
        {
            var input = new int[] { 5, 3, 2, 8, 1, 4 };
            var expected = new int[] { 1, 3, 2, 8, 5, 4 };

            var actual = Kata6.SortArray(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SortTheOdd_02()
        {
            var input = new int[] { 5, 3, 1, 8, 0 };
            var expected = new int[] { 1, 3, 5, 8, 0 };

            var actual = Kata6.SortArray(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SortTheOdd_03()
        {
            var input = new int[] { };
            var expected = new int[] { };

            var actual = Kata6.SortArray(input);

            Assert.Equal(expected, actual);
        }
    }
}