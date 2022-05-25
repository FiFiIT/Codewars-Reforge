using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static ulong[] productFib(ulong prod)
        {

            ulong n = 0;
            ulong nPlus = 1;

            while (n * nPlus < prod)
            {
                nPlus = n + nPlus;
                n = nPlus = n;
            }

            var found = (ulong)(n * nPlus == prod ? 1 : 0);
            var result = new ulong[] { n, nPlus, found };

            return result;
        }
    }
}