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

        public string GiveDose(Order order, Med med)
        {
            if (order == null)
            {
                return ("Order not provided.");
            }
            if (med == null)
            {
                return ("Medication not stocked in supply. Unable to provide the dose.");
            }
            //CorrectDose = Order / StockConcentration
            //CorrectDose = (50mg) / (100mg / 2ml)
            //CorrectDose = 50mg / (50mg/ 1ml)
            //CorrectDose = 1ml
            var CorrectDose = order.UpperDose / (med.UpperDose / med.LowerDose);

            return ($"{CorrectDose} {order.Ml}");


        }

        public string TitrateDripML(Order order)
        {
            if (order == null || order.LowerDose == 0) 
            {
                return "Cannot provide rate.";
            }
            var MeasuredDose = order.LowerDose / order.TimeHours;
            return ($"{Math.Round(MeasuredDose, 2)} {order.Ml}/hr");

        }

        public string TitrateDripMg(Order order)
        {
            return ($"{order.UpperDose / order.TimeHours} {order.Mg}/hr");
        }
    }
}
