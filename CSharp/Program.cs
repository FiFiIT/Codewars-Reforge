using System;
using System.Collections.Generic;
using CSharp._5kyu;
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
            // var result = Kata5.FindS(55, 91);
            // System.Console.WriteLine(result);
            RunMe();
        }

        static void RunMe()
        {
            //211: < < 112, 196 >, < 196, 112 > >
            // 21952 
            var input = new long[] { 101 };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<List<long[]>>();
            foreach (var item in input)
            {
                result.Add(Kata5.removNb(item));
            }

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            // foreach (var item in result)
            // {
            //     Console.WriteLine(String.Join(", ", item[0]));
            // }

            Console.WriteLine("RunTime: " + milliseconds);
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
