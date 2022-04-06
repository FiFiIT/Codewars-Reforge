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

            var input = "Hey fellow warriors";
            var result = Kata6.SpinWords(input);

            Console.WriteLine(result);
            // foreach (var r in result)
            // {
            //     Console.WriteLine(r);
            // }

        }
    }
}
