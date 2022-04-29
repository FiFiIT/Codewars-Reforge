using System;
using System.Linq;
using System.Collections.Generic;
using CSharp._7Kyu;
using CSharp._6Kyu;
using CSharp._4Kyu;
using System.Diagnostics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 371;
            var result = value.ToString().Select(v => Math.Pow(int.Parse(v.ToString()), value.ToString().Length));

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        static void RunMe()
        {
            var input = 371;

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata6.Narcissistic(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);

            Console.WriteLine("RunTime: " + milliseconds);
        }
    }
}
