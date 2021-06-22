using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            FullYearsCountCalc();
        }

        private static int InputNumber()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Неверный формат числа. Введите число ещё раз: ");
            }
            return result;
        }

        private static void FullYearsCountCalc()
        {
            Console.WriteLine("Введите год рождения человека:");
            var birthYear = InputNumber();

            Console.WriteLine("Введите месяц рождения человека:");
            var birthMonth = InputNumber();

            Console.WriteLine("Введите текущий год:");
            var nowYear = InputNumber();

            Console.WriteLine("Введите текущий месяц:");
            var nowMonth = InputNumber();

            var birthDate = new DateTime(birthYear, birthMonth, 1);
            var nowDate = new DateTime(nowYear, nowMonth, 1);

            var yearsDiff = (nowDate - birthDate).Days / 365;

            Console.WriteLine($"Количество полных лет: {yearsDiff}");
        }
    }
}
