using System;
using System.Text.RegularExpressions;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcExpression(GetMathExpressionFromString("gdfgdf23d,4dg54gf+23oP42")));
        }

        private static string GetMathExpressionFromString(string str) => Regex.Replace(str, @"[^\d+*/-]", "");

        private static double CalcExpression(string str)
        {
            var reg = Regex.Match(str, @"[+*/-]");

            if (!reg.Success)
                return 0;

            var separator = reg.Value;
            var values = str.Split(separator);
            var number1 = int.Parse(values[0]);
            var number2 = int.Parse(values[1]);

            return separator switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" => number1 / (double)number2
            };
        }
    }
}
