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
            var input = new List<string>() {
                "fjd3IR9", "ghdfj32", "DSJKHD23", "dsF43", "4fdg5Fj3", "DHSJdhjsU", "fjd3IR9.;", "fjd3  IR9", "djI38D55", "a2.d412", "JHD5FJ53", "!fdjn345", "jfkdfj3j", "123", "abc", "123abcABC", "ABC123abc", "Password123"
            };


            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new Dictionary<string, bool>();
            foreach (var item in input)
            {
                result.Add(item, Kata5.validate(item));
            }

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            //Console.WriteLine(result);
            // Console.WriteLine(String.Join(", ", result));

            int pad = input.Max(p => p.Length) + 1;
            foreach (var item in result)
            {
                System.Console.WriteLine(item.Key.PadRight(pad) + "---> " + item.Value);
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
