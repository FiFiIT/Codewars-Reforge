using System;
using System.Linq;
using System.Collections.Generic;
using CSharp._7Kyu;
using CSharp._6Kyu;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            var result = Kata6.find_it(input);

            Console.WriteLine(result);
            // foreach (var r in result)
            // {
            //     Console.WriteLine(r);
            // }
        }
    }
}
