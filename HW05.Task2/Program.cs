using System;
using System.Text;

namespace HW05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceSymbols("1a!2.3!!.. 4.!.?6 7! ..?"));
        }

        private static string ReplaceSymbols(string str)
        {
            var sb = new StringBuilder();
            var indexOfQuestion = str.IndexOf('?');

            for (int i = 0; i < indexOfQuestion; i++)
            {
                if (str[i].Equals('!') || str[i].Equals('.'))
                    continue;
                sb.Append(str[i]);
            }

            for (int i = indexOfQuestion; i < str.Length; i++)
            {
                if (str[i].Equals(' '))
                {
                    sb.Append('_');
                    continue;
                }
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
