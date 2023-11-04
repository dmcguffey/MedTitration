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

        public string Name { get; set; }
        public decimal UpperDose { get; set; }
        public string Mg = "mg";
        public decimal LowerDose { get; set; }
        public string Ml = "ml";

        public decimal TimeHours { get; set; }
    }
}
