using CSharp_420_413.POO.Classes.ClassesIntro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.POO.Inheritance
{
    public partial class CustomerInfo
    {
        private int id;
        private string name;
        private string address;
        private List<Order> orders;

        public CustomerInfo()
        {
            this.orders = new List<Order>();
        }
    }
}
