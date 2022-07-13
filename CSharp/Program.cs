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
            RunMe();
        }

        static void RunMe()
        {
            var input = new List<long[]>()
            {
                new long[] {2,2,50},
                new long[] {2,100,110},
                new long[] {4,100,110},
                new long[] {2,100,103},
                new long[] {6,100,110},
                new long[] {8,300,400},
                new long[] {10,300,400},
            };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<long[]>();
            foreach (var item in input)
            {
                result.Add(Kata5.Gap((int)item[0], item[1], item[2]));
            }

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            //Console.WriteLine(result);
            // Console.WriteLine(String.Join(", ", result));

            int pad = input.Max(p => p.Length) + 1;
            foreach (var item in result)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"[{item[0]}, {item[1]}]");
                }
                else
                {
                    System.Console.WriteLine("NULL");
                }
            }


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
