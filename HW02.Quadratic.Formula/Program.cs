using System;
using System.Globalization;

namespace HW02.Quadratic.Formula
{
    class Program
    {
        static void Main(string[] args)
        {

            FindQuadraticEquation();

        }
        private static void FindQuadraticEquation()
        {
            double a, b, c;

            Console.WriteLine("Решение квадратного уравнения вида: ax^2 + bx + c = 0\nВведите коэффициент a: ");
            CheckInputValue(Console.ReadLine(), out a);

            Console.WriteLine("Введите коэффициент b: ");
            CheckInputValue(Console.ReadLine(), out b);

            Console.WriteLine("Введите коэффициент c: ");
            CheckInputValue(Console.ReadLine(), out c);

            FindRoots(a, b, c);

        }

        private static void CheckInputValue(string input, out double output)
        {
            while (!double.TryParse(input.Replace('.', ','), out output))
            {
                Console.WriteLine("Неверный формат числа. Введите ещё раз:");
                input = Console.ReadLine();
            }
        }

        private static void FindRoots(double a, double b, double c)
        {
            double x1, x2;
            double disc = b * b - 4 * a * c;
            if (disc < 0)
                Console.WriteLine("Решений нет");
            else if (disc == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1}");
            }
            else
            {
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }

        }
    }
}
