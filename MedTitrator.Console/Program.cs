using MedTitration.Business.Services;
using MedTitration.Models.Models;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
       Order order = new Order();
       OrderService.GetOrder(order);
        

        TitratorService titrate = new TitratorService();

        if (order.LowerDose > 10)
        {
            titrate.TitrateDripML(order);
            titrate.TitrateDripMg(order);
        }
        else 
        {
            titrate.GiveDose(order) ;
        }
    }
}