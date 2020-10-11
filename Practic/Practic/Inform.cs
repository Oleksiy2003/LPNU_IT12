using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    class Inform
    {
        public void Buy(User user,Product product)
        {
            user.ReduceBalance(1000);
            Console.WriteLine($"Покупець:{user.Name}  Товар:{product.Name}");
        }
    }
}
