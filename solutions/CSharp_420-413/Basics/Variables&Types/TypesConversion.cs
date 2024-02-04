using System;

namespace CSharp_420_413.Basics.Variables_Types
{
    internal class TypesConversion
    {

        public static void ConvertNumbers()
        {
            int entier = int.Parse("123");

            double number;
            bool result = double.TryParse("300.75", out number);

            Console.WriteLine("We parsed \"123\" to 123");
            Console.WriteLine("We parsed \"300.75\" to 300.75");
        }
    }
}
