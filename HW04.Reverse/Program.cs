using System;
using System.Diagnostics;
using System.Linq;

namespace HW04.Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            StartTask();
        }
        private static void Reverse<T>(T[] array)
        {
            Reverse(array, 0, array.Length);
        }

        private static void Reverse<T>(T[] array, int index, int length)
        {
            var halfLength = index + length / 2;
            var fullLength = length + index - 1;
            for (int i = index, j = 0; i < halfLength; i++, j++)
                Swap(ref array[i], ref array[fullLength - j]);
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

        private static void TestReverse<T>(string name, Stopwatch sw, T[] array, Action<T[]> action)
        {
            Console.WriteLine(name);

            var testArray = new T[array.Length];
            Array.Copy(array, testArray, array.Length);

            sw.Start();
            action(testArray);
            sw.Stop();

            Console.WriteLine($"ms: {sw.ElapsedMilliseconds}");
        }

        private static void StartTask()
        {
            var rand = new Random();
            var array = new long[100_000_000];
            var sw = new Stopwatch();

            array = array.Select(a => (long)rand.Next(0, 100_000)).ToArray();

            TestReverse("Встроенный метод", sw, array, Array.Reverse);

            TestReverse("Свой метод", sw, array, Reverse);
        }
    }
}
