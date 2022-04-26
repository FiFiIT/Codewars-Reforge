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
            var bits = "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011";
            var cleanedBits = bits.Trim('0');

            var result = GetLengths(cleanedBits, "0");
            var unionResult = result.Union(GetLengths(cleanedBits, "1"));

            foreach (var x in unionResult)
            {
                Console.WriteLine(x);
            }

            var rate = unionResult.Min();
            Console.WriteLine("Rate: " + rate);

            var delimiter = GetDelimiter(7, "0", rate);
            Console.WriteLine(delimiter);
        }

        static string GetDelimiter(int len, string c, int rate)
        {
            var arr = Enumerable.Range(0, len * rate);
            var result = arr.Aggregate("", (acc, _) => acc + c);

            return result;
        }


        static IEnumerable<int> GetLengths(string cleanedBits, string del)
        {
            var a = cleanedBits.Split(del, StringSplitOptions.RemoveEmptyEntries);
            var b = a.Select(s => s.Length);

            return b;
        }

        static void RunMe()
        {
            var input = new int[] { 1, 2, 3, 4, 3, 2, 1 };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata6.FindEvenIndex(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);

            Console.WriteLine("RunTime: " + milliseconds);
        }
    }
}
