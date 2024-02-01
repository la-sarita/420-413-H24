using System;

namespace CSharp_420_413.Basics.ControleInstructions
{
    internal class Saut
    {
        const int maxNumber = 10;

        public static void BreakInstructions()
        {
            Console.WriteLine("InstructionsBreak");

            for (int i = 0; i < maxNumber; i++)
            {
                if (i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }

        public static void ContinueInstructions()
        {
            Console.WriteLine("InstructionsContinue");

            for (int i = 0; i < maxNumber; i++)
            {
                if (i > 3 && i < 9)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        public static void BreakInstructionInWhileLoop()
        {
            Console.WriteLine("InstructionsBreakBoucleWhile");

            int i = 0;

            while (i < maxNumber)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
        }

        public static void ContinueInstructionInWhileLoop()
        {
            Console.WriteLine("InstructionsContinueBoucleWhile");

            int i = 0;

            while (i < maxNumber)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
