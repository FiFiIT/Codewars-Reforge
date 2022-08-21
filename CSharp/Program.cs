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
            var input = new string[,] {
                { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a", " mov a -10", "mov b a", "inc a", "dec b", "jnz a -2" },
            };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<string>();
            foreach (var item in input)
            {
                result.Add(Kata5.Interpret(item));
            }

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            foreach (var item in result)
            {
                Console.WriteLine(String.Join(", ", item));
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
