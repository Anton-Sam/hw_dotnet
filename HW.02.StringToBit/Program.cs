using System;
using System.Linq;

namespace HW._02.StringToBit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Hello guys from the most popular programming course – C#!";
            string result = ConvertStringToBits(input);
            Console.WriteLine(result);
        }

        private static string ConvertStringToBits(string input)
        {
            return string.Join(" ", input.Select(ch => Convert.ToString(ch, 2)));
        }
    }
}
