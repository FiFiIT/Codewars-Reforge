using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string[] dirReduc(String[] arr)
        {
            var opposite = new Dictionary<string, string>{
                {"NORTH", "SOUTH"},
                {"EAST", "WEST"},
                {"SOUTH", "NORTH"},
                {"WEST", "EAST"},
            };

            var result = new List<string>();

            foreach (var dir in arr)
            {
                if (result.Count() > 0 && dir == opposite[result.LastOrDefault()])
                {
                    result.RemoveAt(result.Count() - 1);
                }
                else
                {
                    result.Add(dir);
                }
            }

            return result.ToArray<string>();
        }

        public static String[] dirReduc_kata_1(String[] arr)
        {
            Stack<String> stack = new Stack<String>();

            foreach (String direction in arr)
            {
                String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

                switch (direction)
                {
                    case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "EAST": if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "WEST": if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                }
            }
            String[] result = stack.ToArray();
            Array.Reverse(result);

            return result;
        }
    }
}