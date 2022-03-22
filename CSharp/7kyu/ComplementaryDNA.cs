using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        static Dictionary<char, string> trans = new Dictionary<char, string>(){
            {'A', "T" },
            {'T', "A"},
            {'C', "G"},
            {'G', "C"}
        };

        public static string MakeComplement(string dna)
        {
            return string.Join("", dna.Select(d => trans[d]));
        }
    }
}