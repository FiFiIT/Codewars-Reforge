using System;
using System.Collections.Generic;
using CSharp._5kyu;
using CSharp._5kyuRepeat;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMe();
        }

        static void RunMe()
        {
            var input = "";
            int[,] a = { { 1, 2 }, { 3, 2 } };
            int[,] b = { { 3, 2 }, { 1, 1 } };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata5.MixedFraction("42/9");

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);

            Console.WriteLine("RunTime: ", milliseconds);
        }
        static IEnumerable<int> GetFromFile(string path)
        {
            List<int> result = new List<int>();

            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                foreach (var x in line.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                {
                    result.Add(int.Parse(x));
                }
            }

            return result;
        }
    }
}
