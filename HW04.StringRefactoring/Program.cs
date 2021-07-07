using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW04.StringRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskStart();
        }

        private static string RemoveLongestWord(string str, char separator) => str?.Replace(GetMaxLengthSubstring(str, separator), "") ?? "";

        private static string SwapWords(string str, char separator)
        {
            if (string.IsNullOrWhiteSpace(str))
                return "";

            var arrayStr = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var maxStr = GetMaxLengthSubstring(str, separator);
            var minStr = GetMinLengthSubstring(str, separator);

            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (arrayStr[i] == maxStr)
                    arrayStr[i] = minStr;
                else if (arrayStr[i] == minStr)
                    arrayStr[i] = maxStr;
            }
            return string.Join(separator, arrayStr);
        }

        private static string GetMaxLengthSubstring(string str, char separator) => str?.Split(separator, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(str => str.Length).First() ?? "";

        private static string GetMinLengthSubstring(string str, char separator) => str?.Split(separator, StringSplitOptions.RemoveEmptyEntries).OrderBy(str => str.Length).First() ?? "";

        private static (int lettersCount, int punctuationsCount) GetLettersAndPunctsCount(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return (0, 0);
            return (Regex.Replace(str, @"[^\w]", "", RegexOptions.IgnoreCase).Length, Regex.Replace(str, @"[\w\s]", "", RegexOptions.IgnoreCase).Length);
        }

        private static string[] SortStringArray(string str, char separator) => str?.Split(separator, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(s => s.Length).ToArray() ?? new string[] { };

        private static void TaskStart()
        {
            const string strWithSpaces = "Hello my friends I'm here";
            const string strWithPuncts = "Hello, world! I'm here.";
            const char separator = ' ';

            Console.WriteLine($"Тесты для строки\n{strWithSpaces}");

            Console.WriteLine($"Удаление самого длинного слова:\n{RemoveLongestWord(strWithSpaces, separator)}");

            Console.WriteLine($"Поменять местами самое длинное и самое короткое слова:\n{SwapWords(strWithSpaces, separator)}");

            var countPair = GetLettersAndPunctsCount(strWithPuncts);
            Console.WriteLine($"Посчитать кол-во букв и знаков для строки \n{strWithPuncts}");
            Console.WriteLine($"Букв: {countPair.lettersCount}\nЗнаков препинания: {countPair.punctuationsCount} (без пробелов)");

            Console.WriteLine("Сортировка по длине строки:");
            Console.WriteLine($"Исходная строка: {strWithSpaces}\nОтсортированная строка: {string.Join(' ', SortStringArray(strWithSpaces, separator))}");
        }
    }
}
