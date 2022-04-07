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

            var input = 456;
            var result = Kata6.DigitalRoot(input);

            Console.WriteLine(result);
            // var n = 456;
            // var r = n.ToString().ToArray();
            // var sum = r.Sum(x =>
            // {
            //     int y = int.Parse(x.ToString());
            //     Console.WriteLine(y);

            //     return y;
            // });

            // Console.WriteLine(sum);

            // foreach (var a in r)
            // {
            //     Console.WriteLine(a);
            // }

        }
    }
}
