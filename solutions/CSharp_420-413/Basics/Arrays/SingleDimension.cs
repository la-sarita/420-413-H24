using System;

namespace CSharp_420_413.Basics.Arrays
{
    internal class SingleDimension
    {
        // Declaration without initialization
        static int[] numbers;

        public static void DeclarationAndInitialization()
        {
            Console.WriteLine("=============== DeclarationAndInitialization ================");
            // Array initialization
            numbers = new int[4] { 1, 2, 3, 4 };

            // Declaration with initialisation
            // Create an array of 4 elements and add values right away
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
        }

        public static void AccessToElements()
        {
            Console.WriteLine("=============== AccessToElements ================");
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Access to the first element
            Console.WriteLine(cars[0]);
        }

        public static void ModifyElements()
        {
            Console.WriteLine("=============== ModifyElements ================");
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Print the value of the first element before the modification
            Console.WriteLine(cars[0]);

            // Modify the value of the first element
            cars[0] = "Opel";

            // Print the value of the first element after the modification
            Console.WriteLine(cars[0]);
        }

        public static void PrintSize()
        {
            Console.WriteLine("=============== PrintSize ================");
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            Console.WriteLine(cars.Length);
        }

        public static void CreationOtherWays()
        {
            Console.WriteLine("=============== CreationOtherWays ================");
            // Create an array of 4 elements without specifying the size
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of 4 elements, ommiting the new keyword, and without specifying the size
            string[] courses = { "420-312", "420-313", "420-210", "420-413" };
        }

        public static void IterateWithForLoop()
        {
            Console.WriteLine("=============== IterateWithForLoop ================");
            var cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

        public static void IterateWithForeachLoop()
        {
            Console.WriteLine("=============== IterateWithForeachLoop ================");
            var cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
