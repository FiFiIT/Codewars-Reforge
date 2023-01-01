using System.Linq;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static IEnumerable<string> words;
        public static string FindMostSimilar(string term)
        {
            string simillar = "";
            double highScore = 0;

            foreach (var word in words)
            {
                double maxLength = Math.Max(word.Length, term.Length);

                int dist = LevenshteinDistance(term, word);
                var simillarity = (maxLength - dist) / maxLength;
                Console.WriteLine($"{simillarity} = {term} & {word}");

                if (simillarity > highScore)
                {
                    highScore = simillarity;
                    simillar = word;
                }
            }

            return simillar;
        }
        // https://www.youtube.com/watch?v=MiqoA-yF-0M
        public static int LevenshteinDistance(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;

            int[][] T = new int[m + 1][];
            for (int i = 0; i <= m; ++i)
            {
                T[i] = new int[n + 1];
            }

            for (int i = 0; i <= m; i++)
            {
                T[i][0] = i;
            }
            for (int j = 1; j <= n; j++)
            {
                T[0][j] = j;
            }

            int cost;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    cost = X[i - 1] == Y[j - 1] ? 0 : 1;

                    var v1 = Math.Min(T[i - 1][j] + 1, T[i][j - 1] + 1);
                    var v2 = T[i - 1][j - 1] + cost;

                    T[i][j] = Math.Min(v1, v2);
                }
            }

            return T[m][n];
        }
    }
}