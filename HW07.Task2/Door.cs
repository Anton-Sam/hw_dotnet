using System;

namespace HW07.Task2
{
    class Door
    {
        private string Color { get; set; }

        public Door(string color) => Color = color;

        public void ShowData() => Console.WriteLine($"I'm a door, my color is {Color}");
    }
}
