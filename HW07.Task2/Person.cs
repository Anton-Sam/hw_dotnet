using System;

namespace HW07.Task2
{
    class Person
    {
        public string Name { get; set; }
        public House House { get; set; }

        public void ShowData()
        {
            Console.WriteLine(Name);
            House.ShowData();
            House.GetDoor().ShowData();
        }
    }
}
