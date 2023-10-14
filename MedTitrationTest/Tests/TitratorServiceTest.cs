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
        [InlineData ("2 ml")]

        public void GiveDose(Order order, Med med, string dose)
        {
            //ARRANGE
            TitratorService service = new TitratorService();
            //ACT
            var Dose = service.GiveDose(order, med);
            //ASSERT
            Assert.Equals(dose, Dose); 
        }
    }
}
