using Xunit;
using Xunit.Abstractions;
using CSharp._6Kyu;

namespace CSharp._6Kyu.Testing
{
    // dotnet test --filter Narcissistic
    public class DoesMyNumberLookBigInThis_Tests
    {
        [Fact]
        public void Narcissistic_01()
        {
            var input = 1;
            var expected = true;

            var actual = Kata6.Narcissistic(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Narcissistic_02()
        {
            var input = 371;
            var expected = true;

            var actual = Kata6.Narcissistic(input);

            Assert.Equal(expected, actual);
        }
    }
}
