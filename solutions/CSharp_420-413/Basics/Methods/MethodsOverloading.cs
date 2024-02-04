using System;

namespace CSharp_420_413.Basics.MethodTypes
{
    internal class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        // Instead of that in that specific case we can use this method
        // because the parameters have the same type and will all be added
        // as if we received an array of parameters. We can use his method:
        public static int Add(params int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }

        public static void UseTheAddMethodWithParamsModifier()
        {
            int x = Add(5, 6, 8, 9, 13);
            // or
            int y = Add(new int[] { 5, 6, 8, 9, 13 });

            Console.WriteLine("5 + 6 + 8 + 9 + 13 = ", x);
            Console.WriteLine("5 + 6 + 8 + 9 + 13 = ", y);
        }


    }

    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // The Move method overloaded here
        public void move(Point newPointLocation)
        {
            if (newPointLocation == null)
                throw new ArgumentNullException(nameof(newPointLocation));

            move(newPointLocation.X, newPointLocation.Y);
        }

        // Another overloading of the Move method
        public void move(Point newPointLocation, int speed) { }
    }

}
