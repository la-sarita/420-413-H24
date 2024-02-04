using System;

namespace CSharp_420_413.POO.Classes.ClassesIntro
{
    class Person
    {
        private string _name;        // field

        public DateTime Birthday { get; set; }
        public string Name          // property
        { get; set; }               // (auto-implemented property)

        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }
        public int age              // Calculated property
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                return timeSpan.Days / 365;
            }
        }
    }
}
