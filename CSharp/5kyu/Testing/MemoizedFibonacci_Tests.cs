using Xunit;

namespace CSharp._5kyu
{
    public class MemoizedFibonacci_Tests
    {
        //dotnet test --filter fibonacci
        [Fact]
        public void fibonacci_50()
        {
            var input = 50;
            var expected = 12586269025;

            var actual = Kata5.MemoizedFibonacci(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void fibonacci_60()
        {
            var input = 60;
            var expected = 1548008755920;

            var actual = Kata5.MemoizedFibonacci(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void fibonacci_70()
        {
            var input = 70;
            var expected = 190392490709135;

            var actual = Kata5.MemoizedFibonacci(input);

            Assert.Equal(expected, actual);
        }
    }
}
