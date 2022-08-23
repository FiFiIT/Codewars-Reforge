using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static Dictionary<string, int> Interpret(string[] program)
        {
            var memory = new Dictionary<string, int>();
            int GetValue(string s) => int.TryParse(s, out var tmp) ? tmp : memory[s];

            for (var pointer = 0; pointer < program.Length; pointer++)
            {
                var values = program[pointer].Split();
                var _ = values[0] switch
                {
                    "mov" => memory[values[1]] = GetValue(values[2]),
                    "inc" => memory[values[1]]++,
                    "dec" => memory[values[1]]--,
                    "jnz" => pointer += GetValue(values[1]) != 0 ? GetValue(values[2]) - 1 : 0,
                    _ => throw new Exception("Input error")
                };
            }

            return memory;
        }
    }
}