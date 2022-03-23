using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string Maskify(string cc)
        {
            int len = cc.Length;
            return len < 4
                ? cc
                : new string('*', len - 4) + cc.Substring(len - 4);
        }

        public static string Maskify_2(string cc)
        {
            int len = cc.Length;
            if (len < 4)
            {
                return cc;
            }

            return cc.Substring(len - 4).PadLeft(len, '#');
        }
    }
}