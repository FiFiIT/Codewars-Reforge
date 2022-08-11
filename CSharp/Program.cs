﻿using System;
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
            var pass = new string[] { "R", "cziyaq3AskTP69 ", "dw09zSHpuaW1MouobDPTfV", "gY4FdhN", "68bHq5Ux8O75boyUZ", "X6Ujd", "ZR275kMuB1itzQF8ZVg", " DRkmL3XG", "", "Eqe!kpvvn6vNN0_ !", "mqdDvkEBN9PDUiY8ezbXCgi2_F7ZT" };

            foreach (var p in pass)
            {
                var valid = Kata5.Alphanumeric(p);
                var pp = $"'{p}'";
                Console.WriteLine($"{pp.PadRight(pass.Max(p => p.Length) + 2)} is {valid}");
            }


            // RunMe();
        }

        static void RunMe()
        {
            var input = new BigInteger[][] {
                // new BigInteger [] {4,1},
                // new BigInteger [] {4,2},
                // new BigInteger [] {9,7},
                // new BigInteger [] {10, BigInteger.Pow(10,10)},
                // new BigInteger [] {BigInteger.Pow(2, 200), BigInteger.Pow(2, 300)},
                // new BigInteger [] {BigInteger.Parse("3715290469715693021198967285016729344580685479654510946723"), BigInteger.Parse("68819615221552997273737174557165657483427362207517952651")},
                new BigInteger [] {BigInteger.Parse("3715290469715693021198967285016729344580685479654510946723"), BigInteger.Parse("68819615221552997273737174557165657483427362207517952651")},
             };

            Stopwatch stopWath = new Stopwatch();
            stopWath.Start();

            var result = new List<int>();
            foreach (var item in input)
            {
                result.Add(Kata5.GetLastDigit(item[0], item[1]));
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
