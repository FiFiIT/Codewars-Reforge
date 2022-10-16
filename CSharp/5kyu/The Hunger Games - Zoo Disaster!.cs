using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string[] WhoEatsWho(string zoo)
        {
            var hierarchy = new List<string[]>()
            {
                new string[]{"antelope", "grass"},
                new string[]{"big-fish", "little-fish"},
                new string[]{"bug", "leaves"},
                new string[]{"bear", "big-fish"},
                new string[]{"bear", "bug"},
                new string[]{"bear", "chicken"},
                new string[]{"bear", "cow"},
                new string[]{"bear", "leaves"},
                new string[]{"bear", "sheep"},
                new string[]{"chicken", "bug"},
                new string[]{"cow", "grass"},
                new string[]{"fox", "chicken"},
                new string[]{"fox", "sheep"},
                new string[]{"giraffe", "leaves"},
                new string[]{"lion", "antelope"},
                new string[]{"lion", "cow"},
                new string[]{"panda", "leaves"},
                new string[]{"sheep", "grass"},
            };
            var zooList = zoo.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(zoo);
            if (zooList.Count() == 0) return new string[] { };

            var result = new List<string>() { zoo };

            for (int i = 0; i < zooList.Count(); i++)
            {
                var animal = zooList[i];
                var feeds = hierarchy.Where(a => a[0] == animal).Select(a => a[1]);

                if (i > 0)
                {
                    if (feeds.Contains(zooList[i - 1]))
                    {
                        var msg = $"{animal} eats {zooList[i - 1]}";
                        Console.WriteLine(msg);
                        result.Add(msg);
                        zooList.RemoveAt(i - 1);
                        i = -1;
                        continue;
                    }
                }
                if (i + 1 < zooList.Count() && feeds.Contains(zooList[i + 1]))
                {
                    var msg = $"{animal} eats {zooList[i + 1]}";
                    Console.WriteLine(msg);
                    result.Add(msg);
                    zooList.RemoveAt(i + 1);
                    i = -1;
                }
            }

            result.Add(String.Join(",", zooList));

            return result.ToArray();
        }
    }
}
