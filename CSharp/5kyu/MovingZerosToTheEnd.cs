using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var zeros = Enumerable.Repeat(0, arr.Count(x => x == 0));

            return arr.Where(x => x != 0).Concat(zeros).ToArray();
        }

        public static int[] MoveZeroes_Kata(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}