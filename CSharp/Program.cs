using System;
using System.Collections.Generic;
using CSharp._7Kyu;
using CSharp._6Kyu;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };

            var result = Kata7.OpenOrSenior(data);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
