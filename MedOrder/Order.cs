using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using MedOrder;

namespace MedOrder
{
    //the order needs to return dosage and units only
    public class Order : IMed
    {
        //order properties
        public string medName { get; set; }
        public decimal upperDose { get; set; }
        public string upperDoseUnit { get; set; }
        public decimal lowerDose { get; set; }
        public string lowerDoseUnit { get; set; }

        //make new order
        public void getOrder(Order order)
        {
            Console.WriteLine(" ------------------ ORDER INFORMATION ------------------ ");
            Console.WriteLine("Enter medication name:");
            order.medName = Console.ReadLine();
            Console.WriteLine("Enter the ordered dosage: ");
            order.upperDose = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What unit of measurement?");
            order.upperDoseUnit = Console.ReadLine();
            Console.WriteLine("Now the lower number measurement:");
            order.lowerDose = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Measured in: ");
            order.lowerDoseUnit = Console.ReadLine();

            Console.WriteLine($"{order.upperDose}{order.upperDoseUnit}/{order.lowerDose}{order.lowerDoseUnit}");
            Console.WriteLine(" ------------------------------------------------------ ");

        }
    }
}
