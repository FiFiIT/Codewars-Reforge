using System;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string GetReadableTime(int seconds)
        {
            var sec = seconds % 60;
            var minutes = (seconds / 60) % 60;
            var hours = (int)(seconds / 3600);

            return string.Format("{0:d2}:{1:d2}:{2:d2}", hours, minutes, sec);
        }
        public static string GetReadableTime_Kata(int seconds)
        {
            var t = TimeSpan.FromSeconds(seconds);
            return String.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }
    }
}