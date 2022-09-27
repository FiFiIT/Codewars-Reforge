using System;
using System.Collections.Generic;
using CSharp._5kyu;
using CSharp._5kyuRepeat;
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
            var game = new List<int[]>(){
                new int[]{5, 3},new int[]{3, 5},new int[]{4, 1},new int[]{2, 5},new int[]{2, 2},new int[]{3, 1},new int[]{1, 2},new int[]{2, 5},new int[]{1, 4},new int[]{3, 4},new int[]{3, 4},new int[]{5, 5},new int[]{3, 1},new int[]{1, 1},new int[]{1, 2},new int[]{2, 2},new int[]{3, 2}
            };
            var test = new Kata5.SnakesLadders();

            foreach (var roll in game)
            {
                Console.WriteLine(test.play(roll[0], roll[1]));
            }

            // RunMe();
        }

        static void RunMe()
        {

            var input = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Repeat.Rot13("EBG13 rknzcyr.");

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            Console.WriteLine(result);

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
