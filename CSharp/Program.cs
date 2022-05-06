using System;
using System.Linq;
using System.Collections.Generic;
using CSharp._7Kyu;
using CSharp._6Kyu;
using CSharp._4Kyu;
using System.Diagnostics;
using System.Text;

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
            var input = new int[] { 1, 3, 2, 8, 5, 4 };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = Kata6.SortArray(input);

            stopWath.Stop();
            string milliseconds = String.Format("{0}ms", stopWath.ElapsedMilliseconds);

            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }


            Console.WriteLine("RunTime: " + milliseconds);
        }
    }
}
