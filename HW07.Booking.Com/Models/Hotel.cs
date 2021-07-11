using System;

namespace HW07.Booking.Com.Models
{
    class Hotel
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; private set; }
        public string Location { get; private set; }

        public Hotel(string name, string location) => (Name, Location) = (name, location);
    }
}
