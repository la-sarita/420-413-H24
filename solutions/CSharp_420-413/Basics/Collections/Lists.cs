using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.Basics.Collections
{
    internal class Lists
    {
        static void UseSimpleCollection()
        {
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

        static void UseSimpleCollectionWithInitialization()
        {
            var courses = new List<string>() { "420-210", "420-312", "420-313", "420-413" };

            foreach (var course in courses)
            {
                Console.Write(course + " ");
            }
        }

        static void UseSimpleCollectionUsingForLoop()
        {
            var courses = new List<string>() { "420-210", "420-312", "420-313", "420-413" };

            for (int i = 0; i < courses.Count; i++)
            {
                Console.Write(courses[i] + " ");
            }

        }

        static void UseSimpleCollectionOtherExample()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(10);
            primeNumbers.Add(20);
            primeNumbers.Add(30);
            primeNumbers.Add(40);

            Console.WriteLine("Le nombre d'élements de cette list est : " + primeNumbers.Count);
        }

        static void UseSimpleCollectionWithAddRange() {
            var cities = new string[] { "Mumbai", "London", "New York" };
            
            var popularCities = new List<string>();

            // Add an array in a list
            popularCities.AddRange(cities);

            var bigCities = new List<string>();

            // Add a list in a list
            bigCities.AddRange(popularCities);

            Console.WriteLine(popularCities);
            Console.WriteLine(bigCities);
        }

        static void UseSimpleCollectionAccessElements()
        {
            var numbers = new List<int>() { 10, 20, 30, 40, 50 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void UseSimpleCollectionInsertElements()
        {
            var numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);

            foreach (int number in numbers) {  Console.WriteLine(number); }
        }

        static void UseSimpleCollectionRemoveElements()
        {
            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10);     // Remove the first element equal to 10
            numbers.RemoveAt(2);    // Remove the 3rd element

            foreach (int number in numbers) { Console.WriteLine(number); }
        }

        static void UseSimpleCollectionCheckElementExists()
        {
            var numbers = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine(numbers.Contains(10));    // true
            Console.WriteLine(numbers.Contains(11));    // false
            Console.WriteLine(numbers.Contains(20));    // true
        }
    }
}