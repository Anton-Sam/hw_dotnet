using System;
using System.Collections.Generic;
using System.Linq;

namespace HW07.Booking.Com.Models
{
    static class BookingService
    {
        private static List<User> _users = new List<User>();
        private static List<Room> _rooms = new List<Room>();
        private static Dictionary<Guid, List<Room>> _bookingDict = new Dictionary<Guid, List<Room>>();

        public static void RegisterUser(User user)
        {
            if (_users.Contains(user))
                throw new ArgumentException("User is exist!");
            _users.Add(user);
        }

        public static void RegisterUser(string mail, string name, string password)
        {
            var user = new User(mail, name, password);
            RegisterUser(user);
        }

        public static User LoginUser(string mail, string password)
        {
            var users = _users.Where(u => u.Mail.Equals(mail) && u.Password.Equals(password));
            if (users.Count() > 0)
            {
                Console.WriteLine("Succesfull login!");
                return users.First();
            }

            else
                throw new ArgumentException("Incorrect user data!");
        }

        public static void AddRoom(Room room)
        {
            if (_rooms.Where(r => r.Id.Equals(room.Id)).Count() > 0)
            {
                Console.WriteLine("This room is already exist");
                return;
            }
            _rooms.Add(room);
        }

        public static IEnumerable<Room> SearchRooms(string hotelName) =>
            _rooms.Where(a => a.IsFree && a.Hotel.Name.Equals(hotelName, StringComparison.OrdinalIgnoreCase));

        public static IEnumerable<Room> SearchRooms(string hotelName, string hotelLocation) =>
            _rooms.Where(a => a.IsFree && a.Hotel.Name.Equals(hotelName, StringComparison.OrdinalIgnoreCase) && a.Hotel.Location.Equals(hotelLocation, StringComparison.OrdinalIgnoreCase));

        public static IEnumerable<Room> SearchRooms(int maxCostPerNight, int beds = 1) =>
            _rooms.Where(a => a.IsFree && a.CostPerNight < maxCostPerNight && a.BedsCount == beds);

        public static void BookRoom(User user, Room room, int period)
        {
            var index = _rooms.FindIndex(r => r.Id.Equals(room.Id));
            if (index < 0)
            {
                Console.WriteLine("You try to book non-exist room!");
                return;
            }
            room.Book(period);
            _rooms[index] = room;
            AddToBookingDict(user, room);
        }

        private static void AddToBookingDict(User user, Room room)
        {
            if (_bookingDict.ContainsKey(user.Id))
                _bookingDict[user.Id].Add(room);
            else
                _bookingDict.Add(user.Id, new List<Room>() { room });
        }

        public static void Purchase(User user)
        {
            if (_bookingDict.ContainsKey(user.Id))
            {
                _bookingDict[user.Id].ForEach(r => r.Purchase());
                _bookingDict[user.Id].Clear();
            }
            else
                Console.WriteLine("You have not book any room!");
        }
    }
}
