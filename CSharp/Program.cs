using System;
using System.Linq;
using System.Collections.Generic;
using CSharp._7Kyu;
using CSharp._6Kyu;
using System.Diagnostics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = "recede";

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata6.DuplicateEncode(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);

            Console.WriteLine("RunTime: " + milliseconds);

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
