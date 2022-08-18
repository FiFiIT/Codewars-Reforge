using Xunit;

namespace CSharp._5kyu
{
    public class TicTacToe_Tests
    {
        [Fact]
        public void Test_1()
        {
            var input = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            var expected = 1;
            var actual = Kata5.IsSolved(input);

            Assert.Equal(expected, actual);
        }
    }
}
