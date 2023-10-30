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
            Console.WriteLine(titrate.TitrateDripML);
            Console.WriteLine(titrate.TitrateDripMg);
        }
        else
        {
            Console.WriteLine(titrate.GiveDose);
        }
    }
}