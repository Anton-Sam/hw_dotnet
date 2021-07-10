using HW07.Booking.Com.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW07.Booking.Com
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTestDate();
        }

        private static void CreateTestDate()
        {
            BookingService.RegisterUser("anton@gmail.com","Anton", "123");
            var user = BookingService.LoginUser("anton@gmail.com", "123");

            var hotel1 = new Hotel("Minsk-hotel", "Minsk");
            var hotel2 = new Hotel("Hilton", "Gomel");

            var rooms = new List<Room>
            {
                new Room(hotel1, 30, 1, 120),
                new Room(hotel1, 100, 3, 250),
                new Room(hotel2, 200, 6, 500)
            };

            rooms.ForEach(BookingService.AddRoom);

            var search1 = BookingService.SearchRooms("minsk-hotel");
            var search2 = BookingService.SearchRooms(150);

            BookingService.BookRoom(user,search1.First(),5);

            BookingService.Purchase(user);
        }



    }
}
