using System;
using System.Collections.Generic;

namespace CSharp_420_413.Basics.Collections
{
    public class Lists
    {
        public static void UseSimpleCollection()
        {
            Console.WriteLine("\n=============== Create SimpleCollection ================");

            var courses = new List<string>();
            courses.Add("420-210");
            courses.Add("420-312");
            courses.Add("420-313");
            courses.Add("420-413");

            foreach (var course in courses)
            {
                Console.Write(course + " ");
            }
        }

        public static void UseSimpleCollectionWithInitialization()
        {
            Console.WriteLine("\n=============== CollectionWithInitialization ================");

            var courses = new List<string>() { "420-210", "420-312", "420-313", "420-413" };

            foreach (var course in courses)
            {
                Console.Write(course + " ");
            }
        }

        public static void UseSimpleCollectionUsingForLoop()
        {
            Console.WriteLine("\n=============== CollectionUsingForLoop ================");

            var courses = new List<string>() { "420-210", "420-312", "420-313", "420-413" };

            for (int i = 0; i < courses.Count; i++)
            {
                Console.Write(courses[i] + " ");
            }

        }

        public static void UseSimpleCollectionOtherExample()
        {
            Console.WriteLine("\n=============== CollectionOtherExample ================");

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(10);
            primeNumbers.Add(20);
            primeNumbers.Add(30);
            primeNumbers.Add(40);

            Console.WriteLine("Le nombre d'élements de cette list est : " + primeNumbers.Count);
        }

        public static void UseSimpleCollectionWithAddRange()
        {
            Console.WriteLine("\n=============== CollectionWithAddRange ================");

            var cities = new string[] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // Add an array in a list
            popularCities.AddRange(cities);

            var bigCities = new List<string>();

            // Add a list in a list
            bigCities.AddRange(popularCities);

            Console.WriteLine(popularCities.Count);
            Console.WriteLine(bigCities.Count);
        }

        public static void UseSimpleCollectionAccessElements()
        {
            Console.WriteLine("\n=============== CollectionAccessElements ================");

            var numbers = new List<int>() { 10, 20, 30, 40, 50 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void UseSimpleCollectionInsertElements()
        {
            Console.WriteLine("\n=============== CollectionInsertElements ================");

            var numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);

            foreach (int number in numbers) { Console.WriteLine(number); }
        }

        public static void UseSimpleCollectionRemoveElements()
        {
            Console.WriteLine("\n=============== CollectionRemoveElements ================");

            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10);     // Remove the first element equal to 10
            numbers.RemoveAt(2);    // Remove the 3rd element

            foreach (int number in numbers) { Console.WriteLine(number); }
        }

        public static void UseSimpleCollectionCheckElementExists()
        {
            Console.WriteLine("\n=============== CollectionCheckElementExists ================");

            var numbers = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine(numbers.Contains(10));    // true
            Console.WriteLine(numbers.Contains(11));    // false
            Console.WriteLine(numbers.Contains(20));    // true
        }
    }
}