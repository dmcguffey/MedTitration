using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrder
{
    internal interface IMed
    {
        public string medName { get; set; }
        public decimal upperDose { get; set; }
        public string upperDoseUnit { get; set; }
        public decimal lowerDose { get; set; }
        public string lowerDoseUnit { get; set; }
    }
}
