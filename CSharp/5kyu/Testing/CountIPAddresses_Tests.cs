using Xunit;

namespace CSharp._5kyu
{
    public class CountIPAddresses_Tests
    {
        [Fact]
        public void SampleTest()
        {
            Assert.Equal(50, Kata5.IpsBetween("10.0.0.0", "10.0.0.50"));
            Assert.Equal(246, Kata5.IpsBetween("20.0.0.10", "20.0.1.0"));
            Assert.Equal((1L << 32) - 1L, Kata5.IpsBetween("0.0.0.0", "255.255.255.255"));
        }
    }
}