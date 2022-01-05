using System;
using System.Linq;

namespace CSharp._7Kyu
{
    public static class DescendingOrder
    {
        public static int Go(int n)
        {
            return int.Parse(string.Join("", n.ToString().OrderByDescending(a => a)));
        }
    }
}