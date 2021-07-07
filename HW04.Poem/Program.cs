using System;

namespace HW04.Poem
{
    class Program
    {
        static void Main(string[] args)
        {
            WritePoem();
        }

        private static void WritePoem()
        {
            Console.WriteLine("Введите стихотворение:");
            Console.WriteLine(string.Join('\n', Console.ReadLine().Replace("о", "а", StringComparison.Ordinal).Replace("О", "А", StringComparison.Ordinal).Split(';')));
        }
    }
}
