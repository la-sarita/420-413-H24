using CSharp_420_413.POO.Inheritance;

namespace CSharp_420_413.POO.Classes.ClassesIntro
{
    sealed class Car : Vehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }

        public Car()
        {
        }
        public Car(string model, int year, string color, int maxSpeed)
        {
            Model = model;
            Year = year;
            Color = color;
            MaxSpeed = maxSpeed;
        }


        override public string ToString()
        {
            return $"{Model} {Year} color {Color} and it's max speed {MaxSpeed}";
        }
    }

}
