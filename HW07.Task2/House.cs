using System;

namespace HW07.Task2
{
    class House
    {
        protected int Area { get; set; }
        private Door Door { get; set; }

        public Door GetDoor() => Door ?? new Door("Red");

        public void ShowData() => Console.WriteLine($"I am a house, my area is {Area} m2");
    }
}
