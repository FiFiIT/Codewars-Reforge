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
            var input = "Raw Danger!(Zettai Zetsumei Toshi 2) for the PlayStation 2 is a bit queer, but an alright game I guess, uh... CJ kicks and vexes Tenpenny precariously ? This should be a pangram now, probably.";

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata6.IsPangram(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);

            Console.WriteLine("RunTime: " + milliseconds);
        }
    }
}
