using Xunit;

namespace CSharp._5kyu
{
    public class Merge_String_Checker_Tests
    {
        [Fact]
        public void BananasTest()
        {
            var input = new string[,] {
               {"Baafrham", "anns om Baas"},
                {"anns om Baas", "Baafrham"},
                {"Baanas fro Baa", "nmhmas"},
                {"nmhmas", "Baanas fro Baa"},
                {"BannasmBma", "a fro ahas"},
                {"a fro ahas", "BannasmBma"},
                {"BnaroBha", "anas fm amas"},
                {"ana oah", "Bnasfrm Bamas"},
                {"Bnasfrm Bamas", "ana oah"},
                {"nnaraa", "Baas fom Bhams"},
            };

            var expected = true;
            var actual = false;

            for (int i = 0; i < input.GetLength(0); i++)
            {
                actual = Kata5.isMerge("Bananas from Bahamas", input[i, 0], input[i, 1]);
                Assert.Equal(expected, actual);
            }
        }
    }
}