using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _7Kyu
{
    public static partial class Kata7
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var result = new List<int>();

            foreach(var l in listOfItems){
                if(l is int)
            }

            result = listOfItems.Select(a => Regex.IsMatch(a.ToString(), @"\d"));

            return result;
        }

    }
}