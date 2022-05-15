using System;
using System.Linq;
using System.Collections.Generic;
using CSharp._7Kyu;
using CSharp._6Kyu;
using CSharp._4Kyu;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

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
            var input = "(BfwTLPP!vJ@BYETECVtXRHArbU@VDaGn!";
            // var input = GetFromFile("./temp/longArray1.txt");

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata6.DuplicateEncode(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            var expected = "((((())))())())())(()()((())()()()";
            Console.WriteLine($"{expected} {expected == result}");
            Console.WriteLine(result);
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }


            Console.WriteLine("RunTime: " + milliseconds);
        }
        static IEnumerable<int> GetFromFile(string path)
        {
            List<int> result = new List<int>();

            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                foreach (var x in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                {
                    result.Add(int.Parse(x));
                }
            }

            return result;
        }
    }
}
