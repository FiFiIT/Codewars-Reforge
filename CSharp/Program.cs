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

            var input = new int[] { 1, 2, 2,5,8,79,4,56,4,8,7,9,1,2,6,5,4,7,89,9,3,1,5,4,4,8,8,9,7,4,5,6,1,2,3 };
            var input2 = new int[] { 2,99,44,55,6,4,44,555,88,77,77,88,88 };

            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = Kata6.ArrayDiff(input, input2);
            watch.Stop();

            foreach (var r in result)
            {
                Console.WriteLine(r);
                Console.WriteLine("Time: ", watch.ElapsedMilliseconds);
            }

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
