using System;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string BrainLuck(string code, string input, string outp = "")
        {
            var data = new byte[32];
            for (int i = 0, inP = 0, p = 0; i < code.Length; i++)
            {
                if (code[i] == '>') p++;
                if (code[i] == '<') p--;
                if (code[i] == '+') data[p]++;
                if (code[i] == '-') data[p]--;
                if (code[i] == '.') outp += (char)data[p];
                if (code[i] == ',') data[p] = (byte)input[inP++];
                if (code[i] == '[' & data[p] == 0) i = BMatch(code, i, -1, 1, ']');
                if (code[i] == ']' & data[p] != 0) i = BMatch(code, i, 1, -1, '[');
            }
            return outp;
        }

        private static int BMatch(string s, int i, int b, int dir, char pair)
        {
            if (s[i] == pair && b == 0) return i;
            if (s[i] == '[') b++;
            if (s[i] == ']') b--;
            return BMatch(s, i + dir, b, dir, pair);
        }
        public static string BrainLuck_FiFi(string code, string input)
        {
            string output = String.Empty;
            var memory = new uint[64];
            int pointer = 0;

            for (int i = 0; i < code.Length; i++)
            {
                switch (code[i])
                {
                    case ',':
                        memory[pointer] = (uint)input.First();
                        input = input.Substring(1);
                        break;
                    case '.':
                        var x = Convert.ToChar(memory[pointer]);
                        output += x;
                        break;
                    case '+':
                        memory[pointer] = memory[pointer] == 255 ? 0 : memory[pointer] + 1;
                        break;
                    case '-':
                        memory[pointer] = memory[pointer] == 0 ? 255 : memory[pointer] - 1;
                        break;
                    case '>':
                        pointer = pointer + 1 > memory.Length ? pointer : pointer + 1;
                        break;
                    case '<':
                        pointer = pointer - 1 < 0 ? 0 : pointer - 1;
                        break;
                    case '[':
                        if (memory[pointer] == 0)
                        {
                            var skip = 0;
                            var ptr = i + 1;
                            while (code[ptr] != ']' || skip > 0)
                            {
                                if (code[ptr] == '[') skip++;
                                if (code[ptr] == ']') skip--;

                                ptr++;
                                i = ptr;
                            }
                        }

                        break;
                    case ']':
                        if (memory[pointer] != 0)
                        {
                            var skip = 0;
                            var ptr = i - 1;
                            while (code[ptr] != '[' || skip > 0)
                            {
                                if (code[ptr] == ']') skip++;
                                if (code[ptr] == '[') skip--;

                                ptr--;
                                i = ptr;
                            }
                        }

                        break;
                }
            }

            return output;
        }
    }
}