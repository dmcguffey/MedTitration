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
            if (order == null || order.UpperDose == 0 && order.LowerDose == 0)
            {
                return ("Order not provided.");
            }
            if (med == null || med.UpperDose == 0 && med.LowerDose == 0)
            {
                return ("Medication not stocked in supply. Unable to provide the dose.");
            }
            else
            {
                var CorrectDose = order.UpperDose / (med.UpperDose / med.LowerDose);

                return ($"{CorrectDose} {order.Ml}");
            }



        }

        public string TitrateDripML(Order order)
        {
            if (order == null || order.LowerDose == 0) 
            {
                return "Cannot provide rate.";
            }

            if (order.TimeHours == 0)
            {
                return "Bolus";
            }
            var MeasuredDose = order.LowerDose / order.TimeHours;
            return ($"{Math.Round(MeasuredDose, 2)} ml/hr");

        }

        public string TitrateDripMg(Order order)
        {
            if (order == null || order.UpperDose == 0)
            {
                return "Cannot provide rate.";
            }

            if (order.TimeHours == 0)
            {
                return "Bolus";
            }
            return ($"{Math.Round((order.UpperDose / order.TimeHours), 2)} mg/hr");
        }
    }
}
