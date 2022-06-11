using System;
using System.Collections.Generic;
using CSharp._5kyu;
using System.Diagnostics;
using System.IO;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // char c = 't';
            // int step = 65;
            // c = c.ToString()[0];

            // if ((int)c > 90) step = 97;

            // var result = ((int)c - step + 1);

            // Console.WriteLine((char)(result + step));
            RunMe();
        }

        static void RunMe()
        {
            var input = "Codewars is nice";
            var input_1 = new List<String>() { "aabb", "abcd", "bbaa", "dada" };
            // var input = GetFromFile("./temp/longArray1.txt");

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata5.GenerateHashtag(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);
            // Console.WriteLine(String.Join(", ", result));
            //foreach (var item in result)
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
                foreach (var x in line.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                {
                    result.Add(int.Parse(x));
                }
            }

            return result;
        }
    }
}
