using MedTitration.Business.Interfaces;
using MedTitration.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTitration.Business.Services
{
    public class OrderService
    {
        public OrderService()
        {
                
        }
        public static void GetOrder(Order order)
        {
            Console.WriteLine(" ------------------ ORDER INFORMATION ------------------ ");
            Console.WriteLine("Enter medication name:");
            order.MedName = Console.ReadLine();
            Console.WriteLine("Enter the ordered dosage: ");
            order.UpperDose = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What unit of measurement?");
            order.UpperDoseUnit = Console.ReadLine();
            Console.WriteLine("Now the lower number measurement:");
            order.LowerDose = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Measured in: ");
            order.LowerDoseUnit = Console.ReadLine();
            if (order.LowerDose >= 50 && order.LowerDoseUnit.ToLower() == "ml")
            {
                Console.WriteLine("This dose requires a duration to give. How long are you wanting to distribute dose?");
                order.TimeHours = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Outside of general safety parameters. Please give a safe time dosage.");
                    order.TimeHours = int.Parse(Console.ReadLine());
                }
                while (order.TimeHours > 48);
            }
            else
            {
                order.TimeHours = 0;
            }

            Console.WriteLine($"{order.UpperDose}{order.UpperDoseUnit}/{order.LowerDose}{order.LowerDose} \n To be given over {order.TimeHours} hours.");
            Console.WriteLine(" ------------------------------------------------------ ");
        }
    }
}
