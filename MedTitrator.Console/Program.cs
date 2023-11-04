using MedTitration.Business.Services;
using MedTitration.Models.Models;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
       Order order = new Order();
       OrderService.GetOrder(order);

        Med med = new Med 
        {Name =  "Solumedrol", 
         UpperDose = 100,
         LowerDose = 2, } ;
        

        TitratorService titrate = new TitratorService();

        if (order.LowerDose > 10)
        {
            Console.WriteLine(titrate.TitrateDripML(order));
            Console.WriteLine(titrate.TitrateDripMg(order));
        }
        else 
        {
            Console.WriteLine(titrate.GiveDose(order, med));
        }
    }
}