using MedTitration.Business.Services;
using MedTitration.Models.Models;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace MedTitration.Test.Tests
{
    public class TitratorServiceTest
    {

        [Theory]
        [InlineData (50, 100, 2, "1 ml")]
        [InlineData (12.5, 25, 1, "0.5 ml")]
        [InlineData (20, 20, 1, "1 ml")]
        [InlineData (0, 100, 2, "Order not provided")]

        public void GiveDose(decimal OrderUpperDose, decimal MedUpperDose, decimal MedLowerDose, string dose)
        {
            //ARRANGE
            Order order = new Order
            {
                UpperDose = OrderUpperDose,
                LowerDoseUnit = "ml"
            };
            Med med = new Med
            {
                UpperDose = MedUpperDose,
                LowerDose = MedLowerDose
            };
            TitratorService service = new TitratorService();
            //ACT
            var Dose = service.GiveDose(order, med);
            //ASSERT
            Xunit.Assert.Equal(dose, Dose);
        }
    }
}
