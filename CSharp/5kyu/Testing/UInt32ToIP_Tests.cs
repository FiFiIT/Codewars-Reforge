using Xunit;

namespace CSharp._5kyu
{
    public class UInt32ToIP_Tests
    {
        [Fact]
        public void UInt32ToIP_1()
        {
            uint input = 2154959208;
            var expected = "128.114.17.104";

            var actual = Kata5.UInt32ToIP(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void UInt32ToIP_2()
        {
            uint input = 0;
            var expected = "0.0.0.0";

            var actual = Kata5.UInt32ToIP(input);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void UInt32ToIP_3()
        {
            uint input = 2149583361;
            var expected = "128.32.10.1";

            var actual = Kata5.UInt32ToIP(input);

            Assert.Equal(expected, actual);
        }
    }
}
