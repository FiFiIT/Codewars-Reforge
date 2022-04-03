using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static bool ValidatePin_fifi(string pin)
        {
            int[] nums = { 4, 6 };
            return nums.Contains(pin.Length) && !Regex.Match(pin, @"[^\d]").Success;
        }

        public static bool ValidatePin(string pin)
        {
            return pin.All(p => char.IsDigit(p)) && (pin.Length == 4 || pin.Length == 6);
        }
    }
}