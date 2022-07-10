using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            int pos = 0, peak = 0;
            var result = new Dictionary<string, List<int>>();
            result.Add("pos", new List<int>());
            result.Add("peaks", new List<int>());

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    pos = i;
                    peak = arr[i];
                }
                if (arr[i] > arr[i + 1] && pos != 0)
                {
                    result["pos"].Add(pos);
                    result["peaks"].Add(peak);

                    pos = 0;
                    peak = 0;
                }
            }

            return result;
        }
    }
}