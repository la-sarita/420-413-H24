using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_420_413.Basics.Arrays
{
    internal class SingleDimension
    {
        // Declaration without initialization
        static int[] numbers;

        static void DeclarationAndInitialization()
        {
            // Array initialization
            numbers = new int[4] { 1, 2, 3, 4 };

            // Declaration with initialisation
            // Create an array of 4 elements and add values right away
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
        }

        static void AccessToElements()
        {
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Access to the first element
            Console.WriteLine(cars[0]);
        }

        static void ModifyElements()
        {
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Print the value of the first element before the modification
            Console.WriteLine(cars[0]);

            // Modify the value of the first element
            cars[0] = "Opel";

            // Print the value of the first element after the modification
            Console.WriteLine(cars[0]);
        }

        static void PrintSize()
        {
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            Console.WriteLine(cars.Length);
        }

        static void CreationOtherWays()
        {
            // Create an array of 4 elements without specifying the size
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of 4 elements, ommiting the new keyword, and without specifying the size
            string[] courses = { "420-312", "420-313", "420-210", "420-413" };
        }

        static void IterateWithForLoop()
        {
            var cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

        static void IterateWithForeachLoop()
        {
            var cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
