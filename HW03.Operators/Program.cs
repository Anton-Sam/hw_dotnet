using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            StartCalculator();
        }

        private static double Sum(double num1, double num2) => num1 + num2;

        private static double InputNumber()
        {
            double result;
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out result))
            {
                Console.WriteLine("Неверный формат числа. Введите число ещё раз: ");
            }
            return result;
        }

        private static string InputOperator()
        {
            string result = Console.ReadLine();
            while (result != "+" && result != "-")
            {
                Console.WriteLine("Неверный оператор. Значение должно быть '+' или '-'. Введите ещё раз:");
                result = Console.ReadLine();
            }
            return result;
        }

        private static double Calculate(double num1, double num2, string oper)
        {
            double result;
            if (oper == "+")
                result = num1 + num1;
            else
                result = num1 - num2;
            return result;
        }

        private static void CheckAnswer(double realResult, double expectedResult)
        {
            if (realResult == expectedResult)
                Console.WriteLine("Правильно!");
            else if (realResult > expectedResult)
                Console.WriteLine("Неправильно!\nДолжно быть больше.");
            else
                Console.WriteLine("Неправильно!\nДолжно быть меньше.");
        }

        private static void StartCalculator()
        {
            Console.WriteLine("Алгоритм сложения двух чисел");

            Console.WriteLine("Введите первое число:");
            var number1 = InputNumber();

            Console.WriteLine("Введите второе число:");
            var number2 = InputNumber();

            Console.WriteLine("Введите оператор:");
            var oper = InputOperator();

            Console.WriteLine("Введите результат вычисления:");
            var result = InputNumber();

            CheckAnswer(Calculate(number1, number2, oper), result);
        }
    }
}
