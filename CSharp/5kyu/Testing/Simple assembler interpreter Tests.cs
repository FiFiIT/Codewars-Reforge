using System.Collections.Generic;
using Xunit;

namespace CSharp._5kyu
{
    public class SimpleAssemblerInterpreter_Tests
    {
        [Fact]
        public void ExampleProgram()
        {
            var input = new[] { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a" };
            var expected = new Dictionary<string, int> { { "a", 1 } };
            var actual = Kata5.Interpret(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleProgram_2()
        {
            var input = new[] { "mov a -10", "mov b a", "inc a", "dec b", "jnz a -2" };
            var expected = new Dictionary<string, int> { { "a", 0 }, { "b", -20 } };
            var actual = Kata5.Interpret(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleProgram_3()
        {
            var input = new[] { "mov y 365", "mov a 2", "jnz a 3", "jnz y 5", "inc y", "inc a", "dec y", "dec a", "dec a", "inc a", "dec y" };
            var expected = new Dictionary<string, int> { { "y", 363 }, { "a", 2 } };

            var actual = Kata5.Interpret(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ExampleProgram_4()
        {
            var input = new[] { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a", " mov a -10", "mov b a", "inc a", "dec b", "jnz a -2" };
            var expected = new Dictionary<string, int> { { "y", 363 }, { "a", 2 } };

            var actual = Kata5.Interpret(input);

            Assert.Equal(expected, actual);
        }
    }
}
