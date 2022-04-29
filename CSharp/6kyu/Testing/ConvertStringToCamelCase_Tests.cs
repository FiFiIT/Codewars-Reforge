using Xunit;

namespace CSharp._6Kyu.Testing
{
    public class ConvertStringToCamelCase_Tests
    {
        // dotnet test --filter CamelCase
        [Fact]
        public void CamelCase_01()
        {
            var input = "the_stealth_warrior";
            var expected = "theStealthWarrior";

            var actual = Kata6.ToCamelCase_Kata(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CamelCase_02()
        {
            var input = "The-Stealth-Warrior";
            var expected = "TheStealthWarrior";

            var actual = Kata6.ToCamelCase_Kata(input);

            Assert.Equal(expected, actual);
        }
    }
}