using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace HW05.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a1 = { "arp", "live", "strong" };
            string[] a2 = { "lively", "alive", "harp", "sharp", "armstrong" };

            Array.ForEach(GetSortedArrayOfSubstrings(a1, a2), Console.WriteLine);
        }

        private static string[] GetSortedArrayOfSubstrings(string[] substrings, string[] fullStrings)
        {
            var result = new List<string>();
            Array.ForEach(substrings, substr =>
            {
                if (fullStrings.Contains(substr, new StringComparer()))
                    result.Add(substr);
            });
            return result.OrderBy(s => s).ToArray();
        }
    }

    class StringComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y) => x is null || y is null ? false : x.Contains(y);

        public int GetHashCode([DisallowNull] string obj) => 1;
    }
}
