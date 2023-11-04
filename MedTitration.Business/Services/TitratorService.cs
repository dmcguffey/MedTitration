using MedTitration.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTitration.Business.Services
{
    public class TitratorService
    {
        public TitratorService() { }
        //for IV push medications
        public void GiveDose(Order order, Med med)
        {
            if (order == null || order.UpperDose == 0 && order.LowerDose == 0)
            {
                Console.WriteLine("Order not provided.");
            }
            if (med == null || med.UpperDose == 0 && med.LowerDose == 0)
            {
                Console.WriteLine("Medication not stocked in supply. Unable to provide the dose.");
            }
            else
            {
                var CorrectDose = order.UpperDose / (med.UpperDose / med.LowerDose);

                Console.WriteLine($"{CorrectDose} {order.Ml}");
            }



        }

        public void TitrateDripML(Order order)
        {
            if (order == null || order.LowerDose == 0) 
            {
                Console.WriteLine("Cannot provide rate.");
            }

            if (order.TimeHours == 0)
            {
                Console.WriteLine("Bolus");
            }
            var MeasuredDose = order.LowerDose / order.TimeHours;
            Console.WriteLine($"{Math.Round(MeasuredDose, 2)} {order.Ml}/hr");

        }

        public void TitrateDripMg(Order order)
        {
            if (order == null || order.UpperDose == 0)
            {
                Console.WriteLine("Cannot provide rate.");
            }

            if (order.TimeHours == 0)
            {
                Console.WriteLine("Bolus");
            }
            Console.WriteLine($"{Math.Round((order.UpperDose / order.TimeHours), 2)} {order.Mg}/hr");
        }
    }
}
