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
        public void SubmitOrder(Order orderSubmitted) => orders.Add(orderSubmitted);

        public bool HasOutstandingOrders() => orders.Count > 0;
    }

    // The result of the compilation of CustomerInfo class and CustomerPartialClass class will be :
    //public class CustomerInfo
    //{
    //    private int id;
    //    private string name;
    //    private string address;
    //    private List<Order> orders;

    //    public CustomerInfo()
    //    {
    //          this.orders = new List<Order>();
    //    }

    //    public void SubmitOrder(Order orderSubmitted) => orders.Add(orderSubmitted);

    //    public bool HasOutstandingOrders() => orders.Count > 0;
    //}
}
