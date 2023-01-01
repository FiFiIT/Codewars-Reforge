using System.Collections.Generic;
using Xunit;
using CSharp._5kyu;

namespace CSharp._5kyu.Testing
{
    public class DidYouMean_Tests
    {
        //dotnet test --filter DidYouMean
        [Fact]
        public void Test_1()
        {
            var input = new List<string> { "zqdrhpviqslik", "riyhpvimgaliuxr" };
            Kata5.words = new List<string> { "loogviwcojxgvi", "pxyousorusjxxbt", "lnjhrzfrosinb", "afirbipbmkamjzw", "hkldhadcxrjbmkmcdi", "ppctybxgtleipb", "sefsknopiffajor", "eglanhfredaykxr", "fgtrjakzlnaebxr", "ljxzjjorwgb", "npyrgrpbdfqhhncdi", "vkholxrvjwisrk", "cwhyyzaorpvtnlfr", "xrgdgqfrldwk", "tdvibqccxr", "zqdrhpviqslik", "nnsoamjkrzgldi", "ntwmwwmicnjvhtt", "psaysnhfrrqgxwik", "mhmkakybpczjbb", "ggcvrtxrtnafw", "xuwahveztwoor", "ucxmdeudiycokfnb", "fxpvfhfrujjaifr", "iroezmixmberfr", "pdyjrkaylryr", "karpscdigdvucfr", "jcocndjkyb", "cpnqknjyviusknmte", "dyhxgviphoptak", "ajacizfrgxfumzpvi", "tklquxrnhfiggb", "qojfrlhufr", "hwzsemiqxjwfk", "riyhpvimgaliuxr", "jhjyasikwyufr", "hirldidcuzbyb", "fxjskybblljqr", "osbednerciaai", "hrwuhmtxxvmygb", "clxmqmiycvidiyr", "emvquxrvvlvwvsi", "qifwqgdsijibor", "cfvruditwcxr", "znystgvifufptxr", "dihhiczkdwiofpr", "xffrkbdyjveb", "kqijoorfkejdcxr", "xikoctmrhpvi", "iqkyztorburjgiudi" };

            var expected = "zqdrhpviqslik";
            var actual = Kata5.FindMostSimilar("rkacypviuburk");

            Assert.Equal(expected, actual);
        }
    }
}