using System;

namespace HW07.Task1
{
    class Person
    {
        protected int Age { get; set; }

        public void SetAge(int n) => Age = n;

        public void SayHello() => Console.WriteLine("Hello");
    }
}
