using Xunit;

namespace CSharp._5kyu
{
    public class CommonDenominator
    {
        //dotnet test --filter denominator
        [Fact]
        public void SampleTest()
        {
            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            var expected = "(6,12)(4,12)(3,12)";

            var actual = Kata5.convertFrac(lst);

            Assert.Equal(expected, actual);
        }
    }
}
