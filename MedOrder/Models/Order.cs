using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTitration.Models.Models
{
    public class Order
    {
        public Order() { }
        public string MedName { get; set; }
        public decimal UpperDose { get; set; }
        public string UpperDoseUnit { get; set; }
        public decimal LowerDose { get; set; }
        public string LowerDoseUnit { get;set; }
        public int TimeHours { get; set; }
    }
}
