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
            var collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            var helper = new PagnationHelper<int>(collection, 10);

            Console.WriteLine(helper.ItemCount);
            Console.WriteLine(helper.PageCount);

            var indices = new int[] { -1, 12, 24 };
            foreach (var index in indices)
            {
                var page = helper.PageIndex(index);
                Console.WriteLine($"{index} is on page {page}");
            }

            var pages = new int[] { -1, 1, 3 };
            foreach (var page in pages)
            {
                var items = helper.PageItemCount(page);
                System.Console.WriteLine($"We have {items} items on page {page}");
            }


            // RunMe();
        }

        static void RunMe()
        {
            var input = new Travel[]
            {
                new Travel() { Visit = 3, Towns = new List<int>() { 50, 55, 56, 57, 58 }, Distance = 163},
                new Travel() { Visit = 3, Towns = new List<int>() { 91, 74, 73, 85, 73, 81, 87 }, Distance = 230},
                new Travel() { Visit = 2, Towns = new List<int>() { 91, 74, 73, 85, 73, 81, 87 }, Distance = 331}
            };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<int?>();
            foreach (var item in input)
            {
                result.Add(Kata5.chooseBestSum(item.Distance, item.Visit, item.Towns));
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
