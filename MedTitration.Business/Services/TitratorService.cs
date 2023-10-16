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

            return ($"{CorrectDose} {order.LowerDoseUnit}");


        }

        public string TitrateDripML(Order order)
        {
        /*    if (order.LowerDose < 0 || order.LowerDoseUnit.ToLower() != "ml") 
            {
                return "cannot provide dosage to infuse in ml. Please check your units.";
            }*/
            var MeasuredDose = order.LowerDose / order.TimeHours;
            return ($"{MeasuredDose} ml/hr");

        }

        public string TitrateDripMg(Order order)
        {
            return ($"{order.UpperDose / order.TimeHours} mg/hr");
        }

        public string ConvertMgToMcG(Order order)
        {
            var McgDose = order.UpperDose * 1000;
            return ($"{McgDose / (order.TimeHours * 60)}");
        }
    }
}
