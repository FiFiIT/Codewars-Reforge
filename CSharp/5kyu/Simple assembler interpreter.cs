using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static Dictionary<string, int> Interpret(string[] program)
        {
            var result = new Dictionary<string, int>();
            var input = new List<string>();

            string cmd = string.Empty;
            string arg1 = string.Empty;
            string arg2 = string.Empty;

            for (int i = 0; i < program.Length; i++)
            {
                input = program[i].Split(' ').ToList();
                cmd = input[0];
                arg1 = input[1];
                if (input.Count > 2)
                {
                    arg2 = input[2];
                }

                switch (cmd)
                {
                    case "mov":
                        result[arg1] = GetValue(arg2, result);

                        break;
                    case "inc":
                        result[arg1]++;
                        break;
                    case "dec":
                        result[arg1]--;
                        break;
                    case "jnz":
                        if (result[arg1] != 0)
                        {
                            int dir = GetValue(arg2, result);
                            if (dir != 0) dir -= 1;

                            i += dir;
                        }
                        break;
                }
            }

            return result;
        }
        public static int GetValue(string arg, Dictionary<string, int> result)
        {
            int value;
            if (int.TryParse(arg, out value))
            {
                return value;
            }
            else
            {
                return result[arg];
            }
        }
    }
}