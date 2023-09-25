using MedOrder;
using System;
using System.Collections.Generic;
internal class Program
//*Med titration is done converting the different units of measurement in a medication to another set in order to administer the correct dose. For example, If I were to give 50 mg solumedrol
//and had a 100mg/2mL concentration, I need to convert the medication to the 50mg/1mL to give the accurate med
//
//Create a class medication*//

{
    private static void Main(string[] args)
    {
        Order order = new Order();
        order.getOrder(order);
    }
}