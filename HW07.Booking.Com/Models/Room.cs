using System;

namespace HW07.Booking.Com.Models
{
    class Room
    {
        public Guid Id { get; } = Guid.NewGuid();
        public int Square { get; set; }
        public int BedsCount { get; set; }
        public int CostPerNight { get; set; }
        public bool IsFree { get; private set; } = true;
        public Hotel Hotel { get; private set; }
        public int FullPrice { get; private set; }

        public Room(Hotel hotel, int square, int bedsCount, int costPerNight) => (Hotel, Square, BedsCount, CostPerNight) = (hotel, square, bedsCount, costPerNight);

        public void Book(int period)
        {
            IsFree = false;
            FullPrice = period * CostPerNight;
            Console.WriteLine($"{ToString()}\nSuccesfully book for {period} days");
        }

        public void Purchase() => Console.WriteLine($"{ToString()}\nSuccesfully purchase for {FullPrice}$");

        public override string ToString() => $"Room {Id}\nSquare: {Square}m2\nBeds in room: {BedsCount}\nCost per hight: {CostPerNight}";
    }
}
