using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_420_413.Basics.Collections
{
    internal class Dictionaries
    {
        public static void Create()
        {
            Console.WriteLine("=============== Create Dictionary ================");

            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (KeyValuePair<int, string> item in numberNames)
            {
                Console.WriteLine("Key: {0}, value: {1}", item.Key, item.Value);
            }
        }

        public static void Access()
        {
            Console.WriteLine("=============== Access Dictionary ================");

            var cities = new Dictionary<string, string>() {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington" },
                { "India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities["UK"]);        // London, Manchester, Birmingham
            Console.WriteLine(cities["USA"]);       // Chicago, New York, Washington

            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            if (cities.TryGetValue("France", out string result))
            {
                Console.WriteLine(result);
            }

            // Acces elements with for loop
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine($"key: {cities.ElementAt(i).Key}, Value: {cities.ElementAt(i).Value}");
            }
        }

        public static void Update()
        {
            Console.WriteLine("=============== Update Dictionary ================");

            var cities = new Dictionary<string, string>() {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington" },
                { "India", "Mumbai, New Delhi, Pune"}
            };

            cities["UK"] = "Liverpool, Bristol";
            cities["USA"] = "Los Angelos, Boston";

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            foreach (var city in cities)
            {
                Console.WriteLine("Key: {0}, value: {1}", city.Key, city.Value);
            }
        }

        public static void Delete()
        {
            Console.WriteLine("=============== Delete Dictionary ================");

            var cities = new Dictionary<string, string>() {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington" },
                { "India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine("Total elements = " + cities.Count);      // 3
            cities.Remove("UK");

            if (cities.ContainsKey("France"))
            { // check if the key exists before removing it
                cities.Remove("France");
            }

            Console.WriteLine("Total elements after remove = " + cities.Count);      // 2

            cities.Clear();

            Console.WriteLine("Total elements after clear = " + cities.Count);      // 0
        }

    }
}
