using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var addr = "1123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";
            Console.WriteLine(Travel(addr, "OH 43071"));
        }

        private static string Travel(string addresses, string zipcode)
        {
            if (!Regex.Match(zipcode,@"^[A-Z]{2}\s\d{5}$").Success)
                return $"{zipcode}:/";

            var addrList = addresses.Split(',').Where(s => s.EndsWith(zipcode));               
            var houses = new List<string>();
            var towns = new List<string>();

            foreach (var addr in addrList)
            {
                var house = Regex.Match(addr, @"^\d+").Value;
                houses.Add(house);
                var town = Regex.Match(addr,$@"(?<={house}\s).+(?=\s{zipcode})").Value;
                towns.Add(town);
            }

            return $"{zipcode}:{string.Join(',', towns)}/{string.Join(',', houses)}";
        }
    }
}
