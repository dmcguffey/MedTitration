using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTitration.Models.Models
{
    public  class Med
    {
        public Med() { }

        public string Name { get; set; }
        public decimal UpperDose { get; set; }
        public string UpperDoseUnit { get; set; }
        public decimal LowerDose { get; set; }
        public string LowerDoseUnitUnit { get; set;}
    }
}
