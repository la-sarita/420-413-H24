using System;

namespace CSharp_420_413.Basics.ControleInstructions
{
    public class Conditional
    {
        static int nombre = 8;
        public static void InstructionIf()
        {

            if (nombre % 2 == 0)
            {
                Console.WriteLine($"{nombre} est un nombre pair");
            }
        }
        public static void InstructionIfElse()
        {
            if (nombre % 2 == 0)
            {
                Console.WriteLine($"{nombre} est un nombre pair");
            }
            else
            {
                Console.WriteLine($"{nombre} est un nombre impair");
            }
        }

        public static void InstructionIfElseElse()
        {
            if (nombre < 5)
            {
                Console.WriteLine($"{nombre} est plus petit que 5");
            }
            else if (nombre == 5)
            {

                Console.WriteLine($"{nombre} est égal à 5");
            }
            else
            {
                Console.WriteLine($"{nombre} est plus grand que 5");
            }
        }

        public static void ExpressionTernaire()
        {
            string test = nombre % 2 == 0 ? "pair" : "impair";

            Console.WriteLine($"{nombre} est un nombre {test}");
        }

        public static void InstructionSwitch()
        {
            int jour = 3;

            switch (jour)
            {
                case 1:
                    Console.WriteLine("Lundi");
                    break;
                case 2:
                    Console.WriteLine("Mardi");
                    break;
                case 3:
                    Console.WriteLine("Mercredi");
                    break;
                case 4:
                    Console.WriteLine("Jeudi");
                    break;
                case 5:
                    Console.WriteLine("Vendredi");
                    break;
                case 6:
                    Console.WriteLine("Samedi");
                    break;
                case 7:
                    Console.WriteLine("Dimance");
                    break;
                default:
                    Console.WriteLine("Ce n'est pas un jour valide");
                    break;
            }
        }
    }
}
