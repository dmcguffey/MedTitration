using MedTitration.Business.Interfaces;
using MedTitration.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTitration.Business.Services
{
    public class OrderService : IOrderService
    {
        public OrderService()
        {
                
        }
        public void GetOrder(Order order)
        {
            Console.WriteLine(" ------------------ ORDER INFORMATION ------------------ ");
            Console.WriteLine("Enter medication name. The dose will be interpreted as mg/ml:");
            order.MedName = Console.ReadLine();
            Console.WriteLine("Enter the ordered dosage: ");
            order.UpperDose = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Now the lower number measurement:");
            order.LowerDose = decimal.Parse(Console.ReadLine());
            if (order.LowerDose >= 50)
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

            Console.WriteLine($"{order.UpperDose}{order.Mg}/{order.LowerDose}{order.Ml} \n To be given over {order.TimeHours} hours.");
            Console.WriteLine(" ------------------------------------------------------ ");
        }
    }
}
