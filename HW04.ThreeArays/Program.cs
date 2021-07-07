using System;
using System.Linq;

namespace HW04.ThreeArays
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeArrays(3);
        }

        private static void ThreeArrays(int length)
        {
            var randomArray = GetRandomArray(length);
            var inputArray = InputArray(length);
            var sumArray = GetArraysSum(randomArray, inputArray);

            Console.WriteLine("Массив случайных чисел:");
            PrintArray(randomArray);

            Console.WriteLine("Массив с клавиатуры:");
            PrintArray(inputArray);

            Console.WriteLine("Сумарный массив:");
            PrintArray(sumArray);
        }

        private static int[] GetRandomArray(int length)
        {
            var array = new int[length];
            var rand = new Random();
            return array.Select(a => rand.Next(0, 30)).ToArray();
        }

        private static int[] InputArray(int length)
        {
            var array = new int[length];
            Console.WriteLine($"Введите массив длинной {length}:");
            return array.Select(a => InputNumber()).ToArray();
        }

        private static int InputNumber()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
                Console.WriteLine("Неверный формат числа. Введите ещё раз:");
            return result;
        }

        private static int[] GetArraysSum(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return null;
            var resArray = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
                resArray[i] = array1[i] + array2[i];
            return resArray;
        }

        private static void PrintArray(int[] array) => Array.ForEach(array ?? new int[] { }, Console.WriteLine);

    }
}
