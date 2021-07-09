namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var smApartment = new SmallApartment();
            var person = new Person
            {
                House = smApartment,
                Name = "Anton"
            };
            person.ShowData();
        }
    }
}
