using Xunit;
using Xunit.Abstractions;
using CSharp._6Kyu;

namespace CSharp._6Kyu.Testing
{
    // dotnet test --filter SplitStrings
    public class SplitStrings
    {
        [Fact]
        public void SplitStrings_01()
        {
            var input = "abc";
            var excepted = new string[] { "ab", "c_" };

            var actual = Kata6.SplitString(input);

            Assert.Equal(excepted, actual);
        }
        [Fact]
        public void SplitStrings_02()
        {
            var input = "abcdef";
            var excepted = new string[] { "ab", "cd", "ef" };

            var actual = Kata6.SplitString(input);

            Assert.Equal(excepted, actual);
        }
    }
}