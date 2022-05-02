using System.Linq;
using System;
using System.Text;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static char FindMissingLetter(char[] array)
        {
            var first = Ord(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                if (first != Ord(array[i]))
                {
                    return Convert.ToChar(first);
                }
                first++;
            }

            throw new ArgumentException("Invlid parameters");
        }

        public static byte Ord(char c)
        {
            return Encoding.ASCII.GetBytes(c.ToString())[0];
        }

        public static char FindMissingLetter_kata_1(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i + 1] - array[i] != 1)
                {
                    return (char)(array[i] + 1);
                }
            }

            return ' ';
        }

        public static char FindMissingLetter_kata_2(char[] array)
        {
            return (char)Enumerable.Range(array[0], 25).First(a => !array.Contains((char)a));
        }

        public static char FindMissingLetter_kata_3(char[] array)
        {
            return Enumerable.Range(array[0], array.Length + 1).Select(a => (char)a).Except(array).Single();
        }
    }
}