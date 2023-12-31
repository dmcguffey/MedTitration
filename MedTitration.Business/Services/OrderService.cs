﻿using MedTitration.Business.Interfaces;
using MedTitration.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTitration.Business.Services
{
    public class OrderService
    {
        public OrderService()
        {
                
        }
        public static void GetOrder(Order order)
        {
            Console.WriteLine(" ------------------ ORDER INFORMATION ------------------ ");
            Console.WriteLine("Enter medication name:");
            order.Name = Console.ReadLine();
            Console.WriteLine("Enter the ordered dosage in mg/ml: ");
            order.UpperDose = decimal.Parse(Console.ReadLine());
            order.LowerDose = decimal.Parse(Console.ReadLine());
            if (order.LowerDose >= 50)
            {
                Console.WriteLine("This dose requires a duration to give. How long are you wanting to distribute dose?");
                order.TimeHours = decimal.Parse(Console.ReadLine());
                if(order.TimeHours >= 48)
                {
                do
                {
                    Console.WriteLine("Outside of general safety parameters. Please give a safe time dosage.");
                    order.TimeHours = int.Parse(Console.ReadLine());
                }
                while (order.TimeHours > 48);
                }
            }
            else
            {
                order.TimeHours = 0;
            }

            Console.WriteLine($"Order Confirmed: {order.UpperDose}{order.Mg}/{order.LowerDose}{order.Ml} \n To be given over {order.TimeHours} hours.");
            Console.WriteLine(" ------------------------------------------------------ ");
        }
    }
}
