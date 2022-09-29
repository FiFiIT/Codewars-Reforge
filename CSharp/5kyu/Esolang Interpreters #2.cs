using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string Interpreter(string code, string tape)
        {
            int pointer = 0;
            var data = tape.ToCharArray().Select(t => int.Parse(t.ToString())).ToList();

            for (int i = 0; i < code.Length; i++)
            {
                switch (code[i])
                {
                    case '>':
                        pointer++;
                        break;
                    case '<':
                        pointer--;
                        break;
                    case '*':
                        data[pointer] = data[pointer] == 1 ? 0 : 1;
                        break;
                    case '[':
                        if (data[pointer] == 0) i = Jump(code, i + 1, 1, ']', 0, '[');
                        break;
                    case ']':
                        if (data[pointer] == 1) i = Jump(code, i - 1, -1, '[', 0, ']');
                        break;
                }

                if (pointer < 0 || pointer >= tape.Length)
                    return String.Join("", data);
            }

            return String.Join("", data);
        }

        private static int Jump(string code, int i, int dir, char b, int repeat, char br)
        {
            if (code[i] == b && repeat == 0)
                return i;

            if (code[i] == br) repeat++;
            if (code[i] == b) repeat--;

            return Jump(code, i + dir, dir, b, repeat, br);
        }
    }
}