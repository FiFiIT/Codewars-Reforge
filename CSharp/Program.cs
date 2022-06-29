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
            var input = new BigInteger[] { new BigInteger(5) };
            // var input_1 = new List<String>() { "aabb", "abcd", "bbaa", "dada" };
            // var input = GetFromFile("./temp/longArray1.txt");

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<BigInteger>();
            foreach (var item in input)
            {
                result.Add(Kata5.perimeter(item));
            }

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            //Console.WriteLine(result);
            // Console.WriteLine(String.Join(", ", result));
            foreach (var item in result)
            {
                Console.WriteLine(item);
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
