using System;
using System.Collections.Generic;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMotoList(3).ForEach(Console.WriteLine);
        }

        private static List<Motorcycle> CreateMotoList(int count)
        {
            var motoList = new List<Motorcycle>();

            for (var i = 0; i < count; i++)
            {
                Console.WriteLine($"Создание мотоцикла {i+1}:");
                Console.WriteLine("Введите модель:");
                var model = Console.ReadLine();

                Console.WriteLine("Введите название производителя:");
                var manufacturer = Console.ReadLine();

                Console.WriteLine("Введите пробег:");
                var odometre = Console.ReadLine();

                Console.WriteLine("Введите объем:");
                var volume = Console.ReadLine();

                Console.WriteLine("Введите мощность:");
                var power = Console.ReadLine();

                Console.WriteLine("Введите тип двигателя:");
                var engineType = Console.ReadLine();

                try
                {
                    var moto = new Motorcycle(model, manufacturer, uint.Parse(odometre), ushort.Parse(volume), ushort.Parse(power), engineType);
                    motoList.Add(moto);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\nВведите параметры мотоцикла ещё раз");
                    i--;
                }
            }
            return motoList;
        }
    }
}
