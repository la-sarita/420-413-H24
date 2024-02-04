using System;

namespace CSharp_420_413.POO.Classes.ClassesIntro
{
    public class Order
    {
        public int Id { get; set; }
        public double TotalAmount { get; set; }
        public int TotalQuantity { get; set; }
        public int NbItems { get; set; }
        public int Status { get; set; } = 0;
        public readonly DateTime OrderDate = DateTime.Now;
        public DateTime ChipOrderDate { get; set; }


        public Order(int id, double totalAmount, int totalQuantity, int nbItems)
        {
            Id = id;
            TotalAmount = totalAmount;
            TotalQuantity = totalQuantity;
            NbItems = nbItems;
        }
        public Order(int id, double totalAmount, int totalQuantity, int nbItems, int status, DateTime chipOrderDate)
            : this(id, totalAmount, totalQuantity, nbItems)
        {
            Status = status;
            ChipOrderDate = chipOrderDate;
        }
    }
}