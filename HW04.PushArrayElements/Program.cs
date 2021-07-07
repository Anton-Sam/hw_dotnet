using System;
using System.Linq;

namespace HW04.PushArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            StartTask();
        }

        private static int[] InputArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length - 1; i++)
                array[i] = InputNumber();
            return array;
        }

        private static int InputNumber()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
                Console.WriteLine("Неверный формат числа. Введите ещё раз:");
            return result;
        }

        private static int[] ArrayWithPushElement(int value, int position, int[] array)
        {
            var list = array.ToList();
            if (position < array.Length)
                list.Insert(position, value);
            return list.Take(array.Length).ToArray();
        }

        private static void PrintArray(int[] array) => Array.ForEach(array ?? new int[] { }, Console.WriteLine);

        private static void StartTask()
        {
            Console.WriteLine("Введите длину массива:");
            var length = InputNumber();

            Console.WriteLine($"Введите {length - 1} элементов массива:");
            var array = InputArray(length);

            Console.WriteLine("Введенный массив:");
            PrintArray(array);

            Console.WriteLine("Введите ещё одно занчение:");
            var value = InputNumber();

            Console.WriteLine("Введите его позицию");
            var position = InputNumber();

            Console.WriteLine("Полученный массив:");
            PrintArray(ArrayWithPushElement(value, position, array));
        }

    }
}
