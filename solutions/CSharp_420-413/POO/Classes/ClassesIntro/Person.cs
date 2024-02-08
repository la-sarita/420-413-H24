using System;
using System.Web;

namespace CSharp_420_413.POO.Classes.ClassesIntro
{
    class Person
    {
        private int _age;        // field

        public DateTime Birthday { get; set; }
        public string Name          // property
        { get; set; }               // (auto-implemented property)

        //private string _name;
        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }
        public int Age              // Calculated property
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                return timeSpan.Days / 365;
            }
        }
    }
}
