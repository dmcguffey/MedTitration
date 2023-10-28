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
        [InlineData (0, 100, 2, "Order not provided.")]
        [InlineData (100, 0, 0, "Medication not stocked in supply. Unable to provide the dose.")]

        public void GiveDose(decimal OrderUpperDose, decimal MedUpperDose, decimal MedLowerDose, string dose)
        {
            //ARRANGE
            Order order = new Order
            {
                UpperDose = OrderUpperDose,
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

        [Theory]
        [InlineData (1000, 2, "500 ml/hr")]
        [InlineData (250, 3, "83.33 ml/hr")]
        [InlineData (500, 1, "500 ml/hr")]
        [InlineData (1000, 3, "333.33 ml/hr")]
        [InlineData (100, 5, "20 ml/hr")]
        [InlineData (0, 0, "Cannot provide rate.")]
        [InlineData (1000, 0, "Bolus")]

        public void TitrateDripMl(decimal MlDose, int hours, string rate)
        {
            //ARRANGE
            Order order = new Order
            {
                LowerDose = MlDose,
                TimeHours = hours
            };
            TitratorService service = new TitratorService();
            //ACT
            var CorrectRate = service.TitrateDripML(order);
            //ASSERT
            Xunit.Assert.Equal(rate, CorrectRate);
        }

        [Theory]
        [InlineData (250, 1, "250 mg/hr")]
        [InlineData (1000, 3, "333.33 mg/hr")]
        [InlineData (0, 1, "Cannot provide rate.")]
        [InlineData (100, 0, "Bolus")]

        public void TitrateDripMg(decimal MgDose, int hours, string rate)
        {
            //ARRANGE
            Order order = new Order
            {
                UpperDose = MgDose,
                TimeHours = hours
            };
            TitratorService service = new TitratorService();
            //ACT
            var CorrectRate = service.TitrateDripMg(order);
            //ASSERT
            Xunit.Assert.Equal(rate, CorrectRate);
        }
    }
}
