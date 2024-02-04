using System;

namespace CSharp_420_413.Basics
{
    internal class PrimitiveTypes
    {

        public static void SyntaxeOverview()
        {
            byte number = 2;
            int count = 25;                      // integer is the data type by default used for representing the integral numbers
            float temperature = 34.4f;           // If we don't add the f or F after the value we will get an error
                                                 // (defaut value is double and double is bigger than a float)

            double amount = 180065.75;            // double is the data type by default used for representing the real numbers
            decimal biggerAmount = 5866.850m;     // decimal is the biggest type used for representing the real numbers
            char caractere = 'S';
            bool isActive = false;
            var anotherChar = 'D';

            Console.WriteLine("================ Primitive types ================");
            Console.WriteLine("Variables with primitive types example: {0} - {1} - {2} - {3} - {4} - {5} - {6} - {7}",
                number, count, temperature, amount, biggerAmount, caractere, isActive, anotherChar);
            Console.WriteLine("Min value of decimal type is: {0} \n" +
                "Max value of decimal type is: {1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
