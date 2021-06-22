using System;

namespace HW03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Сложение");
            Console.WriteLine("Введите первый параметр");
            number1 = NumberInputWithConvert();
            Console.WriteLine("Введите второй параметр");
            number2 = NumberInputWithConvert();
            Console.WriteLine($"Сумма: {Addition(number1, number2)}");

            Console.WriteLine("Вычитание");
            Console.WriteLine("Введите первый параметр");
            number1 = NumberInputWithConvert();
            Console.WriteLine("Введите второй параметр");
            number2 = NumberInputWithConvert();
            Console.WriteLine($"Разница: {Subtraction(number1, number2)}");

            Console.WriteLine("Умножение");
            Console.WriteLine("Введите первый параметр");
            number1 = NumberInputWithConvert();
            Console.WriteLine("Введите второй параметр");
            number2 = NumberInputWithConvert();
            Console.WriteLine($"Произведение: {Multiplication(number1, number2)}");

            Console.WriteLine("Деление");
            Console.WriteLine("Введите первый параметр");
            number1 = InputNumberWithTryParse();
            Console.WriteLine("Введите второй параметр");
            number2 = InputNumberWithTryParse();
            Console.WriteLine($"Частное: {Division(number1, number2)}");

            Console.WriteLine("Остаток от деления");
            Console.WriteLine("Введите первый параметр");
            number1 = InputNumberWithTryParse();
            Console.WriteLine("Введите второй параметр");
            number2 = InputNumberWithTryParse();
            Console.WriteLine($"Остаток: {Modulo(number1, number2)}");

            Console.WriteLine("Плозадь круга");
            Console.WriteLine("Введите радиус");
            number1 = InputNumberWithTryParse();
            Console.WriteLine($"Площадь: {CircleSquare(number1)}");
        }

        private static int Addition(int number1, int number2) => number1 + number2;
        private static int Subtraction(int number1, int number2) => number1 - number2;
        private static int Multiplication(int number1, int number2) => number1 * number2;
        private static double Division(int number1, int number2) => number1 / (double)number2;
        private static int Modulo(int number, int module) => number / module;
        private static double CircleSquare(int radius) => Math.PI * radius * radius;

        private static int NumberInputWithConvert()
        {
            int output;
            while (true)
            {
                try
                {
                    output = Convert.ToInt32(Console.ReadLine());
                    return output;
                }
                catch
                {
                    Console.WriteLine("Неверный формат числа. Введите ещё раз:");
                    continue;
                }
            }
        }

        private static int InputNumberWithTryParse()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Неверный формат числа. Введите число ещё раз: ");
            }
            return result;
        }
    }
}
