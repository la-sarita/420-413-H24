using System;

namespace CSharp_420_413.Basics.ControleInstructions
{
    internal class Iterative
    {
        public const int MaxNumber = 5;

        public static void ForLoop()
        {
            for (int number = 0; number < MaxNumber; number++)
            {
                Console.WriteLine(number);
            }
        }

        public static void WhileLoop()
        {
            int i = 0;

            while (i < MaxNumber)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void DoWhileLoop()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < MaxNumber);
        }

        public static void ForeachLoop()
        {
            string salutation = "Bonjour";

            foreach (char lettre in salutation)
            {
                Console.WriteLine(lettre);
            }
        }
    }
}
