using System;
using System.Linq;
using System.Collections.Generic;
using CSharp._7Kyu;
using CSharp._6Kyu;
using CSharp._5kyu;
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
            var input = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            // var input = GetFromFile("./temp/longArray1.txt");

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata5.MoveZeroes_Kata(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(String.Join(",", result));
            Console.WriteLine(String.Join(",", new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }));
            // foreach (var item in result)
            // {
            //     Console.Write(item);
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
