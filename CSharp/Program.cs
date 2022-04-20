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
            var input = "111";

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata4.DecodeBits(input);
            Console.WriteLine(result);
            result = Kata6.Decode(result);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);

            Console.WriteLine("RunTime: " + milliseconds);
        }
    }
}
