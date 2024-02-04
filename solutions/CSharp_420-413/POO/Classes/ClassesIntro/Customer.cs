using System.Collections.Generic;

namespace CSharp_420_413.POO.Classes.ClassesIntro
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;       // Default or parameterless constructor
        public Customer()
        {           // Orders has to be initialized here, otherwise it             
                    // will be a null reference. As a best practice,             
                    // anytime your class contains a list, always            
                    // initialize the list.
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()  // Calls the default constructor
        {
            this.Id = id;
        }

        // We can do this too but it's not a good practice because it became hard to read
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
