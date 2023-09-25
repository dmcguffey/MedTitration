using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrder
{
    public class Medication : IMed
    {
        public string medName { get; set; }
        public decimal upperDose { get; set; }
        public string upperDoseUnit { get; set; }
        public decimal lowerDose { get; set; }
        public string lowerDoseUnit { get; set; }
        //constructor for medication
        public Medication (decimal upperDose, string upperDoseUnit, decimal lowerDose, string lowerDoseUnit)
        {
            this.upperDose = upperDose;
            this.upperDoseUnit = upperDoseUnit;
            this.lowerDose = lowerDose;
            this.lowerDoseUnit = lowerDoseUnit;
        }
    }
}
