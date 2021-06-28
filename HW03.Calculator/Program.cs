using System;

namespace HW03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorActionWithInputParams("Сложение", "Сумма", Addition);

            CalculatorActionWithInputParams("Вычитание", "Разница", Subtraction);

            CalculatorActionWithInputParams("Умножение", "Произведение", Multiplication);

            CalculatorActionWithInputParams("Деление", "Частное", Division);

            CalculatorActionWithInputParams("Нахождение остатка", "Остаток", Modulo);

            CalculatorActionWithInputParams("Площадь круга", "Площпдь", CircleSquare);
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

        private static void CalculatorActionWithInputParams<T>(string operationName, string resultName, Func<int, int, T> calcFunc)
        {
            int param1, param2;
            Console.WriteLine(operationName);
            Console.WriteLine("Введите первый параметр");
            param1 = NumberInputWithConvert();
            Console.WriteLine("Введите второй параметр");
            param2 = NumberInputWithConvert();
            Console.WriteLine($"{resultName}: {calcFunc(param1, param2)}");
        }

        private static void CalculatorActionWithInputParams<T>(string operationName, string resultName, Func<int, T> calcFunc)
        {
            int param;
            Console.WriteLine(operationName);
            Console.WriteLine("Введите  параметр");
            param = NumberInputWithConvert();
            Console.WriteLine($"{resultName}: {calcFunc(param)}");
        }

    }
}
