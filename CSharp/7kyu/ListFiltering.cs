using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var result = new List<int>();

            foreach (var l in listOfItems)
            {
                if (l is int)
                {
                    result.Add((int)l);
                }
            }
            return result;
        }

        public static IEnumerable<int> GetIntegersFromList_2(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
    }
}