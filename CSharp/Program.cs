using System;
using System.Collections.Generic;
using CSharp._7Kyu;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 };
            var result = Kata7.GetIntegersFromList_2(lst);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
