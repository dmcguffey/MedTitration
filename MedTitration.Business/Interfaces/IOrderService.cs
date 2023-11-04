using MedTitration.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTitration.Business.Interfaces
{
    internal interface IOrderService
    {
        public void GetOrder(Order order);
    }
}
